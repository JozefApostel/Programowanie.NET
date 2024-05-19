using System;
using System.Windows.Forms;

namespace SystemMonitoring
{
    public partial class Form1 : Form
    {
        private SystemMonitor monitor;

        public Form1()
        {
            InitializeComponent();
            monitor = new SystemMonitor();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            monitor.StartMonitoring();
            btnStart.Enabled = false;
            btnStop.Enabled = true;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            monitor.StopMonitoring();
            btnStart.Enabled = true;
            btnStop.Enabled = false;
        }

        private void btnSaveConfig_Click(object sender, EventArgs e)
        {
            Configuration config = new Configuration
            {
                CpuThreshold = float.Parse(txtCpuThreshold.Text),
                RamThreshold = float.Parse(txtRamThreshold.Text),
                MonitorInterval = double.Parse(txtInterval.Text),
                LogFilePath = txtLogFilePath.Text
            };

            monitor.UpdateConfiguration(config);
            MessageBox.Show("Konfiguracja została zapisana.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
