using System;
using System.Drawing;
using System.Windows.Forms;

namespace UsbConsentMonitor
{
    public partial class ConsentForm : Form
    {
        public bool IsConsentGiven { get; private set; } = false;

        public ConsentForm()
        {
            SetupUI();
        }

        private void SetupUI()
        {
            this.Text = "Cyber Security Audit - User Consent";
            this.Size = new Size(520, 420);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;

            RichTextBox rtbNotice = new RichTextBox
            {
                Location = new Point(15, 15),
                Size = new Size(475, 280),
                ReadOnly = true,
                Text = "=== USB ACTIVITY MONITORING CONSENT NOTICE ===\n\n" +
                       "PURPOSE:\n" +
                       "This application is an educational defensive cybersecurity laboratory tool " +
                       "designed to monitor USB storage device connection and disconnection events.\n\n" +
                       "WHAT WILL BE RECORDED:\n" +
                       "• Date and Time of USB insertion/removal\n" +
                       "• Device Connection/Disconnection state changes\n" +
                       "• Application Start and Stop events\n" +
                       "• Log file integrity checksums (SHA-256)\n\n" +
                       "WHAT WILL NOT BE COLLECTED:\n" +
                       "• Passwords, keystrokes, personal files, or browser history.\n\n" +
                       "By clicking 'I Agree', you explicitly authorize this app to log USB hardware events."
            };

            Button btnAgree = new Button
            {
                Text = "I Agree & Start Monitoring",
                Size = new Size(220, 45),
                Location = new Point(15, 310),
                DialogResult = DialogResult.OK
            };

            Button btnDecline = new Button
            {
                Text = "Decline & Exit",
                Size = new Size(220, 45),
                Location = new Point(270, 310),
                DialogResult = DialogResult.Cancel
            };

            btnAgree.Click += (s, e) =>
            {
                IsConsentGiven = true;
                this.DialogResult = DialogResult.OK;
                this.Close();
            };

            btnDecline.Click += (s, e) =>
            {
                IsConsentGiven = false;
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            };

            this.Controls.Add(rtbNotice);
            this.Controls.Add(btnAgree);
            this.Controls.Add(btnDecline);
        }

        // Event handlers for designer compatibility
        private void ConsentForm_Load(object sender, EventArgs e) { }
        private void button1_Click(object sender, EventArgs e) { }
    }
}