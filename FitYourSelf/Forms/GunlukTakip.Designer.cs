namespace FitYourSelf.Forms
{
    partial class GunlukTakip
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GunlukTakip));
            this.parrotLineGraph1 = new ReaLTaiizor.Controls.ParrotLineGraph();
            this.SuspendLayout();
            // 
            // parrotLineGraph1
            // 
            this.parrotLineGraph1.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(217)))), ((int)(((byte)(174)))));
            this.parrotLineGraph1.BelowLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(202)))), ((int)(((byte)(142)))));
            this.parrotLineGraph1.BorderColor = System.Drawing.Color.White;
            this.parrotLineGraph1.GraphStyle = ReaLTaiizor.Controls.ParrotLineGraph.Style.Material;
            this.parrotLineGraph1.GraphTitle = "Parrot Line Graph";
            this.parrotLineGraph1.GraphTitleColor = System.Drawing.Color.Gray;
            this.parrotLineGraph1.Items = ((System.Collections.Generic.List<int>)(resources.GetObject("parrotLineGraph1.Items")));
            this.parrotLineGraph1.LineColor = System.Drawing.Color.White;
            this.parrotLineGraph1.Location = new System.Drawing.Point(211, 135);
            this.parrotLineGraph1.Name = "parrotLineGraph1";
            this.parrotLineGraph1.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            this.parrotLineGraph1.PointSize = 7;
            this.parrotLineGraph1.ShowBorder = false;
            this.parrotLineGraph1.ShowPoints = false;
            this.parrotLineGraph1.ShowTitle = false;
            this.parrotLineGraph1.ShowVerticalLines = false;
            this.parrotLineGraph1.Size = new System.Drawing.Size(200, 100);
            this.parrotLineGraph1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.parrotLineGraph1.TabIndex = 0;
            this.parrotLineGraph1.Text = "parrotLineGraph1";
            this.parrotLineGraph1.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.parrotLineGraph1.TitleAlignment = System.Drawing.StringAlignment.Near;
            this.parrotLineGraph1.VerticalLineColor = System.Drawing.Color.DimGray;
            // 
            // GunlukTakip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 611);
            this.Controls.Add(this.parrotLineGraph1);
            this.Name = "GunlukTakip";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GunlukTakip";
            this.Load += new System.EventHandler(this.GunlukTakip_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Controls.ParrotLineGraph parrotLineGraph1;
    }
}