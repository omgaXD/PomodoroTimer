using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.IO;
using System.Windows.Forms;
using System.Text.Json;
using System.Media;
using System.Text.Json.Serialization;

namespace PomodoroTechnique
{
    public partial class PomodoroSetup : Form
    {
        List<Activity> activities = new List<Activity>()
        {
            new Activity("Работа", 25),
            new Activity("Отдых", 5)
        };
        private readonly string DefSongPathname = "CrystalPomodoro.mp3";
        private readonly string DefSongName = "По умолчанию (vzizbek - Crystal Pomodoro)";
        public PomodoroSetup()
        {
            InitializeComponent();
            UpdateListBox(-1);
            SetDefaultSongUp();
        }
        private void SetDefaultSongUp()
        {
            if (melody == null)
            {

                string path = Directory.GetCurrentDirectory() + @"\" + DefSongPathname;
                melodyPathTextBox.Text = DefSongName;
                melody = new SoundManager(path);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StartTimer();
        }

        private void StartTimer()
        {
            SetDefaultSongUp();
            PomodoroTimer form = new PomodoroTimer(activities.ToList(), repeat, melody);
            Hide();
            form.Show(this);
        }
        
        private void UpdateListBox(int focusIndex)
        {
            timerPeriodsBox.Items.Clear();
            for (int i = 0; i < activities.Count; i++)
            {
                var a = activities[i];
                a.index = i + 1;
                activities[i] = a;
            }
            activities.ForEach(act => timerPeriodsBox.Items.Add(act.index.ToString() + ". " + act.name + " | " + act.length.ToString() + " мин."));
            timerPeriodsBox.SelectedIndex = Math.Min(focusIndex, timerPeriodsBox.Items.Count);

        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            var i = timerPeriodsBox.SelectedIndex;
            if (i == -1)
            {
                return;
            }
            var a = activities[i];
            a.name = nameTextBox.Text;
            activities[i] = a;
            UpdateListBox(i);
        }

        private void timeNumeric_ValueChanged(object sender, EventArgs e)
        {
            var i = timerPeriodsBox.SelectedIndex;
            if (i == -1)
            {
                return;
            }
            var a = activities[i];
            a.length = (int)timeNumeric.Value;
            activities[i] = a;
            UpdateListBox(i);
        }

        private void timerPeriodsBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var i = timerPeriodsBox.SelectedIndex;
            if (i == -1)
            {
                return;
            }
            timeNumeric.Value = activities[i].length;
            nameTextBox.Text = activities[i].name;
        }

        private void upButton_Click(object sender, EventArgs e)
        {
            var i = timerPeriodsBox.SelectedIndex;
            if (i == -1)
            {
                return;
            }
            if (i == 0)
            {
                return;
            }
            var item = activities[i];
            activities.RemoveAt(i);
            activities.Insert(i - 1, item);
            UpdateListBox(i - 1);
        }

        private void downButton_Click(object sender, EventArgs e)
        {
            var i = timerPeriodsBox.SelectedIndex;
            if (i == -1)
            {
                return;
            }
            if (i >= activities.Count - 1)
            {
                return;
            }
            var item = activities[i];
            activities.RemoveAt(i);
            activities.Insert(i + 1, item);
            UpdateListBox(i + 1);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            
            var i = timerPeriodsBox.SelectedIndex;
            if (i != -1)
            {
                activities.Insert(i + 1, new Activity("Новый Таймер", 1));
                UpdateListBox(i + 1);
            } else
            {
                activities.Add(new Activity("Новый Таймер", 1));
                UpdateListBox(activities.Count - 1);
            }
            
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            var i = timerPeriodsBox.SelectedIndex;
            if (i == -1)
            {
                return;
            }
            activities.RemoveAt(i);
            UpdateListBox(i-1);
        }
        private int repeat;


        private void CalcRepeat()
        {
            if (RBrunOnce.Checked)
            {
                repeat = 1;
            } else if (RBrepeatN.Checked)
            {
                repeat = (int)runTimerCount.Value;
            } else if (RBrepeatInfinitely.Checked)
            {
                repeat = -1;
            }
            if (!RBrepeatN.Checked)
            {
                runTimerCount.Enabled = false;
            } else
            {
                runTimerCount.Enabled = true;
            }
        }
        private void RBrunOnce_CheckedChanged(object sender, EventArgs e)
        {
            CalcRepeat();
        }

        private void RBrepeatN_CheckedChanged(object sender, EventArgs e)
        {
            CalcRepeat();
        }

        private void RBrepeatInfinitely_CheckedChanged(object sender, EventArgs e)
        {
            CalcRepeat();
        }

        private void importButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog(this);
        }

        private void exportButton_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog(this);
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            if (saveFileDialog1.FileName != "")
            {
                string savePath;
                if (melodyPath == Directory.GetCurrentDirectory() + @"\" + DefSongPathname)
                {
                    savePath = "";
                } else
                {
                    savePath = melodyPath;
                }
                var obj = new PomodoroTimerSettings(activities, melodyPath);
                string json = JsonSerializer.Serialize(obj);
                File.WriteAllText(saveFileDialog1.FileName, json);
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            var fs = File.Open(openFileDialog1.FileName, FileMode.Open);
           

            var load = JsonSerializer.Deserialize<PomodoroTimerSettings>(fs);
            activities = load.activities;
            if (load.melodyPath != null)
            {
                melodyPath = load.melodyPath;
                melodyPathTextBox.Text = melodyPath;
            } else
            {
                melody = null;
                SetDefaultSongUp();
            }
            try
            {
                melody = new SoundManager(melodyPath);
            } catch (Exception)
            {
                melody = null;
            }
            UpdateListBox(-1);
            fs.Close();
            fs.Dispose();
        }

        private void importMusicButton_Click(object sender, EventArgs e)
        {
            openMelodyDialog.ShowDialog(this);
        }
        string melodyPath;
        SoundManager melody;
        private void openMelodyDialog_FileOk(object sender, CancelEventArgs e)
        {
            melodyPathTextBox.Text = melodyPath = openMelodyDialog.FileName;
            melodyPathTextBox.Select(melodyPathTextBox.TextLength - 1, 0);
            melody = new SoundManager(melodyPath);
        }
        
        [Serializable]
        private class PomodoroTimerSettings
        {
            public List<Activity> activities { get; set; }
            public string melodyPath { get; set; }
            [JsonConstructor]
            public PomodoroTimerSettings(List<Activity> activities, string melodyPath)
            {
                this.activities = activities;
                this.melodyPath = melodyPath;
            }
        }
    }
}
