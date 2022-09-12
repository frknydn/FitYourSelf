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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TarifBul));
            this.dgwTarifler = new System.Windows.Forms.DataGridView();
            this.rchMalzemeler = new System.Windows.Forms.RichTextBox();
            this.rchAciklama = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnUyeOl = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
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
            this.dgwTarifler.Location = new System.Drawing.Point(19, 80);
            this.dgwTarifler.Margin = new System.Windows.Forms.Padding(4);
            this.dgwTarifler.Name = "dgwTarifler";
            this.dgwTarifler.RowHeadersWidth = 51;
            this.dgwTarifler.Size = new System.Drawing.Size(434, 354);
            this.dgwTarifler.TabIndex = 1;
            // 
            // rchMalzemeler
            // 
            this.rchMalzemeler.BackColor = System.Drawing.Color.WhiteSmoke;
            this.rchMalzemeler.Location = new System.Drawing.Point(22, 80);
            this.rchMalzemeler.Margin = new System.Windows.Forms.Padding(4);
            this.rchMalzemeler.Name = "rchMalzemeler";
            this.rchMalzemeler.Size = new System.Drawing.Size(305, 499);
            this.rchMalzemeler.TabIndex = 2;
            this.rchMalzemeler.Text = "";
            // 
            // rchAciklama
            // 
            this.rchAciklama.BackColor = System.Drawing.Color.WhiteSmoke;
            this.rchAciklama.Location = new System.Drawing.Point(358, 80);
            this.rchAciklama.Margin = new System.Windows.Forms.Padding(4);
            this.rchAciklama.Name = "rchAciklama";
            this.rchAciklama.Size = new System.Drawing.Size(380, 499);
            this.rchAciklama.TabIndex = 3;
            this.rchAciklama.Text = "";
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Futura Bk BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label8.Location = new System.Drawing.Point(18, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(183, 23);
            this.label8.TabIndex = 5;
            this.label8.Text = "Malzemeler:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnUyeOl
            // 
            this.btnUyeOl.BackColor = System.Drawing.Color.Silver;
            this.btnUyeOl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUyeOl.Font = new System.Drawing.Font("Futura Bk BT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUyeOl.Location = new System.Drawing.Point(29, 455);
            this.btnUyeOl.Margin = new System.Windows.Forms.Padding(4);
            this.btnUyeOl.Name = "btnUyeOl";
            this.btnUyeOl.Size = new System.Drawing.Size(220, 33);
            this.btnUyeOl.TabIndex = 14;
            this.btnUyeOl.Text = "Detay Getir";
            this.btnUyeOl.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.dgwTarifler);
            this.groupBox1.Controls.Add(this.btnUyeOl);
            this.groupBox1.Font = new System.Drawing.Font("Futura Bk BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.groupBox1.Location = new System.Drawing.Point(425, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(477, 513);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TARİF SEÇİMİ";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.rchMalzemeler);
            this.groupBox2.Controls.Add(this.rchAciklama);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Font = new System.Drawing.Font("Futura Bk BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.groupBox2.Location = new System.Drawing.Point(965, 52);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(758, 628);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "TARİF DETAYLARI";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Futura Bk BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(354, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Açıklama:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TarifBul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1764, 785);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TarifBul";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TarifBul";
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
        private System.Windows.Forms.Button btnUyeOl;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
    }
}