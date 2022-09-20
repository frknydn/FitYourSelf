namespace FitYourSelf.Forms
{
    partial class TarifBul
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
            this.dgwTarifler = new System.Windows.Forms.DataGridView();
            this.rchMalzemeler = new System.Windows.Forms.RichTextBox();
            this.rchAciklama = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTarifDetayGetir1 = new FitYourSelf.FurkanButtons();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwTarifler)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwTarifler
            // 
            this.dgwTarifler.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgwTarifler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwTarifler.Location = new System.Drawing.Point(14, 65);
            this.dgwTarifler.Name = "dgwTarifler";
            this.dgwTarifler.RowHeadersWidth = 51;
            this.dgwTarifler.Size = new System.Drawing.Size(326, 288);
            this.dgwTarifler.TabIndex = 1;
            this.dgwTarifler.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgwTarifler_CellMouseClick);
            // 
            // rchMalzemeler
            // 
            this.rchMalzemeler.BackColor = System.Drawing.Color.WhiteSmoke;
            this.rchMalzemeler.Location = new System.Drawing.Point(16, 65);
            this.rchMalzemeler.Name = "rchMalzemeler";
            this.rchMalzemeler.Size = new System.Drawing.Size(230, 406);
            this.rchMalzemeler.TabIndex = 2;
            this.rchMalzemeler.Text = "";
            // 
            // rchAciklama
            // 
            this.rchAciklama.BackColor = System.Drawing.Color.WhiteSmoke;
            this.rchAciklama.Location = new System.Drawing.Point(268, 65);
            this.rchAciklama.Name = "rchAciklama";
            this.rchAciklama.Size = new System.Drawing.Size(286, 406);
            this.rchAciklama.TabIndex = 3;
            this.rchAciklama.Text = "";
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label8.Location = new System.Drawing.Point(16, 43);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 19);
            this.label8.TabIndex = 5;
            this.label8.Text = "Malzemeler:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnTarifDetayGetir1);
            this.groupBox1.Controls.Add(this.dgwTarifler);
            this.groupBox1.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.groupBox1.Location = new System.Drawing.Point(319, 42);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(358, 417);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TARİF SEÇİMİ";
            // 
            // btnTarifDetayGetir1
            // 
            this.btnTarifDetayGetir1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(175)))), ((int)(((byte)(86)))));
            this.btnTarifDetayGetir1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(175)))), ((int)(((byte)(86)))));
            this.btnTarifDetayGetir1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnTarifDetayGetir1.BorderRadius = 20;
            this.btnTarifDetayGetir1.BorderSize = 0;
            this.btnTarifDetayGetir1.FlatAppearance.BorderSize = 0;
            this.btnTarifDetayGetir1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTarifDetayGetir1.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTarifDetayGetir1.ForeColor = System.Drawing.Color.Black;
            this.btnTarifDetayGetir1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnTarifDetayGetir1.Location = new System.Drawing.Point(14, 359);
            this.btnTarifDetayGetir1.Name = "btnTarifDetayGetir1";
            this.btnTarifDetayGetir1.Size = new System.Drawing.Size(160, 41);
            this.btnTarifDetayGetir1.TabIndex = 96;
            this.btnTarifDetayGetir1.Text = "Detay Getir";
            this.btnTarifDetayGetir1.TextColor = System.Drawing.Color.Black;
            this.btnTarifDetayGetir1.UseVisualStyleBackColor = false;
            this.btnTarifDetayGetir1.Click += new System.EventHandler(this.btnTarifDetayGetir1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.rchMalzemeler);
            this.groupBox2.Controls.Add(this.rchAciklama);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.groupBox2.Location = new System.Drawing.Point(724, 42);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(568, 510);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "TARİF DETAYLARI";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(268, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Açıklama:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TarifBul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FitYourSelf.Properties.Resources.TarifBulSon;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1323, 638);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "TarifBul";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TarifBul";
            this.Load += new System.EventHandler(this.TarifBul_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwTarifler)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwTarifler;
        private System.Windows.Forms.RichTextBox rchMalzemeler;
        private System.Windows.Forms.RichTextBox rchAciklama;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private FurkanButtons btnTarifDetayGetir1;
    }
}