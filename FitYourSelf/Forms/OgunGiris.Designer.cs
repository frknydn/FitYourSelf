namespace FitYourSelf.Forms
{
    partial class OgunGiris
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
            this.dgwYiyecekler = new System.Windows.Forms.DataGridView();
            this.cmbOgun = new System.Windows.Forms.ComboBox();
            this.btnListele = new System.Windows.Forms.Button();
            this.dgwOgunler = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbKategori = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbPorsiyon = new System.Windows.Forms.ComboBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnOgunSil = new System.Windows.Forms.Button();
            this.btnOgunListele = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwYiyecekler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwOgunler)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwYiyecekler
            // 
            this.dgwYiyecekler.BackgroundColor = System.Drawing.Color.White;
            this.dgwYiyecekler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwYiyecekler.Location = new System.Drawing.Point(12, 49);
            this.dgwYiyecekler.Name = "dgwYiyecekler";
            this.dgwYiyecekler.RowHeadersWidth = 51;
            this.dgwYiyecekler.Size = new System.Drawing.Size(1299, 223);
            this.dgwYiyecekler.TabIndex = 3;
            this.dgwYiyecekler.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgwYiyecekler_CellMouseClick);
            // 
            // cmbOgun
            // 
            this.cmbOgun.FormattingEnabled = true;
            this.cmbOgun.Location = new System.Drawing.Point(102, 308);
            this.cmbOgun.Name = "cmbOgun";
            this.cmbOgun.Size = new System.Drawing.Size(226, 21);
            this.cmbOgun.TabIndex = 4;
            // 
            // btnListele
            // 
            this.btnListele.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnListele.Font = new System.Drawing.Font("Futura Bk BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnListele.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnListele.Location = new System.Drawing.Point(374, 12);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(117, 28);
            this.btnListele.TabIndex = 8;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = false;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // dgwOgunler
            // 
            this.dgwOgunler.BackgroundColor = System.Drawing.Color.White;
            this.dgwOgunler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwOgunler.Location = new System.Drawing.Point(12, 381);
            this.dgwOgunler.Name = "dgwOgunler";
            this.dgwOgunler.RowHeadersWidth = 51;
            this.dgwOgunler.Size = new System.Drawing.Size(1301, 184);
            this.dgwOgunler.TabIndex = 10;
            this.dgwOgunler.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView2_CellMouseClick);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Futura Bk BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(9, 310);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 19);
            this.label1.TabIndex = 17;
            this.label1.Text = "Öğün :";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Futura Bk BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(9, 16);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 19);
            this.label2.TabIndex = 17;
            this.label2.Text = "Kategori :";
            // 
            // cmbKategori
            // 
            this.cmbKategori.FormattingEnabled = true;
            this.cmbKategori.Location = new System.Drawing.Point(112, 19);
            this.cmbKategori.Name = "cmbKategori";
            this.cmbKategori.Size = new System.Drawing.Size(226, 21);
            this.cmbKategori.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Futura Bk BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(9, 341);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 19);
            this.label3.TabIndex = 17;
            this.label3.Text = "Porsiyon :";
            // 
            // cmbPorsiyon
            // 
            this.cmbPorsiyon.FormattingEnabled = true;
            this.cmbPorsiyon.Location = new System.Drawing.Point(102, 344);
            this.cmbPorsiyon.Name = "cmbPorsiyon";
            this.cmbPorsiyon.Size = new System.Drawing.Size(75, 21);
            this.cmbPorsiyon.TabIndex = 4;
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnEkle.Font = new System.Drawing.Font("Futura Bk BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEkle.Location = new System.Drawing.Point(194, 337);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(117, 28);
            this.btnEkle.TabIndex = 8;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnGuncelle.Font = new System.Drawing.Font("Futura Bk BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGuncelle.Location = new System.Drawing.Point(638, 336);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(117, 28);
            this.btnGuncelle.TabIndex = 8;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnSil.Font = new System.Drawing.Font("Futura Bk BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSil.Location = new System.Drawing.Point(786, 336);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(117, 28);
            this.btnSil.TabIndex = 8;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnOgunSil
            // 
            this.btnOgunSil.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnOgunSil.Font = new System.Drawing.Font("Futura Bk BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOgunSil.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnOgunSil.Location = new System.Drawing.Point(918, 338);
            this.btnOgunSil.Name = "btnOgunSil";
            this.btnOgunSil.Size = new System.Drawing.Size(117, 28);
            this.btnOgunSil.TabIndex = 18;
            this.btnOgunSil.Text = "Öğün Sil";
            this.btnOgunSil.UseVisualStyleBackColor = false;
            // 
            // btnOgunListele
            // 
            this.btnOgunListele.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnOgunListele.Font = new System.Drawing.Font("Futura Bk BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOgunListele.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnOgunListele.Location = new System.Drawing.Point(694, 278);
            this.btnOgunListele.Name = "btnOgunListele";
            this.btnOgunListele.Size = new System.Drawing.Size(117, 28);
            this.btnOgunListele.TabIndex = 19;
            this.btnOgunListele.Text = "Listele";
            this.btnOgunListele.UseVisualStyleBackColor = false;
            this.btnOgunListele.Click += new System.EventHandler(this.btnOgunListele_Click);
            // 
            // OgunGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1323, 638);
            this.Controls.Add(this.btnOgunListele);
            this.Controls.Add(this.btnOgunSil);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgwOgunler);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.cmbPorsiyon);
            this.Controls.Add(this.cmbKategori);
            this.Controls.Add(this.cmbOgun);
            this.Controls.Add(this.dgwYiyecekler);
            this.Name = "OgunGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OgunGiris";
            this.Load += new System.EventHandler(this.OgunGiris_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgwYiyecekler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwOgunler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwYiyecekler;
        private System.Windows.Forms.ComboBox cmbOgun;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.DataGridView dgwOgunler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbKategori;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbPorsiyon;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnOgunSil;
        private System.Windows.Forms.Button btnOgunListele;
    }
}