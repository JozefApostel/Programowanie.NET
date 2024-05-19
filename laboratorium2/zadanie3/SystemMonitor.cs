using System;
using System.Diagnostics;
using System.IO;
using System.Timers;
using System.Xml.Serialization;

namespace SystemMonitoring
{
    public class SystemMonitor
    {
        private PerformanceCounter cpuCounter;
        private PerformanceCounter ramCounter;
        private Timer timer;
        private Configuration config;

        public SystemMonitor()
        {
            cpuCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");
            ramCounter = new PerformanceCounter("Memory", "Available MBytes");

            timer = new Timer();
            timer.Elapsed += OnTimedEvent;
        }

        public void StartMonitoring()
        {
            LoadConfiguration();

            timer.Interval = config.MonitorInterval;
            timer.Start();
        }

        private void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            float cpuUsage = cpuCounter.NextValue();
            float availableRAM = ramCounter.NextValue();

            if (cpuUsage > config.CpuThreshold)
            {
                LogEvent("CPU usage exceeded threshold: " + cpuUsage + "%", EventLogEntryType.Warning);
            }

            if (availableRAM < config.RamThreshold)
            {
                LogEvent("Available RAM below threshold: " + availableRAM + "MB", EventLogEntryType.Warning);
            }

            LogToFile(cpuUsage, availableRAM);
        }

        private void LogEvent(string message, EventLogEntryType type)
        {
            if (!EventLog.SourceExists("SystemMonitor"))
            {
                EventLog.CreateEventSource("SystemMonitor", "Application");
            }

            EventLog.WriteEntry("SystemMonitor", message, type);
        }

        private void LogToFile(float cpuUsage, float availableRAM)
        {
            using (StreamWriter writer = new StreamWriter(config.LogFilePath, true))
            {
                writer.WriteLine($"{DateTime.Now}: CPU Usage: {cpuUsage}% - Available RAM: {availableRAM}MB");
            }
        }

        private void LoadConfiguration()
        {
            string configFilePath = "config.xml";
            if (File.Exists(configFilePath))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Configuration));
                using (FileStream fs = new FileStream(configFilePath, FileMode.Open))
                {
                    config = (Configuration)serializer.Deserialize(fs);
                }
            }
            else
            {
                config = new Configuration();
                SaveConfiguration();
            }
        }

        private void SaveConfiguration()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Configuration));
            using (FileStream fs = new FileStream("config.xml", FileMode.Create))
            {
                serializer.Serialize(fs, config);
            }
        }

        public void UpdateConfiguration(Configuration newConfig)
        {
            config = newConfig;
            SaveConfiguration();
        }
    }

    [Serializable]
    public class Configuration
    {
        public float CpuThreshold { get; set; } = 75.0f;
        public float RamThreshold { get; set; } = 1000.0f;
        public double MonitorInterval { get; set; } = 5000.0; // in milliseconds
        public string LogFilePath { get; set; } = "system_monitor_log.txt";
    }
}
