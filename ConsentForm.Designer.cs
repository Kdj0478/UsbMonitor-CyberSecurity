namespace UsbConsentMonitor
{
    partial class ConsentForm
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
            label1 = new Label();
            richTextBox1 = new RichTextBox();
            btnAgree = new Button();
            btnDecline = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F);
            label1.Location = new Point(142, 53);
            label1.Name = "label1";
            label1.Size = new Size(470, 29);
            label1.TabIndex = 0;
            label1.Text = "USB Activity Monitor - User Consent Notice";
            //label1.Click += this.label1_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(272, 127);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(209, 175);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = "";
            // 
            // btnAgree
            // 
            btnAgree.Location = new Point(64, 338);
            btnAgree.Name = "btnAgree";
            btnAgree.Size = new Size(284, 34);
            btnAgree.TabIndex = 2;
            btnAgree.Text = "I Agree & Start Monitoring";
            btnAgree.UseVisualStyleBackColor = true;
            // 
            // btnDecline
            // 
            btnDecline.Location = new Point(390, 338);
            btnDecline.Name = "btnDecline";
            btnDecline.Size = new Size(284, 34);
            btnDecline.TabIndex = 3;
            btnDecline.Text = "Decline & Exit";
            btnDecline.UseVisualStyleBackColor = true;
            // 
            // ConsentForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDecline);
            Controls.Add(btnAgree);
            Controls.Add(richTextBox1);
            Controls.Add(label1);
            Name = "ConsentForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private RichTextBox richTextBox1;
        private Button btnAgree;
        private Button btnDecline;
    }
}
