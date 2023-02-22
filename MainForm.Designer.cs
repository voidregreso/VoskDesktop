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
            this.cbSub = new System.Windows.Forms.CheckBox();
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
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btn_applySubSettings = new System.Windows.Forms.Button();
            this.checkBoxPreserveSlash = new System.Windows.Forms.CheckBox();
            this.cbxGradientType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBorderColor = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnColor2 = new System.Windows.Forms.Button();
            this.btnColor1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFont = new System.Windows.Forms.Button();
            this.dlgFont = new System.Windows.Forms.FontDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
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
            this.tabPage1.Controls.Add(this.cbSub);
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
            // cbSub
            // 
            this.cbSub.AutoSize = true;
            this.cbSub.Location = new System.Drawing.Point(378, 102);
            this.cbSub.Name = "cbSub";
            this.cbSub.Size = new System.Drawing.Size(190, 24);
            this.cbSub.TabIndex = 6;
            this.cbSub.Text = "Show hover subtitle box";
            this.cbSub.UseVisualStyleBackColor = true;
            this.cbSub.CheckedChanged += new System.EventHandler(this.cbSub_CheckedChanged);
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
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btn_applySubSettings);
            this.tabPage3.Controls.Add(this.checkBoxPreserveSlash);
            this.tabPage3.Controls.Add(this.cbxGradientType);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.btnBorderColor);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.btnColor2);
            this.tabPage3.Controls.Add(this.btnColor1);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.btnFont);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(654, 401);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "DesktopSub Settings";
            // 
            // btn_applySubSettings
            // 
            this.btn_applySubSettings.Location = new System.Drawing.Point(282, 349);
            this.btn_applySubSettings.Name = "btn_applySubSettings";
            this.btn_applySubSettings.Size = new System.Drawing.Size(94, 29);
            this.btn_applySubSettings.TabIndex = 13;
            this.btn_applySubSettings.Text = "Apply";
            this.btn_applySubSettings.UseVisualStyleBackColor = true;
            this.btn_applySubSettings.Click += new System.EventHandler(this.btn_applySubSettings_Click);
            // 
            // checkBoxPreserveSlash
            // 
            this.checkBoxPreserveSlash.AutoSize = true;
            this.checkBoxPreserveSlash.Location = new System.Drawing.Point(271, 301);
            this.checkBoxPreserveSlash.Name = "checkBoxPreserveSlash";
            this.checkBoxPreserveSlash.Size = new System.Drawing.Size(119, 24);
            this.checkBoxPreserveSlash.TabIndex = 11;
            this.checkBoxPreserveSlash.Text = "Leave \'/\' as-is";
            this.checkBoxPreserveSlash.UseVisualStyleBackColor = true;
            this.checkBoxPreserveSlash.CheckedChanged += new System.EventHandler(this.checkBoxPreserveSlash_CheckedChanged);
            // 
            // cbxGradientType
            // 
            this.cbxGradientType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxGradientType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxGradientType.FormattingEnabled = true;
            this.cbxGradientType.Items.AddRange(new object[] {
            "No Gradient",
            "Double Color Gradient",
            "Triple Color Gradient"});
            this.cbxGradientType.Location = new System.Drawing.Point(261, 238);
            this.cbxGradientType.Margin = new System.Windows.Forms.Padding(4);
            this.cbxGradientType.Name = "cbxGradientType";
            this.cbxGradientType.Size = new System.Drawing.Size(243, 28);
            this.cbxGradientType.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(142, 242);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Gradient Type:";
            // 
            // btnBorderColor
            // 
            this.btnBorderColor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBorderColor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBorderColor.BackColor = System.Drawing.Color.Gray;
            this.btnBorderColor.Location = new System.Drawing.Point(260, 187);
            this.btnBorderColor.Margin = new System.Windows.Forms.Padding(4);
            this.btnBorderColor.Name = "btnBorderColor";
            this.btnBorderColor.Size = new System.Drawing.Size(244, 29);
            this.btnBorderColor.TabIndex = 8;
            this.btnBorderColor.UseVisualStyleBackColor = false;
            this.btnBorderColor.Click += new System.EventHandler(this.btnColors_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(141, 193);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Border color:";
            // 
            // btnColor2
            // 
            this.btnColor2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnColor2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnColor2.Location = new System.Drawing.Point(245, 139);
            this.btnColor2.Margin = new System.Windows.Forms.Padding(4);
            this.btnColor2.Name = "btnColor2";
            this.btnColor2.Size = new System.Drawing.Size(259, 29);
            this.btnColor2.TabIndex = 5;
            this.btnColor2.UseVisualStyleBackColor = false;
            this.btnColor2.Click += new System.EventHandler(this.btnColors_Click);
            // 
            // btnColor1
            // 
            this.btnColor1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnColor1.BackColor = System.Drawing.Color.LightCyan;
            this.btnColor1.Location = new System.Drawing.Point(245, 92);
            this.btnColor1.Margin = new System.Windows.Forms.Padding(4);
            this.btnColor1.Name = "btnColor1";
            this.btnColor1.Size = new System.Drawing.Size(259, 29);
            this.btnColor1.TabIndex = 4;
            this.btnColor1.UseVisualStyleBackColor = false;
            this.btnColor1.Click += new System.EventHandler(this.btnColors_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(141, 99);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Text color:";
            // 
            // btnFont
            // 
            this.btnFont.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFont.Location = new System.Drawing.Point(144, 34);
            this.btnFont.Margin = new System.Windows.Forms.Padding(4);
            this.btnFont.Name = "btnFont";
            this.btnFont.Size = new System.Drawing.Size(360, 29);
            this.btnFont.TabIndex = 1;
            this.btnFont.Text = "Font";
            this.btnFont.UseVisualStyleBackColor = true;
            this.btnFont.Click += new System.EventHandler(this.btnFont_Click);
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
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
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
        private CheckBox cbSub;
        private Button btnStartRecog;
        private Button btnStopRecog;
        private GroupBox groupBox1;
        private TextBox tbRealtime;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private TextBox tbFinalText;
        private TextBox tbStats;
        private TabPage tabPage3;
        private Button btnFont;
        private FontDialog dlgFont;
        private Button btnColor1;
        private Label label1;
        private Button btnColor2;
        private Button btnBorderColor;
        private Label label3;
        private ComboBox cbxGradientType;
        private Label label2;
        private CheckBox checkBoxPreserveSlash;
        private Button btn_applySubSettings;
    }
}