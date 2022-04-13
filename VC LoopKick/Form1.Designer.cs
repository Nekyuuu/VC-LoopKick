
namespace VC_LoopKick
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.topPanel = new System.Windows.Forms.Panel();
            this.programTitle = new System.Windows.Forms.Label();
            this.closeBtn = new System.Windows.Forms.Button();
            this.minimiseBtn = new System.Windows.Forms.Button();
            this.rgbPanel = new System.Windows.Forms.Panel();
            this.logTextbox = new System.Windows.Forms.RichTextBox();
            this.logLabel = new System.Windows.Forms.Label();
            this.configPanel = new System.Windows.Forms.Label();
            this.confPanel = new System.Windows.Forms.Panel();
            this.pauseButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.intervalLabel = new System.Windows.Forms.Label();
            this.intervalNumeric = new System.Windows.Forms.NumericUpDown();
            this.disconnectButton = new System.Windows.Forms.Button();
            this.victimidLabel = new System.Windows.Forms.Label();
            this.victimidTextbox = new System.Windows.Forms.TextBox();
            this.serveridLabel = new System.Windows.Forms.Label();
            this.serveridTextbox = new System.Windows.Forms.TextBox();
            this.tokenLabel = new System.Windows.Forms.Label();
            this.tokenTextbox = new System.Windows.Forms.TextBox();
            this.formconfigPanel = new System.Windows.Forms.Panel();
            this.clearLogsButton = new System.Windows.Forms.Button();
            this.creditLabel = new System.Windows.Forms.LinkLabel();
            this.rgbToggle = new System.Windows.Forms.CheckBox();
            this.formconfigLabel = new System.Windows.Forms.Label();
            this.rgbTimer = new System.Windows.Forms.Timer(this.components);
            this.disconnectTimer = new System.Windows.Forms.Timer(this.components);
            this.topPanel.SuspendLayout();
            this.confPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.intervalNumeric)).BeginInit();
            this.formconfigPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.topPanel.Controls.Add(this.programTitle);
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(800, 25);
            this.topPanel.TabIndex = 0;
            this.topPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.topPanel_MouseDown);
            this.topPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.topPanel_MouseMove);
            this.topPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.topPanel_MouseUp);
            // 
            // programTitle
            // 
            this.programTitle.AutoSize = true;
            this.programTitle.ForeColor = System.Drawing.Color.White;
            this.programTitle.Location = new System.Drawing.Point(342, 5);
            this.programTitle.Name = "programTitle";
            this.programTitle.Size = new System.Drawing.Size(115, 15);
            this.programTitle.TabIndex = 2;
            this.programTitle.Text = "VoiceChat Loop Kick";
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.closeBtn.FlatAppearance.BorderSize = 0;
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.ForeColor = System.Drawing.Color.White;
            this.closeBtn.Location = new System.Drawing.Point(775, 0);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(25, 25);
            this.closeBtn.TabIndex = 0;
            this.closeBtn.Text = "X";
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // minimiseBtn
            // 
            this.minimiseBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.minimiseBtn.FlatAppearance.BorderSize = 0;
            this.minimiseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimiseBtn.ForeColor = System.Drawing.Color.White;
            this.minimiseBtn.Location = new System.Drawing.Point(750, 0);
            this.minimiseBtn.Name = "minimiseBtn";
            this.minimiseBtn.Size = new System.Drawing.Size(25, 25);
            this.minimiseBtn.TabIndex = 1;
            this.minimiseBtn.Text = "-";
            this.minimiseBtn.UseVisualStyleBackColor = false;
            this.minimiseBtn.Click += new System.EventHandler(this.minimiseBtn_Click);
            // 
            // rgbPanel
            // 
            this.rgbPanel.BackColor = System.Drawing.Color.White;
            this.rgbPanel.Location = new System.Drawing.Point(0, 25);
            this.rgbPanel.Name = "rgbPanel";
            this.rgbPanel.Size = new System.Drawing.Size(800, 5);
            this.rgbPanel.TabIndex = 2;
            // 
            // logTextbox
            // 
            this.logTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.logTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.logTextbox.ForeColor = System.Drawing.Color.White;
            this.logTextbox.Location = new System.Drawing.Point(475, 60);
            this.logTextbox.Name = "logTextbox";
            this.logTextbox.Size = new System.Drawing.Size(313, 280);
            this.logTextbox.TabIndex = 3;
            this.logTextbox.Text = "";
            // 
            // logLabel
            // 
            this.logLabel.AutoSize = true;
            this.logLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.logLabel.ForeColor = System.Drawing.Color.White;
            this.logLabel.Location = new System.Drawing.Point(626, 42);
            this.logLabel.Name = "logLabel";
            this.logLabel.Size = new System.Drawing.Size(38, 15);
            this.logLabel.TabIndex = 4;
            this.logLabel.Text = "Logs :";
            // 
            // configPanel
            // 
            this.configPanel.AutoSize = true;
            this.configPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.configPanel.ForeColor = System.Drawing.Color.White;
            this.configPanel.Location = new System.Drawing.Point(209, 42);
            this.configPanel.Name = "configPanel";
            this.configPanel.Size = new System.Drawing.Size(49, 15);
            this.configPanel.TabIndex = 6;
            this.configPanel.Text = "Config :";
            // 
            // confPanel
            // 
            this.confPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.confPanel.Controls.Add(this.pauseButton);
            this.confPanel.Controls.Add(this.stopButton);
            this.confPanel.Controls.Add(this.intervalLabel);
            this.confPanel.Controls.Add(this.intervalNumeric);
            this.confPanel.Controls.Add(this.disconnectButton);
            this.confPanel.Controls.Add(this.victimidLabel);
            this.confPanel.Controls.Add(this.victimidTextbox);
            this.confPanel.Controls.Add(this.serveridLabel);
            this.confPanel.Controls.Add(this.serveridTextbox);
            this.confPanel.Controls.Add(this.tokenLabel);
            this.confPanel.Controls.Add(this.tokenTextbox);
            this.confPanel.Location = new System.Drawing.Point(12, 60);
            this.confPanel.Name = "confPanel";
            this.confPanel.Size = new System.Drawing.Size(445, 378);
            this.confPanel.TabIndex = 7;
            this.confPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.confPanel_Paint);
            // 
            // pauseButton
            // 
            this.pauseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.pauseButton.FlatAppearance.BorderSize = 0;
            this.pauseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pauseButton.ForeColor = System.Drawing.Color.White;
            this.pauseButton.Location = new System.Drawing.Point(354, 303);
            this.pauseButton.Name = "pauseButton";
            this.pauseButton.Size = new System.Drawing.Size(79, 25);
            this.pauseButton.TabIndex = 17;
            this.pauseButton.Text = "Pause.";
            this.pauseButton.UseVisualStyleBackColor = false;
            this.pauseButton.Click += new System.EventHandler(this.pauseButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.stopButton.FlatAppearance.BorderSize = 0;
            this.stopButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stopButton.ForeColor = System.Drawing.Color.White;
            this.stopButton.Location = new System.Drawing.Point(354, 334);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(79, 25);
            this.stopButton.TabIndex = 16;
            this.stopButton.Text = "Stop.";
            this.stopButton.UseVisualStyleBackColor = false;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // intervalLabel
            // 
            this.intervalLabel.AutoSize = true;
            this.intervalLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.intervalLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.intervalLabel.ForeColor = System.Drawing.Color.White;
            this.intervalLabel.Location = new System.Drawing.Point(20, 93);
            this.intervalLabel.Name = "intervalLabel";
            this.intervalLabel.Size = new System.Drawing.Size(79, 15);
            this.intervalLabel.TabIndex = 15;
            this.intervalLabel.Text = "Interval (ms) :";
            // 
            // intervalNumeric
            // 
            this.intervalNumeric.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.intervalNumeric.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.intervalNumeric.ForeColor = System.Drawing.Color.White;
            this.intervalNumeric.Location = new System.Drawing.Point(105, 91);
            this.intervalNumeric.Maximum = new decimal(new int[] {
            -1304428545,
            434162106,
            542,
            0});
            this.intervalNumeric.Name = "intervalNumeric";
            this.intervalNumeric.Size = new System.Drawing.Size(315, 19);
            this.intervalNumeric.TabIndex = 14;
            this.intervalNumeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // disconnectButton
            // 
            this.disconnectButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.disconnectButton.FlatAppearance.BorderSize = 0;
            this.disconnectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.disconnectButton.ForeColor = System.Drawing.Color.White;
            this.disconnectButton.Location = new System.Drawing.Point(20, 303);
            this.disconnectButton.Name = "disconnectButton";
            this.disconnectButton.Size = new System.Drawing.Size(320, 56);
            this.disconnectButton.TabIndex = 13;
            this.disconnectButton.Text = "Start !";
            this.disconnectButton.UseVisualStyleBackColor = false;
            this.disconnectButton.Click += new System.EventHandler(this.disconnectButton_Click);
            // 
            // victimidLabel
            // 
            this.victimidLabel.AutoSize = true;
            this.victimidLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.victimidLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.victimidLabel.ForeColor = System.Drawing.Color.White;
            this.victimidLabel.Location = new System.Drawing.Point(230, 66);
            this.victimidLabel.Name = "victimidLabel";
            this.victimidLabel.Size = new System.Drawing.Size(69, 15);
            this.victimidLabel.TabIndex = 12;
            this.victimidLabel.Text = "Victim\'s ID :";
            this.victimidLabel.Click += new System.EventHandler(this.serveridTextbox_Click);
            // 
            // victimidTextbox
            // 
            this.victimidTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.victimidTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.victimidTextbox.ForeColor = System.Drawing.Color.White;
            this.victimidTextbox.Location = new System.Drawing.Point(305, 65);
            this.victimidTextbox.Name = "victimidTextbox";
            this.victimidTextbox.Size = new System.Drawing.Size(115, 16);
            this.victimidTextbox.TabIndex = 11;
            this.victimidTextbox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // serveridLabel
            // 
            this.serveridLabel.AutoSize = true;
            this.serveridLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.serveridLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.serveridLabel.ForeColor = System.Drawing.Color.White;
            this.serveridLabel.Location = new System.Drawing.Point(20, 66);
            this.serveridLabel.Name = "serveridLabel";
            this.serveridLabel.Size = new System.Drawing.Size(59, 15);
            this.serveridLabel.TabIndex = 10;
            this.serveridLabel.Text = "Server ID :";
            // 
            // serveridTextbox
            // 
            this.serveridTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.serveridTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.serveridTextbox.ForeColor = System.Drawing.Color.White;
            this.serveridTextbox.Location = new System.Drawing.Point(105, 65);
            this.serveridTextbox.Name = "serveridTextbox";
            this.serveridTextbox.Size = new System.Drawing.Size(95, 16);
            this.serveridTextbox.TabIndex = 9;
            // 
            // tokenLabel
            // 
            this.tokenLabel.AutoSize = true;
            this.tokenLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.tokenLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tokenLabel.ForeColor = System.Drawing.Color.White;
            this.tokenLabel.Location = new System.Drawing.Point(20, 39);
            this.tokenLabel.Name = "tokenLabel";
            this.tokenLabel.Size = new System.Drawing.Size(44, 15);
            this.tokenLabel.TabIndex = 8;
            this.tokenLabel.Text = "Token :";
            // 
            // tokenTextbox
            // 
            this.tokenTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.tokenTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tokenTextbox.ForeColor = System.Drawing.Color.White;
            this.tokenTextbox.Location = new System.Drawing.Point(105, 38);
            this.tokenTextbox.Name = "tokenTextbox";
            this.tokenTextbox.Size = new System.Drawing.Size(315, 16);
            this.tokenTextbox.TabIndex = 0;
            // 
            // formconfigPanel
            // 
            this.formconfigPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.formconfigPanel.Controls.Add(this.clearLogsButton);
            this.formconfigPanel.Controls.Add(this.creditLabel);
            this.formconfigPanel.Controls.Add(this.rgbToggle);
            this.formconfigPanel.Location = new System.Drawing.Point(475, 369);
            this.formconfigPanel.Name = "formconfigPanel";
            this.formconfigPanel.Size = new System.Drawing.Size(313, 69);
            this.formconfigPanel.TabIndex = 8;
            // 
            // clearLogsButton
            // 
            this.clearLogsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.clearLogsButton.FlatAppearance.BorderSize = 0;
            this.clearLogsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearLogsButton.ForeColor = System.Drawing.Color.White;
            this.clearLogsButton.Location = new System.Drawing.Point(223, 37);
            this.clearLogsButton.Name = "clearLogsButton";
            this.clearLogsButton.Size = new System.Drawing.Size(83, 25);
            this.clearLogsButton.TabIndex = 17;
            this.clearLogsButton.Text = "Clear Logs";
            this.clearLogsButton.UseVisualStyleBackColor = false;
            this.clearLogsButton.Click += new System.EventHandler(this.clearLogsButton_Click);
            // 
            // creditLabel
            // 
            this.creditLabel.ActiveLinkColor = System.Drawing.Color.White;
            this.creditLabel.AutoSize = true;
            this.creditLabel.LinkColor = System.Drawing.Color.White;
            this.creditLabel.Location = new System.Drawing.Point(10, 43);
            this.creditLabel.Name = "creditLabel";
            this.creditLabel.Size = new System.Drawing.Size(198, 15);
            this.creditLabel.TabIndex = 11;
            this.creditLabel.TabStop = true;
            this.creditLabel.Text = "Made by Nekyuu | http://nekyuu.tk/";
            this.creditLabel.VisitedLinkColor = System.Drawing.Color.White;
            this.creditLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.creditLabel_LinkClicked);
            // 
            // rgbToggle
            // 
            this.rgbToggle.AutoSize = true;
            this.rgbToggle.Checked = true;
            this.rgbToggle.CheckState = System.Windows.Forms.CheckState.Checked;
            this.rgbToggle.ForeColor = System.Drawing.Color.White;
            this.rgbToggle.Location = new System.Drawing.Point(13, 17);
            this.rgbToggle.Name = "rgbToggle";
            this.rgbToggle.Size = new System.Drawing.Size(106, 19);
            this.rgbToggle.TabIndex = 0;
            this.rgbToggle.Text = "Toggle RGB Bar";
            this.rgbToggle.UseVisualStyleBackColor = true;
            // 
            // formconfigLabel
            // 
            this.formconfigLabel.AutoSize = true;
            this.formconfigLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.formconfigLabel.ForeColor = System.Drawing.Color.White;
            this.formconfigLabel.Location = new System.Drawing.Point(595, 351);
            this.formconfigLabel.Name = "formconfigLabel";
            this.formconfigLabel.Size = new System.Drawing.Size(74, 15);
            this.formconfigLabel.TabIndex = 9;
            this.formconfigLabel.Text = "App Config :";
            // 
            // rgbTimer
            // 
            this.rgbTimer.Enabled = true;
            this.rgbTimer.Interval = 15;
            this.rgbTimer.Tick += new System.EventHandler(this.rgbTimer_Tick);
            // 
            // disconnectTimer
            // 
            this.disconnectTimer.Tick += new System.EventHandler(this.disconnectTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.formconfigLabel);
            this.Controls.Add(this.formconfigPanel);
            this.Controls.Add(this.confPanel);
            this.Controls.Add(this.configPanel);
            this.Controls.Add(this.logLabel);
            this.Controls.Add(this.logTextbox);
            this.Controls.Add(this.rgbPanel);
            this.Controls.Add(this.minimiseBtn);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.topPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.confPanel.ResumeLayout(false);
            this.confPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.intervalNumeric)).EndInit();
            this.formconfigPanel.ResumeLayout(false);
            this.formconfigPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Button minimiseBtn;
        private System.Windows.Forms.Label programTitle;
        private System.Windows.Forms.Panel rgbPanel;
        private System.Windows.Forms.RichTextBox logTextbox;
        private System.Windows.Forms.Label logLabel;
        private System.Windows.Forms.Label configPanel;
        private System.Windows.Forms.Panel confPanel;
        private System.Windows.Forms.TextBox victimidTextbox;
        private System.Windows.Forms.Label serveridLabel;
        private System.Windows.Forms.TextBox serveridTextbox;
        private System.Windows.Forms.Label tokenLabel;
        private System.Windows.Forms.TextBox tokenTextbox;
        private System.Windows.Forms.Label intervalLabel;
        private System.Windows.Forms.NumericUpDown intervalNumeric;
        private System.Windows.Forms.Button disconnectButton;
        private System.Windows.Forms.Panel formconfigPanel;
        private System.Windows.Forms.Label formconfigLabel;
        private System.Windows.Forms.LinkLabel creditLabel;
        private System.Windows.Forms.CheckBox rgbToggle;
        private System.Windows.Forms.Timer rgbTimer;
        private System.Windows.Forms.Label victimidLabel;
        private System.Windows.Forms.Timer disconnectTimer;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button clearLogsButton;
        private System.Windows.Forms.Button pauseButton;
    }
}

