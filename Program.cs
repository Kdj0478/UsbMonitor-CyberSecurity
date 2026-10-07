using System;
using System.Windows.Forms;

namespace UsbConsentMonitor
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Step 1: Open Consent Screen
            using (ConsentForm consentScreen = new ConsentForm())
            {
                DialogResult result = consentScreen.ShowDialog();

                // Step 2: If User clicks 'I Agree', launch the main USB monitoring engine!
                if (result == DialogResult.OK && consentScreen.IsConsentGiven)
                {
                    Application.Run(new MainForm());
                }
                else
                {
                    Application.Exit();
                }
            }
        }
    }
}