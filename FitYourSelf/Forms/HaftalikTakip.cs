using FitYourSelf.DataAccess.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitYourSelf.Forms
{
    public partial class HaftalikTakip : Form
    {
        public HaftalikTakip()
        {
            InitializeComponent();
        }
        FitYourSelfContext db;
        private void HaftalikTakip_Load(object sender, EventArgs e)
        {
            double calorie = 0,
                    fat = 0,
                    protein = 0,
                    carbonhydrate = 0;

            db = new FitYourSelfContext();
            DateTime dt1 = (DateTime)DateTime.Today.AddDays(-7);
            dataGridView1.DataSource = db.UserMeals
                .Where(x => x.UserInfoID == LoginPage.id && x.MealDate >= dt1).OrderByDescending(x => x.MealDate).ToList();
            var sorgu = db.UserMeals.Where(x => x.UserInfoID == LoginPage.id).ToList();
            var sorguselo = db.UserMeals
                .Where(x => x.UserInfoID == LoginPage.id && x.MealDate >= dt1).OrderByDescending(x => x.MealDate);


            chart1.Series["Kalori"].Points.Add(calorie);


            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {

                calorie += Convert.ToDouble(dataGridView1.Rows[i].Cells[4].Value);
                fat += Convert.ToDouble(dataGridView1.Rows[i].Cells[5].Value);
                carbonhydrate += Convert.ToDouble(dataGridView1.Rows[i].Cells[6].Value);
                protein += Convert.ToDouble(dataGridView1.Rows[i].Cells[7].Value);
            }
            //dataGridView1.Rows.Add(calorie, fat, carbonhydrate,protein);
            chart1.Series["Kalori"].Points.AddY(calorie);
            chart1.Series["Karbonhidrat"].Points.AddY(carbonhydrate);
            chart1.Series["Yağ"].Points.AddY(fat);
            chart1.Series["Protein"].Points.AddY(protein);
            chart1.Series["Günler"].Points[0].AxisLabel = DateTime.Today.ToString();
            chart1.Series["Günler"].Points[1].AxisLabel = DateTime.Today.AddDays(-1).ToString();
            chart1.Series["Günler"].Points[2].AxisLabel = DateTime.Today.AddDays(-2).ToString();
            chart1.Series["Günler"].Points[3].AxisLabel = DateTime.Today.AddDays(-3).ToString();
            chart1.Series["Günler"].Points[4].AxisLabel = DateTime.Today.AddDays(-4).ToString();
            chart1.Series["Günler"].Points[5].AxisLabel = DateTime.Today.AddDays(-5).ToString();
            chart1.Series["Günler"].Points[6].AxisLabel = DateTime.Today.AddDays(-6).ToString();





            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;//sütünları grid büyüklüğüne göre oto dolduruyor.

        }
    }
}
