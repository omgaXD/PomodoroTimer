namespace PomodoroTechnique
{
    partial class PomodoroSetup
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.GroupBox groupBox2;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PomodoroSetup));
            this.labelMelody = new System.Windows.Forms.Label();
            this.melodyPathTextBox = new System.Windows.Forms.TextBox();
            this.importMusicButton = new System.Windows.Forms.Button();
            this.exportButton = new System.Windows.Forms.Button();
            this.importButton = new System.Windows.Forms.Button();
            this.timerPeriodsBox = new System.Windows.Forms.ListBox();
            this.timeNumeric = new System.Windows.Forms.NumericUpDown();
            this.addButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.removeButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.upButton = new System.Windows.Forms.Button();
            this.downButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.RBrunOnce = new System.Windows.Forms.RadioButton();
            this.RBrepeatN = new System.Windows.Forms.RadioButton();
            this.RBrepeatInfinitely = new System.Windows.Forms.RadioButton();
            this.runTimerCount = new System.Windows.Forms.NumericUpDown();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openMelodyDialog = new System.Windows.Forms.OpenFileDialog();
            groupBox2 = new System.Windows.Forms.GroupBox();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.runTimerCount)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(this.labelMelody);
            groupBox2.Controls.Add(this.melodyPathTextBox);
            groupBox2.Controls.Add(this.importMusicButton);
            groupBox2.Controls.Add(this.exportButton);
            groupBox2.Controls.Add(this.importButton);
            groupBox2.Controls.Add(this.timerPeriodsBox);
            groupBox2.Controls.Add(this.timeNumeric);
            groupBox2.Controls.Add(this.addButton);
            groupBox2.Controls.Add(this.label2);
            groupBox2.Controls.Add(this.removeButton);
            groupBox2.Controls.Add(this.label1);
            groupBox2.Controls.Add(this.nameTextBox);
            groupBox2.Controls.Add(this.upButton);
            groupBox2.Controls.Add(this.downButton);
            groupBox2.Location = new System.Drawing.Point(14, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(258, 314);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            groupBox2.Text = "Настройки таймера";
            // 
            // labelMelody
            // 
            this.labelMelody.AutoSize = true;
            this.labelMelody.Location = new System.Drawing.Point(6, 246);
            this.labelMelody.Name = "labelMelody";
            this.labelMelody.Size = new System.Drawing.Size(55, 13);
            this.labelMelody.TabIndex = 14;
            this.labelMelody.Text = "Мелодия:";
            // 
            // melodyPathTextBox
            // 
            this.melodyPathTextBox.Location = new System.Drawing.Point(62, 243);
            this.melodyPathTextBox.Name = "melodyPathTextBox";
            this.melodyPathTextBox.ReadOnly = true;
            this.melodyPathTextBox.Size = new System.Drawing.Size(125, 20);
            this.melodyPathTextBox.TabIndex = 13;
            // 
            // importMusicButton
            // 
            this.importMusicButton.Location = new System.Drawing.Point(186, 242);
            this.importMusicButton.Name = "importMusicButton";
            this.importMusicButton.Size = new System.Drawing.Size(66, 22);
            this.importMusicButton.TabIndex = 12;
            this.importMusicButton.Text = "Выбрать";
            this.importMusicButton.UseVisualStyleBackColor = true;
            this.importMusicButton.Click += new System.EventHandler(this.importMusicButton_Click);
            // 
            // exportButton
            // 
            this.exportButton.Location = new System.Drawing.Point(134, 283);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(118, 23);
            this.exportButton.TabIndex = 11;
            this.exportButton.Text = "Экспорт настроек";
            this.exportButton.UseVisualStyleBackColor = true;
            this.exportButton.Click += new System.EventHandler(this.exportButton_Click);
            // 
            // importButton
            // 
            this.importButton.Location = new System.Drawing.Point(6, 283);
            this.importButton.Name = "importButton";
            this.importButton.Size = new System.Drawing.Size(122, 23);
            this.importButton.TabIndex = 10;
            this.importButton.Text = "Импорт настроек";
            this.importButton.UseVisualStyleBackColor = true;
            this.importButton.Click += new System.EventHandler(this.importButton_Click);
            // 
            // timerPeriodsBox
            // 
            this.timerPeriodsBox.FormattingEnabled = true;
            this.timerPeriodsBox.Location = new System.Drawing.Point(15, 19);
            this.timerPeriodsBox.Name = "timerPeriodsBox";
            this.timerPeriodsBox.Size = new System.Drawing.Size(225, 108);
            this.timerPeriodsBox.TabIndex = 1;
            this.timerPeriodsBox.SelectedIndexChanged += new System.EventHandler(this.timerPeriodsBox_SelectedIndexChanged);
            // 
            // timeNumeric
            // 
            this.timeNumeric.Location = new System.Drawing.Point(89, 193);
            this.timeNumeric.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.timeNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.timeNumeric.Name = "timeNumeric";
            this.timeNumeric.Size = new System.Drawing.Size(41, 20);
            this.timeNumeric.TabIndex = 9;
            this.timeNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.timeNumeric.ValueChanged += new System.EventHandler(this.timeNumeric_ValueChanged);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(15, 133);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(68, 23);
            this.addButton.TabIndex = 3;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Время (мин.):";
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(89, 133);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(68, 23);
            this.removeButton.TabIndex = 2;
            this.removeButton.Text = "Удалить";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Название:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(89, 167);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(110, 20);
            this.nameTextBox.TabIndex = 6;
            this.nameTextBox.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged);
            // 
            // upButton
            // 
            this.upButton.Location = new System.Drawing.Point(163, 133);
            this.upButton.Name = "upButton";
            this.upButton.Size = new System.Drawing.Size(35, 23);
            this.upButton.TabIndex = 4;
            this.upButton.Text = "↑";
            this.upButton.UseVisualStyleBackColor = true;
            this.upButton.Click += new System.EventHandler(this.upButton_Click);
            // 
            // downButton
            // 
            this.downButton.Location = new System.Drawing.Point(204, 133);
            this.downButton.Name = "downButton";
            this.downButton.Size = new System.Drawing.Size(35, 23);
            this.downButton.TabIndex = 5;
            this.downButton.Text = "↓";
            this.downButton.UseVisualStyleBackColor = true;
            this.downButton.Click += new System.EventHandler(this.downButton_Click);
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(29, 405);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(225, 23);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Начать таймер";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // RBrunOnce
            // 
            this.RBrunOnce.AutoSize = true;
            this.RBrunOnce.Checked = true;
            this.RBrunOnce.Location = new System.Drawing.Point(29, 330);
            this.RBrunOnce.Name = "RBrunOnce";
            this.RBrunOnce.Size = new System.Drawing.Size(134, 17);
            this.RBrunOnce.TabIndex = 12;
            this.RBrunOnce.TabStop = true;
            this.RBrunOnce.Text = "Не повторять таймер";
            this.RBrunOnce.UseVisualStyleBackColor = true;
            this.RBrunOnce.CheckedChanged += new System.EventHandler(this.RBrunOnce_CheckedChanged);
            // 
            // RBrepeatN
            // 
            this.RBrepeatN.AutoSize = true;
            this.RBrepeatN.Location = new System.Drawing.Point(29, 354);
            this.RBrepeatN.Name = "RBrepeatN";
            this.RBrepeatN.Size = new System.Drawing.Size(157, 17);
            this.RBrepeatN.TabIndex = 13;
            this.RBrepeatN.Text = "Повторить                    раз";
            this.RBrepeatN.UseVisualStyleBackColor = true;
            this.RBrepeatN.CheckedChanged += new System.EventHandler(this.RBrepeatN_CheckedChanged);
            // 
            // RBrepeatInfinitely
            // 
            this.RBrepeatInfinitely.AutoSize = true;
            this.RBrepeatInfinitely.Location = new System.Drawing.Point(29, 377);
            this.RBrepeatInfinitely.Name = "RBrepeatInfinitely";
            this.RBrepeatInfinitely.Size = new System.Drawing.Size(181, 17);
            this.RBrepeatInfinitely.TabIndex = 14;
            this.RBrepeatInfinitely.Text = "Повторять таймер бесконечно";
            this.RBrepeatInfinitely.UseVisualStyleBackColor = true;
            this.RBrepeatInfinitely.CheckedChanged += new System.EventHandler(this.RBrepeatInfinitely_CheckedChanged);
            // 
            // runTimerCount
            // 
            this.runTimerCount.Enabled = false;
            this.runTimerCount.Location = new System.Drawing.Point(110, 354);
            this.runTimerCount.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.runTimerCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.runTimerCount.Name = "runTimerCount";
            this.runTimerCount.Size = new System.Drawing.Size(41, 20);
            this.runTimerCount.TabIndex = 10;
            this.runTimerCount.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "pts";
            this.saveFileDialog1.FileName = "PomodoroTimerSettings";
            this.saveFileDialog1.Filter = "Pomodoro Timer Settings files|*.pts";
            this.saveFileDialog1.Title = "Сохранить Настройки Таймера";
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "pts";
            this.openFileDialog1.FileName = "PomodoroTimerSettings";
            this.openFileDialog1.Filter = "Pomodoro Timer Settings files|*.pts";
            this.openFileDialog1.Title = "Открыть Настройки Таймера";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // openMelodyDialog
            // 
            this.openMelodyDialog.DefaultExt = "mp3";
            this.openMelodyDialog.Filter = "MP3 Файлы|*.mp3|WAVE Файлы|*.wav";
            this.openMelodyDialog.Title = "Выбрать мелодию";
            this.openMelodyDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openMelodyDialog_FileOk);
            // 
            // PomodoroSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 438);
            this.Controls.Add(this.runTimerCount);
            this.Controls.Add(this.RBrepeatInfinitely);
            this.Controls.Add(this.RBrepeatN);
            this.Controls.Add(this.RBrunOnce);
            this.Controls.Add(groupBox2);
            this.Controls.Add(this.startButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(300, 477);
            this.MinimumSize = new System.Drawing.Size(300, 477);
            this.Name = "PomodoroSetup";
            this.Text = "Pomodoro Timer";
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.runTimerCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.ListBox timerPeriodsBox;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button upButton;
        private System.Windows.Forms.Button downButton;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown timeNumeric;
        private System.Windows.Forms.RadioButton RBrunOnce;
        private System.Windows.Forms.RadioButton RBrepeatN;
        private System.Windows.Forms.RadioButton RBrepeatInfinitely;
        private System.Windows.Forms.NumericUpDown runTimerCount;
        private System.Windows.Forms.Button exportButton;
        private System.Windows.Forms.Button importButton;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button importMusicButton;
        private System.Windows.Forms.OpenFileDialog openMelodyDialog;
        private System.Windows.Forms.Label labelMelody;
        private System.Windows.Forms.TextBox melodyPathTextBox;
    }
}

