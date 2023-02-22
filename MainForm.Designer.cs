namespace RecogUI
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbRealtime = new System.Windows.Forms.TextBox();
            this.btnStopRecog = new System.Windows.Forms.Button();
            this.btnStartRecog = new System.Windows.Forms.Button();
            this.cbLyrics = new System.Windows.Forms.CheckBox();
            this.comboSmpR = new System.Windows.Forms.ComboBox();
            this.lbSampR = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbLoop = new System.Windows.Forms.RadioButton();
            this.rbMic = new System.Windows.Forms.RadioButton();
            this.labelAudioSrc = new System.Windows.Forms.Label();
            this.comboLang = new System.Windows.Forms.ComboBox();
            this.labelModel = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbStats = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbFinalText = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(662, 434);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.btnStopRecog);
            this.tabPage1.Controls.Add(this.btnStartRecog);
            this.tabPage1.Controls.Add(this.cbLyrics);
            this.tabPage1.Controls.Add(this.comboSmpR);
            this.tabPage1.Controls.Add(this.lbSampR);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.labelAudioSrc);
            this.tabPage1.Controls.Add(this.comboLang);
            this.tabPage1.Controls.Add(this.labelModel);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(654, 401);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Main";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbRealtime);
            this.groupBox1.Location = new System.Drawing.Point(27, 206);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(597, 169);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Real-time Recognized Text";
            // 
            // tbRealtime
            // 
            this.tbRealtime.Location = new System.Drawing.Point(16, 26);
            this.tbRealtime.Multiline = true;
            this.tbRealtime.Name = "tbRealtime";
            this.tbRealtime.ReadOnly = true;
            this.tbRealtime.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbRealtime.Size = new System.Drawing.Size(564, 130);
            this.tbRealtime.TabIndex = 0;
            // 
            // btnStopRecog
            // 
            this.btnStopRecog.Location = new System.Drawing.Point(425, 149);
            this.btnStopRecog.Name = "btnStopRecog";
            this.btnStopRecog.Size = new System.Drawing.Size(94, 29);
            this.btnStopRecog.TabIndex = 8;
            this.btnStopRecog.Text = "Stop";
            this.btnStopRecog.UseVisualStyleBackColor = true;
            this.btnStopRecog.Click += new System.EventHandler(this.btnStopRecog_Click);
            // 
            // btnStartRecog
            // 
            this.btnStartRecog.Location = new System.Drawing.Point(109, 149);
            this.btnStartRecog.Name = "btnStartRecog";
            this.btnStartRecog.Size = new System.Drawing.Size(94, 29);
            this.btnStartRecog.TabIndex = 7;
            this.btnStartRecog.Text = "Start";
            this.btnStartRecog.UseVisualStyleBackColor = true;
            this.btnStartRecog.Click += new System.EventHandler(this.btnStartRecog_Click);
            // 
            // cbLyrics
            // 
            this.cbLyrics.AutoSize = true;
            this.cbLyrics.Location = new System.Drawing.Point(378, 102);
            this.cbLyrics.Name = "cbLyrics";
            this.cbLyrics.Size = new System.Drawing.Size(190, 24);
            this.cbLyrics.TabIndex = 6;
            this.cbLyrics.Text = "Show hover subtitle box";
            this.cbLyrics.UseVisualStyleBackColor = true;
            // 
            // comboSmpR
            // 
            this.comboSmpR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSmpR.FormattingEnabled = true;
            this.comboSmpR.Items.AddRange(new object[] {
            "16000Hz",
            "24000Hz",
            "32000Hz",
            "44100Hz",
            "48000Hz"});
            this.comboSmpR.Location = new System.Drawing.Point(169, 99);
            this.comboSmpR.Name = "comboSmpR";
            this.comboSmpR.Size = new System.Drawing.Size(151, 28);
            this.comboSmpR.TabIndex = 5;
            // 
            // lbSampR
            // 
            this.lbSampR.AutoSize = true;
            this.lbSampR.Location = new System.Drawing.Point(18, 102);
            this.lbSampR.Name = "lbSampR";
            this.lbSampR.Size = new System.Drawing.Size(96, 20);
            this.lbSampR.TabIndex = 4;
            this.lbSampR.Text = "Sample Rate:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbLoop);
            this.panel1.Controls.Add(this.rbMic);
            this.panel1.Location = new System.Drawing.Point(157, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(295, 35);
            this.panel1.TabIndex = 3;
            // 
            // rbLoop
            // 
            this.rbLoop.AutoSize = true;
            this.rbLoop.Location = new System.Drawing.Point(143, 6);
            this.rbLoop.Name = "rbLoop";
            this.rbLoop.Size = new System.Drawing.Size(144, 24);
            this.rbLoop.TabIndex = 1;
            this.rbLoop.TabStop = true;
            this.rbLoop.Text = "Loopback Device";
            this.rbLoop.UseVisualStyleBackColor = true;
            // 
            // rbMic
            // 
            this.rbMic.AutoSize = true;
            this.rbMic.Location = new System.Drawing.Point(10, 6);
            this.rbMic.Name = "rbMic";
            this.rbMic.Size = new System.Drawing.Size(110, 24);
            this.rbMic.TabIndex = 0;
            this.rbMic.TabStop = true;
            this.rbMic.Text = "Microphone";
            this.rbMic.UseVisualStyleBackColor = true;
            // 
            // labelAudioSrc
            // 
            this.labelAudioSrc.AutoSize = true;
            this.labelAudioSrc.Location = new System.Drawing.Point(18, 63);
            this.labelAudioSrc.Name = "labelAudioSrc";
            this.labelAudioSrc.Size = new System.Drawing.Size(101, 20);
            this.labelAudioSrc.TabIndex = 2;
            this.labelAudioSrc.Text = "Audio Source:";
            // 
            // comboLang
            // 
            this.comboLang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboLang.FormattingEnabled = true;
            this.comboLang.Items.AddRange(new object[] {
            "English",
            "French",
            "Spanish",
            "Portuguese",
            "Italian",
            "German"});
            this.comboLang.Location = new System.Drawing.Point(169, 19);
            this.comboLang.Name = "comboLang";
            this.comboLang.Size = new System.Drawing.Size(182, 28);
            this.comboLang.TabIndex = 1;
            this.comboLang.SelectedIndexChanged += new System.EventHandler(this.comboLang_SelectedIndexChanged);
            // 
            // labelModel
            // 
            this.labelModel.AutoSize = true;
            this.labelModel.Location = new System.Drawing.Point(18, 22);
            this.labelModel.Name = "labelModel";
            this.labelModel.Size = new System.Drawing.Size(124, 20);
            this.labelModel.TabIndex = 0;
            this.labelModel.Text = "Language Model:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(654, 401);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Misc";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbStats);
            this.groupBox3.Location = new System.Drawing.Point(332, 21);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(298, 365);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Statistics";
            // 
            // tbStats
            // 
            this.tbStats.Location = new System.Drawing.Point(25, 35);
            this.tbStats.Multiline = true;
            this.tbStats.Name = "tbStats";
            this.tbStats.ReadOnly = true;
            this.tbStats.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbStats.Size = new System.Drawing.Size(256, 311);
            this.tbStats.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbFinalText);
            this.groupBox2.Location = new System.Drawing.Point(16, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(285, 365);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Final Text";
            // 
            // tbFinalText
            // 
            this.tbFinalText.Location = new System.Drawing.Point(21, 35);
            this.tbFinalText.Multiline = true;
            this.tbFinalText.Name = "tbFinalText";
            this.tbFinalText.ReadOnly = true;
            this.tbFinalText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbFinalText.Size = new System.Drawing.Size(243, 311);
            this.tbFinalText.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 458);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adolfo Voice Recognition Utility";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_Closing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label labelModel;
        private ComboBox comboLang;
        private Label labelAudioSrc;
        private Panel panel1;
        private RadioButton rbMic;
        private RadioButton rbLoop;
        private Label lbSampR;
        private ComboBox comboSmpR;
        private CheckBox cbLyrics;
        private Button btnStartRecog;
        private Button btnStopRecog;
        private GroupBox groupBox1;
        private TextBox tbRealtime;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private TextBox tbFinalText;
        private TextBox tbStats;
    }
}