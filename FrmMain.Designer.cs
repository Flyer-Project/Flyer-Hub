namespace FlyerHub
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.tab = new System.Windows.Forms.TabControl();
            this.tpConfig = new System.Windows.Forms.TabPage();
            this.tpTerminal = new System.Windows.Forms.TabPage();
            this.lblHttpPort = new System.Windows.Forms.Label();
            this.nudHttpPort = new System.Windows.Forms.NumericUpDown();
            this.btnRefreshSerialPort = new System.Windows.Forms.Button();
            this.lblSerialPort = new System.Windows.Forms.Label();
            this.cmbSerialPort = new System.Windows.Forms.ComboBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.grpData = new System.Windows.Forms.GroupBox();
            this.grpLog = new System.Windows.Forms.GroupBox();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtData = new System.Windows.Forms.TextBox();
            this.txtLogPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.tab.SuspendLayout();
            this.tpConfig.SuspendLayout();
            this.tpTerminal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudHttpPort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.grpData.SuspendLayout();
            this.grpLog.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab
            // 
            this.tab.Controls.Add(this.tpConfig);
            this.tab.Controls.Add(this.tpTerminal);
            this.tab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tab.Location = new System.Drawing.Point(0, 0);
            this.tab.Name = "tab";
            this.tab.SelectedIndex = 0;
            this.tab.Size = new System.Drawing.Size(624, 272);
            this.tab.TabIndex = 5;
            // 
            // tpConfig
            // 
            this.tpConfig.Controls.Add(this.btnStart);
            this.tpConfig.Controls.Add(this.label1);
            this.tpConfig.Controls.Add(this.txtLogPath);
            this.tpConfig.Controls.Add(this.lblHttpPort);
            this.tpConfig.Controls.Add(this.nudHttpPort);
            this.tpConfig.Controls.Add(this.btnRefreshSerialPort);
            this.tpConfig.Controls.Add(this.lblSerialPort);
            this.tpConfig.Controls.Add(this.cmbSerialPort);
            this.tpConfig.Location = new System.Drawing.Point(4, 22);
            this.tpConfig.Name = "tpConfig";
            this.tpConfig.Padding = new System.Windows.Forms.Padding(3);
            this.tpConfig.Size = new System.Drawing.Size(616, 246);
            this.tpConfig.TabIndex = 0;
            this.tpConfig.Text = "Config";
            this.tpConfig.UseVisualStyleBackColor = true;
            // 
            // tpTerminal
            // 
            this.tpTerminal.Controls.Add(this.splitContainer1);
            this.tpTerminal.Location = new System.Drawing.Point(4, 22);
            this.tpTerminal.Name = "tpTerminal";
            this.tpTerminal.Padding = new System.Windows.Forms.Padding(3);
            this.tpTerminal.Size = new System.Drawing.Size(570, 216);
            this.tpTerminal.TabIndex = 1;
            this.tpTerminal.Text = "Terminal";
            this.tpTerminal.UseVisualStyleBackColor = true;
            // 
            // lblHttpPort
            // 
            this.lblHttpPort.AutoSize = true;
            this.lblHttpPort.Location = new System.Drawing.Point(33, 52);
            this.lblHttpPort.Name = "lblHttpPort";
            this.lblHttpPort.Size = new System.Drawing.Size(65, 12);
            this.lblHttpPort.TabIndex = 9;
            this.lblHttpPort.Text = "HTTP Port:";
            // 
            // nudHttpPort
            // 
            this.nudHttpPort.Location = new System.Drawing.Point(104, 50);
            this.nudHttpPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.nudHttpPort.Name = "nudHttpPort";
            this.nudHttpPort.Size = new System.Drawing.Size(109, 21);
            this.nudHttpPort.TabIndex = 8;
            this.nudHttpPort.Value = new decimal(new int[] {
            10005,
            0,
            0,
            0});
            // 
            // btnRefreshSerialPort
            // 
            this.btnRefreshSerialPort.Location = new System.Drawing.Point(219, 23);
            this.btnRefreshSerialPort.Name = "btnRefreshSerialPort";
            this.btnRefreshSerialPort.Size = new System.Drawing.Size(75, 20);
            this.btnRefreshSerialPort.TabIndex = 7;
            this.btnRefreshSerialPort.Text = "&Refresh";
            this.btnRefreshSerialPort.UseVisualStyleBackColor = true;
            this.btnRefreshSerialPort.Click += new System.EventHandler(this.btnRefreshSerialPort_Click);
            // 
            // lblSerialPort
            // 
            this.lblSerialPort.AutoSize = true;
            this.lblSerialPort.Location = new System.Drawing.Point(21, 26);
            this.lblSerialPort.Name = "lblSerialPort";
            this.lblSerialPort.Size = new System.Drawing.Size(77, 12);
            this.lblSerialPort.TabIndex = 6;
            this.lblSerialPort.Text = "Serial Port:";
            // 
            // cmbSerialPort
            // 
            this.cmbSerialPort.FormattingEnabled = true;
            this.cmbSerialPort.Location = new System.Drawing.Point(104, 23);
            this.cmbSerialPort.Name = "cmbSerialPort";
            this.cmbSerialPort.Size = new System.Drawing.Size(109, 20);
            this.cmbSerialPort.TabIndex = 5;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.grpData);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.grpLog);
            this.splitContainer1.Size = new System.Drawing.Size(564, 210);
            this.splitContainer1.SplitterDistance = 354;
            this.splitContainer1.TabIndex = 0;
            // 
            // grpData
            // 
            this.grpData.Controls.Add(this.txtData);
            this.grpData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpData.Location = new System.Drawing.Point(0, 0);
            this.grpData.Name = "grpData";
            this.grpData.Size = new System.Drawing.Size(354, 210);
            this.grpData.TabIndex = 0;
            this.grpData.TabStop = false;
            this.grpData.Text = "Data";
            // 
            // grpLog
            // 
            this.grpLog.Controls.Add(this.txtLog);
            this.grpLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpLog.Location = new System.Drawing.Point(0, 0);
            this.grpLog.Name = "grpLog";
            this.grpLog.Size = new System.Drawing.Size(206, 210);
            this.grpLog.TabIndex = 0;
            this.grpLog.TabStop = false;
            this.grpLog.Text = "Log";
            this.grpLog.Enter += new System.EventHandler(this.grpLog_Enter);
            // 
            // txtLog
            // 
            this.txtLog.BackColor = System.Drawing.Color.White;
            this.txtLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLog.Location = new System.Drawing.Point(3, 17);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLog.Size = new System.Drawing.Size(200, 190);
            this.txtLog.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtData
            // 
            this.txtData.BackColor = System.Drawing.Color.White;
            this.txtData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtData.Location = new System.Drawing.Point(3, 17);
            this.txtData.Multiline = true;
            this.txtData.Name = "txtData";
            this.txtData.ReadOnly = true;
            this.txtData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtData.Size = new System.Drawing.Size(348, 190);
            this.txtData.TabIndex = 1;
            // 
            // txtLogPath
            // 
            this.txtLogPath.Location = new System.Drawing.Point(104, 77);
            this.txtLogPath.Name = "txtLogPath";
            this.txtLogPath.Size = new System.Drawing.Size(109, 21);
            this.txtLogPath.TabIndex = 10;
            this.txtLogPath.Text = "FlyerHub.log";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 11;
            this.label1.Text = "Log Path:";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(23, 104);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(190, 42);
            this.btnStart.TabIndex = 12;
            this.btnStart.Text = "&Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 272);
            this.Controls.Add(this.tab);
            this.Name = "frmMain";
            this.Text = "FlyerHub";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.tab.ResumeLayout(false);
            this.tpConfig.ResumeLayout(false);
            this.tpConfig.PerformLayout();
            this.tpTerminal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudHttpPort)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.grpData.ResumeLayout(false);
            this.grpData.PerformLayout();
            this.grpLog.ResumeLayout(false);
            this.grpLog.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.TabControl tab;
        private System.Windows.Forms.TabPage tpConfig;
        private System.Windows.Forms.Label lblHttpPort;
        private System.Windows.Forms.NumericUpDown nudHttpPort;
        private System.Windows.Forms.Button btnRefreshSerialPort;
        private System.Windows.Forms.Label lblSerialPort;
        private System.Windows.Forms.ComboBox cmbSerialPort;
        private System.Windows.Forms.TabPage tpTerminal;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox grpData;
        private System.Windows.Forms.GroupBox grpLog;
        private System.Windows.Forms.TextBox txtLogPath;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label1;
    }
}

