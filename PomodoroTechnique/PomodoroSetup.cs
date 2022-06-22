using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.IO;
using System.Windows.Forms;
using System.Text.Json;
using System.Media;
using System.Text.Json.Serialization;
using System.Globalization;
using System.Threading;
using System.Resources;
using System.Reflection;
using PomodoroTechnique.Resources;

namespace PomodoroTechnique
{
    public partial class PomodoroSetup : Form
    {

        string lang = "en_US";
        string defWorkString = "Работа";
        string newTimer = "Новый таймер";
        string defRestString = "Отдых";
        string minIndString = "мин.";
        string byDefault = "По умолчанию";
        bool changedActivity = false; // E
        private void ChangeLanguage(string lang)
        {
            this.lang = lang;
            ComponentResourceManager resources = new ComponentResourceManager(typeof(PomodoroSetup));
            ResourceManager textResources = Resource.ResourceManager;
            CultureInfo cultureInfo = new CultureInfo(lang);
            foreach (Control c in this.Controls)
            {
                resources.ApplyResources(c, c.Name, cultureInfo);
            }
            foreach (Control c in groupBox2.Controls)
            {  
                resources.ApplyResources(c, c.Name, cultureInfo);
            }
            
            defWorkString = textResources.GetString("defWorkString", cultureInfo);
            defRestString = textResources.GetString("defRestString", cultureInfo);
            minIndString = textResources.GetString("minIndString", cultureInfo);
            newTimer = textResources.GetString("newTimer", cultureInfo);
            byDefault = textResources.GetString("byDefault", cultureInfo);

            DefSongName = byDefault + " (vzizbek - Crystal Pomodoro)";
            if (melodyPath == null)
            {
                melodyPathTextBox.Text = DefSongName;
            }
            if (!changedActivity)
            {
                DefaultActivities();
            }
            UpdateListBox(timerPeriodsBox.SelectedIndex);

        }


        private void DefaultActivities()
        {
        
            activities = new List<Activity>()
            {
            new Activity(defWorkString, 25),
            new Activity(defRestString, 5)
            };
            UpdateListBox(-1);
        }

        List<Activity> activities = new List<Activity>();

        private readonly string DefSongPathname = "CrystalPomodoro.wav";
        private string DefSongName = "(vzizbek - Crystal Pomodoro)";
        public PomodoroSetup()
        {
            InitializeComponent();
            UpdateListBox(-1);
            //ChangeLanguage(lang);
            DefaultActivities();
            SetDefaultSongUp();
        }
        private void SetDefaultSongUp()
        {
            if (melody == null)
            {

                string path = Directory.GetCurrentDirectory() + @"\" + DefSongPathname;
                melodyPathTextBox.Text = DefSongName;
                TrySetSoundManager(path);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StartTimer();
        }

        private void StartTimer()
        {
            SetDefaultSongUp();
            PomodoroTimer form = new PomodoroTimer(activities.ToList(), repeat, melody, lang);
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
            activities.ForEach(act => timerPeriodsBox.Items.Add(act.index.ToString() + ". " + act.name + " | " + act.length.ToString() + " " + minIndString));
            timerPeriodsBox.SelectedIndex = Math.Min(focusIndex, timerPeriodsBox.Items.Count);
            if (timerPeriodsBox.SelectedIndex == -1)
            {
                timeNumeric.Enabled = false;
                timeNumeric.Value = 1;
                nameTextBox.Enabled = false;
                nameTextBox.Text = "";
            }
            else
            {
                timeNumeric.Enabled = true;
                nameTextBox.Enabled = true;
            }
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
            changedActivity = true;
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
            changedActivity = true;
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
            changedActivity = true;
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
            changedActivity = true;
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
            changedActivity = true;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            
            var i = timerPeriodsBox.SelectedIndex;
            if (i != -1)
            {
                activities.Insert(i + 1, new Activity(newTimer, 1));
                UpdateListBox(i + 1);
            } else
            {
                activities.Add(new Activity(newTimer, 1));
                UpdateListBox(activities.Count - 1);
            }
            changedActivity = true;
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
            changedActivity = true;
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
            TrySetSoundManager(melodyPath);
            UpdateListBox(-1);
            fs.Close();
            fs.Dispose();
        }
        private void TrySetSoundManager(string url)
        {
            try
            {
                melody = new SoundManagerWMP(url);
            }
            catch (PlatformNotSupportedException ex)
            {
                melody = new SoundManagerSP(url);
            }
            catch (Exception ex)
            {
                melody = null;
            }
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
            TrySetSoundManager(melodyPath);
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

        private void rusLang_Click(object sender, EventArgs e)
        {
            ChangeLanguage("ru");
        }

        private void enLang_Click(object sender, EventArgs e)
        {
            ChangeLanguage("en-US");
        }
    }
}
