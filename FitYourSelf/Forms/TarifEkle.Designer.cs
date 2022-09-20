namespace FitYourSelf.Forms
{
    partial class TarifEkle
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
            this.txtTarifHazirlanis1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.txtTarifBasligi = new ReaLTaiizor.Controls.BigTextBox();
            this.txtTarifMalzemeler = new ReaLTaiizor.Controls.BigTextBox();
            this.txtTarifHazirlanis = new ReaLTaiizor.Controls.BigTextBox();
            this.SuspendLayout();
            // 
            // txtTarifHazirlanis1
            // 
            this.txtTarifHazirlanis1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtTarifHazirlanis1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTarifHazirlanis1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtTarifHazirlanis1.Location = new System.Drawing.Point(1205, 495);
            this.txtTarifHazirlanis1.Multiline = true;
            this.txtTarifHazirlanis1.Name = "txtTarifHazirlanis1";
            this.txtTarifHazirlanis1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtTarifHazirlanis1.Size = new System.Drawing.Size(0, 0);
            this.txtTarifHazirlanis1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(1097, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tarif Başlığı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(857, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(348, 22);
            this.label4.TabIndex = 4;
            this.label4.Text = "Bu Tarifte Hangi Malzemeler Bulunuyor?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(1045, 297);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tarifin Hazırlanışı ";
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnKaydet.Font = new System.Drawing.Font("Futura Bk BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnKaydet.Location = new System.Drawing.Point(1088, 585);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(117, 35);
            this.btnKaydet.TabIndex = 9;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // txtTarifBasligi
            // 
            this.txtTarifBasligi.BackColor = System.Drawing.Color.Transparent;
            this.txtTarifBasligi.Font = new System.Drawing.Font("Futura Bk BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTarifBasligi.ForeColor = System.Drawing.Color.Black;
            this.txtTarifBasligi.Image = null;
            this.txtTarifBasligi.Location = new System.Drawing.Point(627, 50);
            this.txtTarifBasligi.MaxLength = 32767;
            this.txtTarifBasligi.Multiline = true;
            this.txtTarifBasligi.Name = "txtTarifBasligi";
            this.txtTarifBasligi.ReadOnly = false;
            this.txtTarifBasligi.Size = new System.Drawing.Size(578, 46);
            this.txtTarifBasligi.TabIndex = 10;
            this.txtTarifBasligi.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTarifBasligi.UseSystemPasswordChar = false;
            // 
            // txtTarifMalzemeler
            // 
            this.txtTarifMalzemeler.BackColor = System.Drawing.Color.Transparent;
            this.txtTarifMalzemeler.Font = new System.Drawing.Font("Futura Bk BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTarifMalzemeler.ForeColor = System.Drawing.Color.Black;
            this.txtTarifMalzemeler.Image = null;
            this.txtTarifMalzemeler.Location = new System.Drawing.Point(627, 142);
            this.txtTarifMalzemeler.MaxLength = 32767;
            this.txtTarifMalzemeler.Multiline = true;
            this.txtTarifMalzemeler.Name = "txtTarifMalzemeler";
            this.txtTarifMalzemeler.ReadOnly = false;
            this.txtTarifMalzemeler.Size = new System.Drawing.Size(578, 137);
            this.txtTarifMalzemeler.TabIndex = 11;
            this.txtTarifMalzemeler.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTarifMalzemeler.UseSystemPasswordChar = false;
            // 
            // txtTarifHazirlanis
            // 
            this.txtTarifHazirlanis.BackColor = System.Drawing.Color.Transparent;
            this.txtTarifHazirlanis.Font = new System.Drawing.Font("Futura Bk BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTarifHazirlanis.ForeColor = System.Drawing.Color.Black;
            this.txtTarifHazirlanis.Image = null;
            this.txtTarifHazirlanis.Location = new System.Drawing.Point(627, 328);
            this.txtTarifHazirlanis.MaxLength = 32767;
            this.txtTarifHazirlanis.Multiline = true;
            this.txtTarifHazirlanis.Name = "txtTarifHazirlanis";
            this.txtTarifHazirlanis.ReadOnly = false;
            this.txtTarifHazirlanis.Size = new System.Drawing.Size(578, 229);
            this.txtTarifHazirlanis.TabIndex = 12;
            this.txtTarifHazirlanis.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTarifHazirlanis.UseSystemPasswordChar = false;
            // 
            // TarifEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FitYourSelf.Properties.Resources.TarifEkleArkaPlanSon;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1323, 638);
            this.Controls.Add(this.txtTarifHazirlanis);
            this.Controls.Add(this.txtTarifMalzemeler);
            this.Controls.Add(this.txtTarifBasligi);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTarifHazirlanis1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "TarifEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TarifEkle_FormClosed);
            this.Load += new System.EventHandler(this.TarifEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTarifHazirlanis1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnKaydet;
        private ReaLTaiizor.Controls.BigTextBox txtTarifBasligi;
        private ReaLTaiizor.Controls.BigTextBox txtTarifMalzemeler;
        private ReaLTaiizor.Controls.BigTextBox txtTarifHazirlanis;
    }
}