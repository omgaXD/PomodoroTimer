using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Media;
using System.Windows.Forms;

namespace PomodoroTechnique
{
    public partial class PomodoroTimer : Form
    {
        private DateTime timerTarget;
        private int secondsSinceStart;

        private int repeatTimes;

        List<Activity> activities = new List<Activity>();

        Activity curActivity;
        SoundManager melody;
        public PomodoroTimer(List<Activity> activities, int repeat, SoundManager melody)
        {

            this.activities = activities;
            curActivity = activities.FirstOrDefault();
            repeatTimes = repeat;
            this.melody = melody;
            InitializeComponent();
            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            SetupTimer();

            
        }

        private void SetupTimer()
        {
            timerTarget = DateTime.Now.AddMinutes(curActivity.length).AddSeconds(1);
            secondsSinceStart = (int)timerTarget.Subtract(DateTime.Now).TotalSeconds;
            timerLabel.Text = (timerTarget.Subtract(DateTime.Now)).ToString("mm") + ":" + (timerTarget.Subtract(DateTime.Now)).ToString("ss");
            activityLabel.Text = curActivity.name;
            timer1.Enabled = true;
            timer1.Start();
            ClockDrawer.DrawClock(pictureBox1, secondsSinceStart, secondsSinceStart, activityLabel);
        }


        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (melody != null) melody.Stop();

            Owner.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            var substTime = (timerTarget.Subtract(DateTime.Now));
            ClockDrawer.DrawClock(pictureBox1, secondsSinceStart, (int)substTime.TotalSeconds, activityLabel);
            timerLabel.Text = substTime.ToString("mm") + ":" + substTime.ToString("ss");
            if (DateTime.Now > timerTarget)
            {
                if (melody != null)
                {
                    melody.PlayFile();
                }
                timer1.Stop();
                curActivity = activities[((activities.IndexOf(curActivity) + 1) % activities.Count)];
                if (curActivity.index == 1 && repeatTimes - 1 == 0)
                {
                    activityLabel.Text = "Таймер окончен.";
                } else
                {
                    button1.Visible = true;
                    button1.Enabled = true;
                }
                repeatTimes--;
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button1.Visible = false;
            SetupTimer();
            if (melody != null)
            melody.Stop();
        }
    }
    [Serializable]
    public struct Activity
    {
        public int length { get; set; }
        public string name { get; set; }
        public int index { get; set; }

        public Activity(string name, int length)
        {
            this.name = name;
            this.length = length;
            this.index = 0;
        }
    }
    internal static class ClockDrawer
    {
        const int clockDistToBorders = 8;

        public static void DrawClock(PictureBox pb, int maxTime, int curTime, Label activityLabel)
        {
            var image = pb.Image;
            var width = image.Width;
            var height = image.Height;

            var clockOutlinePen = new Pen(Color.Black, (float)Math.Sqrt(width * width + height * height) / 40f);
            int linePenSize = (int)Math.Sqrt(width * width + height * height) / 60;
            var linePen = new Pen(Color.Black, linePenSize);

            Graphics g = Graphics.FromImage(image);
            g.Clear(SystemColors.Control);
            // Prepare rectangles
            var clockRect = new Rectangle(width / clockDistToBorders, height / clockDistToBorders, width - width * 2 / clockDistToBorders, height - height * 2 / clockDistToBorders);
            var sectorRect = new Rectangle(clockRect.X + linePenSize, clockRect.Y + linePenSize, clockRect.Width - linePenSize * 2, clockRect.Height - linePenSize * 2);

            
            // Draw time line.
            var center = new Point(width/2, height/2);
            var radius = width * ((float)(clockDistToBorders - 2f) / (float)clockDistToBorders) / 2f;
            var timeAngle = ((float)curTime / (float)maxTime) * 360f - 90f;
            var timeRad = timeAngle * (float)(Math.PI / 180f);
            var point2 = new Point(
                (int)(Math.Cos(timeRad) * radius), (int)(Math.Sin(timeRad) * radius)
                );
            point2.Offset(center);

            //
            GraphicsPath path = new GraphicsPath();
            path.AddArc(sectorRect, timeAngle, 270-timeAngle);
            var p3 = center;
            p3.Offset(new Point(0, -(int)radius));
            path.AddLine(p3, center);
            path.FillMode = FillMode.Winding;


            Color curColor = GetCurrentColor(timeAngle);
            Brush sectorBrush = new SolidBrush(curColor);
            activityLabel.ForeColor = curColor;

            g.FillPath(sectorBrush, path);


            g.DrawEllipse(clockOutlinePen, clockRect);

            DrawLinesAtAngles(g, clockRect, center, radius, Math.Min(maxTime / 15, 30) , linePen);

            g.DrawLine(linePen, center, point2);
            
            g.DrawLine(linePen, center, p3);

            Pen tomatoHeadPen = new Pen(Color.Green, 4);
            g.DrawLine(tomatoHeadPen, p3, p3 + new Size(20, -15));
            g.DrawLine(tomatoHeadPen, p3, p3 + new Size(-16, -11));
            g.DrawLine(tomatoHeadPen, p3, p3 + new Size(-3, -24));
            g.DrawLine(tomatoHeadPen, p3, p3 + new Size(8, -18));

            pb.Image = image;
        }
        private static Color GetCurrentColor(float angle)
        {
            return ColorFromHSV(angle / 3 + 30f, 1, 1);
        }
        private static Color ColorFromHSV(double hue, double saturation, double value)
        {
            int hi = Convert.ToInt32(Math.Floor(hue / 60)) % 6;
            double f = hue / 60 - Math.Floor(hue / 60);

            value = value * 255;
            int v = Convert.ToInt32(value);
            int p = Convert.ToInt32(value * (1 - saturation));
            int q = Convert.ToInt32(value * (1 - f * saturation));
            int t = Convert.ToInt32(value * (1 - (1 - f) * saturation));

            if (hi == 0)
                return Color.FromArgb(255, v, t, p);
            else if (hi == 1)
                return Color.FromArgb(255, q, v, p);
            else if (hi == 2)
                return Color.FromArgb(255, p, v, t);
            else if (hi == 3)
                return Color.FromArgb(255, p, q, v);
            else if (hi == 4)
                return Color.FromArgb(255, t, p, v);
            else
                return Color.FromArgb(255, v, p, q);
        }
        const float adjLinesMult = 0.9f;
        private static void DrawLinesAtAngles(Graphics g, Rectangle circle, Point center, float radius, int count, Pen pen)
        {
            for (int a = -90; a < 270; a += (360/count))
            {
                var timeRad = a * Math.PI / 180;
                Point pt1 = new Point ((int)(Math.Cos(timeRad) * radius), (int)(Math.Sin(timeRad) * radius));
                pt1.Offset(center);
                Point pt2 = new Point((int)(Math.Cos(timeRad) * radius * adjLinesMult), (int)(Math.Sin(timeRad) * radius * adjLinesMult));
                pt2.Offset(center);
                g.DrawLine(pen, pt1, pt2);
            }
        }
    }
}
