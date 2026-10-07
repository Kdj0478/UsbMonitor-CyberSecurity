using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using UsbConsentMonitor.Core;

namespace UsbConsentMonitor
{
    public partial class MainForm : Form
    {
        private USBMonitor _usbMonitor;
        private ActivityLogger _logger;
        private TextBox txtLogView;
        private TextBox txtHashView;

        public MainForm()
        {
            _logger = new ActivityLogger();
            _usbMonitor = new USBMonitor();

            _usbMonitor.USBConnected += OnUsbConnected;
            _usbMonitor.USBDisconnected += OnUsbDisconnected;

            SetupDashboardUI();
            _logger.LogEvent("Monitoring Engine initialized with explicit user consent.");
            RefreshReport();
        }

        private void SetupDashboardUI()
        {
            this.Text = "USB Activity Monitor - Active Audit Session";
            this.Size = new Size(600, 500);
            this.StartPosition = FormStartPosition.CenterScreen;

            Label lblStatus = new Label
            {
                Text = "STATUS: Active USB Monitoring Engine Running...",
                Location = new Point(15, 10),
                Size = new Size(550, 25),
                Font = new Font("Arial", 10, FontStyle.Bold),
                ForeColor = Color.Green
            };

            Label lblLogs = new Label
            {
                Text = "Recorded Activity Log:",
                Location = new Point(15, 45),
                Size = new Size(200, 20)
            };

            txtLogView = new TextBox
            {
                Location = new Point(15, 70),
                Size = new Size(550, 220),
                Multiline = true,
                ReadOnly = true,
                ScrollBars = ScrollBars.Vertical,
                Font = new Font("Consolas", 9)
            };

            Label lblHash = new Label
            {
                Text = "SHA-256 Log Integrity Hash (Checksum):",
                Location = new Point(15, 305),
                Size = new Size(300, 20),
                Font = new Font("Arial", 9, FontStyle.Bold)
            };

            txtHashView = new TextBox
            {
                Location = new Point(15, 330),
                Size = new Size(550, 25),
                ReadOnly = true,
                Font = new Font("Consolas", 8)
            };

            Button btnRefresh = new Button
            {
                Text = "Refresh Report & Hash",
                Location = new Point(15, 375),
                Size = new Size(260, 40)
            };
            btnRefresh.Click += (s, e) => RefreshReport();

            Button btnStop = new Button
            {
                Text = "Stop Monitoring & Exit",
                Location = new Point(305, 375),
                Size = new Size(260, 40)
            };
            btnStop.Click += (s, e) => {
                _logger.LogEvent("Monitoring session stopped by user.");
                _usbMonitor.Stop();
                Application.Exit();
            };

            this.Controls.Add(lblStatus);
            this.Controls.Add(lblLogs);
            this.Controls.Add(txtLogView);
            this.Controls.Add(lblHash);
            this.Controls.Add(txtHashView);
            this.Controls.Add(btnRefresh);
            this.Controls.Add(btnStop);
        }

        private void RefreshReport()
        {
            string path = _logger.GetLogFilePath();
            if (File.Exists(path))
            {
                txtLogView.Text = File.ReadAllText(path);
                txtHashView.Text = IntegrityManager.CalculateLogHash(path);
            }
        }

        private void OnUsbConnected()
        {
            _logger.LogEvent("USB Storage Device CONNECTED");
            RefreshReport();
            MessageBox.Show("USB Device Connected!", "Security Audit Event", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void OnUsbDisconnected()
        {
            _logger.LogEvent("USB Storage Device DISCONNECTED");
            RefreshReport();
            MessageBox.Show("USB Device Removed!", "Security Audit Event", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}