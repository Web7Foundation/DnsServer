namespace DnsServerSystemTrayApp
{
    partial class frmAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAbout));
            panel1 = new System.Windows.Forms.Panel();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            label2 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            lnkTerms = new System.Windows.Forms.LinkLabel();
            btnClose = new System.Windows.Forms.Button();
            label3 = new System.Windows.Forms.Label();
            lnkWebsite = new System.Windows.Forms.LinkLabel();
            label1 = new System.Windows.Forms.Label();
            lnkContactEmail = new System.Windows.Forms.LinkLabel();
            labVersion = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.FromArgb(102, 153, 255);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = System.Windows.Forms.DockStyle.Left;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(66, 401);
            panel1.TabIndex = 21;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = System.Drawing.Color.FromArgb(102, 153, 255);
            pictureBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new System.Drawing.Point(0, 339);
            pictureBox1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Padding = new System.Windows.Forms.Padding(6, 7, 6, 7);
            pictureBox1.Size = new System.Drawing.Size(66, 62);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label2.ForeColor = System.Drawing.Color.FromArgb(45, 57, 69);
            label2.Location = new System.Drawing.Point(101, 37);
            label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(527, 59);
            label2.TabIndex = 24;
            label2.Text = "Web 7.0 DID Registry";
            // 
            // label4
            // 
            label4.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            label4.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label4.ForeColor = System.Drawing.Color.FromArgb(45, 57, 69);
            label4.Location = new System.Drawing.Point(82, 297);
            label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(582, 68);
            label4.TabIndex = 33;
            label4.Text = resources.GetString("label4.Text");
            // 
            // lnkTerms
            // 
            lnkTerms.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            lnkTerms.AutoSize = true;
            lnkTerms.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lnkTerms.LinkColor = System.Drawing.Color.FromArgb(102, 153, 255);
            lnkTerms.Location = new System.Drawing.Point(82, 364);
            lnkTerms.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lnkTerms.Name = "lnkTerms";
            lnkTerms.Size = new System.Drawing.Size(136, 17);
            lnkTerms.TabIndex = 32;
            lnkTerms.TabStop = true;
            lnkTerms.Text = "Terms && Conditions";
            lnkTerms.VisitedLinkColor = System.Drawing.Color.White;
            lnkTerms.LinkClicked += lnkTerms_LinkClicked;
            // 
            // btnClose
            // 
            btnClose.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btnClose.Location = new System.Drawing.Point(753, 352);
            btnClose.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            btnClose.Name = "btnClose";
            btnClose.Size = new System.Drawing.Size(101, 36);
            btnClose.TabIndex = 31;
            btnClose.Text = "&Close";
            btnClose.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.ForeColor = System.Drawing.Color.FromArgb(45, 57, 69);
            label3.Location = new System.Drawing.Point(634, 221);
            label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(69, 19);
            label3.TabIndex = 37;
            label3.Text = "Website";
            // 
            // lnkWebsite
            // 
            lnkWebsite.AutoSize = true;
            lnkWebsite.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lnkWebsite.LinkColor = System.Drawing.Color.FromArgb(102, 153, 255);
            lnkWebsite.Location = new System.Drawing.Point(634, 247);
            lnkWebsite.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lnkWebsite.Name = "lnkWebsite";
            lnkWebsite.Size = new System.Drawing.Size(150, 19);
            lnkWebsite.TabIndex = 36;
            lnkWebsite.TabStop = true;
            lnkWebsite.Text = "technitium.com/dns";
            lnkWebsite.VisitedLinkColor = System.Drawing.Color.White;
            lnkWebsite.LinkClicked += lnkWebsite_LinkClicked;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.Color.FromArgb(45, 57, 69);
            label1.Location = new System.Drawing.Point(634, 152);
            label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(65, 19);
            label1.TabIndex = 35;
            label1.Text = "Contact";
            // 
            // lnkContactEmail
            // 
            lnkContactEmail.AutoSize = true;
            lnkContactEmail.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lnkContactEmail.LinkColor = System.Drawing.Color.FromArgb(102, 153, 255);
            lnkContactEmail.Location = new System.Drawing.Point(634, 177);
            lnkContactEmail.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lnkContactEmail.Name = "lnkContactEmail";
            lnkContactEmail.Size = new System.Drawing.Size(190, 19);
            lnkContactEmail.TabIndex = 34;
            lnkContactEmail.TabStop = true;
            lnkContactEmail.Text = "support@technitium.com";
            lnkContactEmail.VisitedLinkColor = System.Drawing.Color.White;
            lnkContactEmail.LinkClicked += lnkContactEmail_LinkClicked;
            // 
            // labVersion
            // 
            labVersion.AutoSize = true;
            labVersion.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labVersion.ForeColor = System.Drawing.Color.FromArgb(45, 57, 69);
            labVersion.Location = new System.Drawing.Point(114, 203);
            labVersion.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            labVersion.Name = "labVersion";
            labVersion.Size = new System.Drawing.Size(132, 23);
            labVersion.TabIndex = 38;
            labVersion.Text = "version x.x.x.x";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label5.ForeColor = System.Drawing.Color.FromArgb(45, 57, 69);
            label5.Location = new System.Drawing.Point(112, 159);
            label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(477, 29);
            label5.TabIndex = 39;
            label5.Text = "Web 7.0 DID Registry System Tray App";
            // 
            // frmAbout
            // 
            AcceptButton = btnClose;
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(250, 250, 250);
            CancelButton = btnClose;
            ClientSize = new System.Drawing.Size(870, 401);
            Controls.Add(label5);
            Controls.Add(labVersion);
            Controls.Add(label3);
            Controls.Add(lnkWebsite);
            Controls.Add(label1);
            Controls.Add(lnkContactEmail);
            Controls.Add(label4);
            Controls.Add(lnkTerms);
            Controls.Add(btnClose);
            Controls.Add(label2);
            Controls.Add(panel1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmAbout";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "About Web 7.0 DID Registry Server";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel lnkTerms;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel lnkWebsite;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel lnkContactEmail;
        private System.Windows.Forms.Label labVersion;
        private System.Windows.Forms.Label label5;
    }
}