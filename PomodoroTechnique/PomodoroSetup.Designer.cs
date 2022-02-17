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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PomodoroSetup));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelMelody = new System.Windows.Forms.Label();
            this.melodyPathTextBox = new System.Windows.Forms.TextBox();
            this.importMusicButton = new System.Windows.Forms.Button();
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileTab = new System.Windows.Forms.ToolStripMenuItem();
            this.importButton = new System.Windows.Forms.ToolStripMenuItem();
            this.exportButton = new System.Windows.Forms.ToolStripMenuItem();
            this.languageTab = new System.Windows.Forms.ToolStripMenuItem();
            this.rusLang = new System.Windows.Forms.ToolStripMenuItem();
            this.enLang = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.runTimerCount)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelMelody);
            this.groupBox2.Controls.Add(this.melodyPathTextBox);
            this.groupBox2.Controls.Add(this.importMusicButton);
            this.groupBox2.Controls.Add(this.timerPeriodsBox);
            this.groupBox2.Controls.Add(this.timeNumeric);
            this.groupBox2.Controls.Add(this.addButton);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.removeButton);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.nameTextBox);
            this.groupBox2.Controls.Add(this.upButton);
            this.groupBox2.Controls.Add(this.downButton);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // labelMelody
            // 
            resources.ApplyResources(this.labelMelody, "labelMelody");
            this.labelMelody.Name = "labelMelody";
            // 
            // melodyPathTextBox
            // 
            resources.ApplyResources(this.melodyPathTextBox, "melodyPathTextBox");
            this.melodyPathTextBox.Name = "melodyPathTextBox";
            this.melodyPathTextBox.ReadOnly = true;
            // 
            // importMusicButton
            // 
            resources.ApplyResources(this.importMusicButton, "importMusicButton");
            this.importMusicButton.Name = "importMusicButton";
            this.importMusicButton.UseVisualStyleBackColor = true;
            this.importMusicButton.Click += new System.EventHandler(this.importMusicButton_Click);
            // 
            // timerPeriodsBox
            // 
            this.timerPeriodsBox.FormattingEnabled = true;
            resources.ApplyResources(this.timerPeriodsBox, "timerPeriodsBox");
            this.timerPeriodsBox.Name = "timerPeriodsBox";
            this.timerPeriodsBox.SelectedIndexChanged += new System.EventHandler(this.timerPeriodsBox_SelectedIndexChanged);
            // 
            // timeNumeric
            // 
            resources.ApplyResources(this.timeNumeric, "timeNumeric");
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
            this.timeNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.timeNumeric.ValueChanged += new System.EventHandler(this.timeNumeric_ValueChanged);
            // 
            // addButton
            // 
            resources.ApplyResources(this.addButton, "addButton");
            this.addButton.Name = "addButton";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // removeButton
            // 
            resources.ApplyResources(this.removeButton, "removeButton");
            this.removeButton.Name = "removeButton";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // nameTextBox
            // 
            resources.ApplyResources(this.nameTextBox, "nameTextBox");
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged);
            // 
            // upButton
            // 
            resources.ApplyResources(this.upButton, "upButton");
            this.upButton.Name = "upButton";
            this.upButton.UseVisualStyleBackColor = true;
            this.upButton.Click += new System.EventHandler(this.upButton_Click);
            // 
            // downButton
            // 
            resources.ApplyResources(this.downButton, "downButton");
            this.downButton.Name = "downButton";
            this.downButton.UseVisualStyleBackColor = true;
            this.downButton.Click += new System.EventHandler(this.downButton_Click);
            // 
            // startButton
            // 
            resources.ApplyResources(this.startButton, "startButton");
            this.startButton.Name = "startButton";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // RBrunOnce
            // 
            resources.ApplyResources(this.RBrunOnce, "RBrunOnce");
            this.RBrunOnce.Checked = true;
            this.RBrunOnce.Name = "RBrunOnce";
            this.RBrunOnce.TabStop = true;
            this.RBrunOnce.UseVisualStyleBackColor = true;
            this.RBrunOnce.CheckedChanged += new System.EventHandler(this.RBrunOnce_CheckedChanged);
            // 
            // RBrepeatN
            // 
            resources.ApplyResources(this.RBrepeatN, "RBrepeatN");
            this.RBrepeatN.Name = "RBrepeatN";
            this.RBrepeatN.UseVisualStyleBackColor = true;
            this.RBrepeatN.CheckedChanged += new System.EventHandler(this.RBrepeatN_CheckedChanged);
            // 
            // RBrepeatInfinitely
            // 
            resources.ApplyResources(this.RBrepeatInfinitely, "RBrepeatInfinitely");
            this.RBrepeatInfinitely.Name = "RBrepeatInfinitely";
            this.RBrepeatInfinitely.UseVisualStyleBackColor = true;
            this.RBrepeatInfinitely.CheckedChanged += new System.EventHandler(this.RBrepeatInfinitely_CheckedChanged);
            // 
            // runTimerCount
            // 
            resources.ApplyResources(this.runTimerCount, "runTimerCount");
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
            resources.ApplyResources(this.saveFileDialog1, "saveFileDialog1");
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "pts";
            this.openFileDialog1.FileName = "PomodoroTimerSettings";
            resources.ApplyResources(this.openFileDialog1, "openFileDialog1");
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // openMelodyDialog
            // 
            this.openMelodyDialog.DefaultExt = "mp3";
            resources.ApplyResources(this.openMelodyDialog, "openMelodyDialog");
            this.openMelodyDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openMelodyDialog_FileOk);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Menu;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileTab,
            this.languageTab});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // fileTab
            // 
            this.fileTab.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importButton,
            this.exportButton});
            this.fileTab.Name = "fileTab";
            resources.ApplyResources(this.fileTab, "fileTab");
            // 
            // importButton
            // 
            this.importButton.Name = "importButton";
            resources.ApplyResources(this.importButton, "importButton");
            this.importButton.Click += new System.EventHandler(this.importButton_Click);
            // 
            // exportButton
            // 
            this.exportButton.Name = "exportButton";
            resources.ApplyResources(this.exportButton, "exportButton");
            this.exportButton.Click += new System.EventHandler(this.exportButton_Click);
            // 
            // languageTab
            // 
            this.languageTab.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rusLang,
            this.enLang});
            this.languageTab.Name = "languageTab";
            resources.ApplyResources(this.languageTab, "languageTab");
            // 
            // rusLang
            // 
            this.rusLang.Name = "rusLang";
            resources.ApplyResources(this.rusLang, "rusLang");
            this.rusLang.Click += new System.EventHandler(this.rusLang_Click);
            // 
            // enLang
            // 
            this.enLang.Name = "enLang";
            resources.ApplyResources(this.enLang, "enLang");
            this.enLang.Click += new System.EventHandler(this.enLang_Click);
            // 
            // PomodoroSetup
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.runTimerCount);
            this.Controls.Add(this.RBrepeatInfinitely);
            this.Controls.Add(this.RBrepeatN);
            this.Controls.Add(this.RBrunOnce);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.startButton);
            this.MaximizeBox = false;
            this.Name = "PomodoroSetup";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.runTimerCount)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button importMusicButton;
        private System.Windows.Forms.OpenFileDialog openMelodyDialog;
        private System.Windows.Forms.Label labelMelody;
        private System.Windows.Forms.TextBox melodyPathTextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileTab;
        private System.Windows.Forms.ToolStripMenuItem importButton;
        private System.Windows.Forms.ToolStripMenuItem exportButton;
        private System.Windows.Forms.ToolStripMenuItem languageTab;
        private System.Windows.Forms.ToolStripMenuItem rusLang;
        private System.Windows.Forms.ToolStripMenuItem enLang;
    }
}

