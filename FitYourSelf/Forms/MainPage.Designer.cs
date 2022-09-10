using System.Drawing;

namespace FitYourSelf
{
    partial class MainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.btnGirisYap = new System.Windows.Forms.Button();
            this.btnUyeOl = new System.Windows.Forms.Button();
            this.lnklblHakkinda = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // btnGirisYap
            // 
            resources.ApplyResources(this.btnGirisYap, "btnGirisYap");
            this.btnGirisYap.BackColor = System.Drawing.Color.Transparent;
            this.btnGirisYap.Name = "btnGirisYap";
            this.btnGirisYap.UseVisualStyleBackColor = false;
            this.btnGirisYap.Click += new System.EventHandler(this.btnGirisYap_Click_1);
            // 
            // btnUyeOl
            // 
            resources.ApplyResources(this.btnUyeOl, "btnUyeOl");
            this.btnUyeOl.BackColor = System.Drawing.Color.Transparent;
            this.btnUyeOl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnUyeOl.Name = "btnUyeOl";
            this.btnUyeOl.UseVisualStyleBackColor = false;
            this.btnUyeOl.Click += new System.EventHandler(this.btnUyeOl_Click);
            // 
            // lnklblHakkinda
            // 
            resources.ApplyResources(this.lnklblHakkinda, "lnklblHakkinda");
            this.lnklblHakkinda.BackColor = System.Drawing.Color.Transparent;
            this.lnklblHakkinda.Name = "lnklblHakkinda";
            this.lnklblHakkinda.TabStop = true;
            this.lnklblHakkinda.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // MainPage
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FitYourSelf.Properties.Resources.GirişSayfasıRevize;
            this.Controls.Add(this.lnklblHakkinda);
            this.Controls.Add(this.btnUyeOl);
            this.Controls.Add(this.btnGirisYap);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainPage";
            this.Load += new System.EventHandler(this.MainPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGirisYap;
        private System.Windows.Forms.Button btnUyeOl;
        private System.Windows.Forms.LinkLabel lnklblHakkinda;
    }
}

