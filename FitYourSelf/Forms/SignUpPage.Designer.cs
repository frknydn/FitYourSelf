namespace FitYourSelf.Forms
{
    partial class SignUpPage
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnUyeOl = new System.Windows.Forms.Button();
            this.txtKayıtAd = new System.Windows.Forms.TextBox();
            this.txtKayıtSoyad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKayıtEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpKayıtDogumTarihi = new System.Windows.Forms.DateTimePicker();
            this.nmrKayitKilo = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.btnGeriDon = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nmrKayitKilo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(23, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad :";
            // 
            // btnUyeOl
            // 
            this.btnUyeOl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUyeOl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUyeOl.Location = new System.Drawing.Point(169, 439);
            this.btnUyeOl.Name = "btnUyeOl";
            this.btnUyeOl.Size = new System.Drawing.Size(75, 23);
            this.btnUyeOl.TabIndex = 1;
            this.btnUyeOl.Text = "Üye Ol";
            this.btnUyeOl.UseVisualStyleBackColor = true;
            this.btnUyeOl.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtKayıtAd
            // 
            this.txtKayıtAd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKayıtAd.Location = new System.Drawing.Point(148, 117);
            this.txtKayıtAd.Name = "txtKayıtAd";
            this.txtKayıtAd.Size = new System.Drawing.Size(183, 20);
            this.txtKayıtAd.TabIndex = 2;
            // 
            // txtKayıtSoyad
            // 
            this.txtKayıtSoyad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKayıtSoyad.Location = new System.Drawing.Point(148, 170);
            this.txtKayıtSoyad.Name = "txtKayıtSoyad";
            this.txtKayıtSoyad.Size = new System.Drawing.Size(183, 20);
            this.txtKayıtSoyad.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(23, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Soyad :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(23, 275);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Doğum Tarihi : ";
            // 
            // txtKayıtEmail
            // 
            this.txtKayıtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKayıtEmail.Location = new System.Drawing.Point(148, 223);
            this.txtKayıtEmail.Name = "txtKayıtEmail";
            this.txtKayıtEmail.Size = new System.Drawing.Size(183, 20);
            this.txtKayıtEmail.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(23, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "E-Mail :";
            // 
            // dtpKayıtDogumTarihi
            // 
            this.dtpKayıtDogumTarihi.Location = new System.Drawing.Point(148, 273);
            this.dtpKayıtDogumTarihi.Name = "dtpKayıtDogumTarihi";
            this.dtpKayıtDogumTarihi.Size = new System.Drawing.Size(183, 20);
            this.dtpKayıtDogumTarihi.TabIndex = 8;
            // 
            // nmrKayitKilo
            // 
            this.nmrKayitKilo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nmrKayitKilo.Location = new System.Drawing.Point(148, 332);
            this.nmrKayitKilo.Name = "nmrKayitKilo";
            this.nmrKayitKilo.Size = new System.Drawing.Size(183, 20);
            this.nmrKayitKilo.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(23, 335);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "Kilo :";
            // 
            // btnGeriDon
            // 
            this.btnGeriDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGeriDon.Location = new System.Drawing.Point(12, 12);
            this.btnGeriDon.Name = "btnGeriDon";
            this.btnGeriDon.Size = new System.Drawing.Size(75, 23);
            this.btnGeriDon.TabIndex = 12;
            this.btnGeriDon.Text = "Geri Dön";
            this.btnGeriDon.UseVisualStyleBackColor = true;
            this.btnGeriDon.Click += new System.EventHandler(this.btnGeriDon_Click);
            // 
            // SignUpPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 681);
            this.Controls.Add(this.btnGeriDon);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nmrKayitKilo);
            this.Controls.Add(this.dtpKayıtDogumTarihi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtKayıtEmail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtKayıtSoyad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtKayıtAd);
            this.Controls.Add(this.btnUyeOl);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "SignUpPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignUpPage";
            ((System.ComponentModel.ISupportInitialize)(this.nmrKayitKilo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUyeOl;
        private System.Windows.Forms.TextBox txtKayıtAd;
        private System.Windows.Forms.TextBox txtKayıtSoyad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtKayıtEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpKayıtDogumTarihi;
        private System.Windows.Forms.NumericUpDown nmrKayitKilo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnGeriDon;
    }
}