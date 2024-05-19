namespace SystemMonitoring
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.txtCpuThreshold = new System.Windows.Forms.TextBox();
            this.txtRamThreshold = new System.Windows.Forms.TextBox();
            this.txtInterval = new System.Windows.Forms.TextBox();
            this.txtLogFilePath = new System.Windows.Forms.TextBox();
            this.btnSaveConfig = new System.Windows.Forms.Button();
            this.lblCpuThreshold = new System.Windows.Forms.Label();
            this.lblRamThreshold = new System.Windows.Forms.Label();
            this.lblInterval = new System.Windows.Forms.Label();
            this.lblLogFilePath = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(12, 140);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(93, 140);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 1;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // txtCpuThreshold
            // 
            this.txtCpuThreshold.Location = new System.Drawing.Point(113, 12);
            this.txtCpuThreshold.Name = "txtCpuThreshold";
            this.txtCpuThreshold.Size = new System.Drawing.Size(100, 20);
            this.txtCpuThreshold.TabIndex = 2;
            // 
            // txtRamThreshold
            // 
            this.txtRamThreshold.Location = new System.Drawing.Point(113, 38);
            this.txtRamThreshold.Name = "txtRamThreshold";
            this.txtRamThreshold.Size = new System.Drawing.Size(100, 20);
            this.txtRamThreshold.TabIndex = 3;
            // 
            // txtInterval
            // 
            this.txtInterval.Location = new System.Drawing.Point(113, 64);
            this.txtInterval.Name = "txtInterval";
            this.txtInterval.Size = new System.Drawing.Size(100, 20);
            this.txtInterval.TabIndex = 4;
            // 
            // txtLogFilePath
            // 
            this.txtLogFilePath.Location = new System.Drawing.Point(113, 90);
            this.txtLogFilePath.Name = "txtLogFilePath";
            this.txtLogFilePath.Size = new System.Drawing.Size(100, 20);
            this.txtLogFilePath.TabIndex = 5;
            // 
            // btnSaveConfig
            // 
            this.btnSaveConfig.Location = new System.Drawing.Point(12, 169);
            this.btnSaveConfig.Name = "btnSaveConfig";
            this.btnSaveConfig.Size = new System.Drawing.Size(201, 23);
            this.btnSaveConfig.TabIndex = 6;
            this.btnSaveConfig.Text = "Save Configuration";
            this.btnSaveConfig.UseVisualStyleBackColor = true;
            this.btnSaveConfig.Click += new System.EventHandler(this.btnSaveConfig_Click);
            // 
            // lblCpuThreshold
            // 
            this.lblCpuThreshold.AutoSize = true;
            this.lblCpuThreshold.Location = new System.Drawing.Point(12, 15);
            this.lblCpuThreshold.Name = "lblCpuThreshold";
            this.lblCpuThreshold.Size = new System.Drawing.Size(95, 13);
            this.lblCpuThreshold.TabIndex = 7;
            this.lblCpuThreshold.Text = "CPU Threshold (%)";
            // 
            // lblRamThreshold
            // 
            this.lblRamThreshold.AutoSize = true;
            this.lblRamThreshold.Location = new System.Drawing.Point(12, 41);
            this.lblRamThreshold.Name = "lblRamThreshold";
            this.lblRamThreshold.Size = new System.Drawing.Size(81, 13);
            this.lblRamThreshold.TabIndex =
