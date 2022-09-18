using FitYorSelf.Entities.Concrete;
using FitYorSelf.Entities.Enums;
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
    public partial class OgunGiris : Form
    {
        public OgunGiris()
        {
            InitializeComponent();
        }

        FitYourSelfContext db;

        private void OgunGiris_Load_1(object sender, EventArgs e)
        {
            db = new FitYourSelfContext();
            ComboboxDonat();
            DGW2Listele();
            cmbPorsiyon.SelectedIndex = 0;
            cmbOgun.SelectedIndex = 0;
            cmbKategori.SelectedIndex = 0;
        }



        private void btnListele_Click(object sender, EventArgs e)
        {
            YemekleriListele();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            var sorgu = db.Foods.Where(x => x.FoodID == secilenID);


            if (secilenID == 0)
            {
                MessageBox.Show("Yemek Seçmedin");
            }
            else
            {
                YemekEkle();

            }
            DGW2Listele();

        }


        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            YemekGuncelle();
            DGW2Listele();
        }


        private void btnSil_Click(object sender, EventArgs e)
        {
            var silinecekYemek = db.UserMeals.Where(x => x.UserMealsID == yenilenYemekID).FirstOrDefault();
            db.UserMeals.Remove(silinecekYemek);
            db.SaveChanges();
            DGW2Listele();

        }

        private void TabloDuzenle()
        {
            dgwYiyecekler.Columns[0].Visible = false;
            dgwYiyecekler.Columns[7].Visible = false;
            dgwYiyecekler.Columns[8].Visible = false;
            this.dgwYiyecekler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgwYiyecekler.RowHeadersVisible = false;
            dgwYiyecekler.Columns[1].HeaderText = "Yemek İsmi";
            dgwYiyecekler.Columns[2].HeaderText = "Kalori";
            dgwYiyecekler.Columns[3].HeaderText = "Yağ";
            dgwYiyecekler.Columns[4].HeaderText = "Karbonhidrat";
            dgwYiyecekler.Columns[5].HeaderText = "Protein";
            dgwYiyecekler.Columns[6].HeaderText = "Açıklama";
            dgwYiyecekler.Font = new Font("Calibri", 10);

        }

        private void ComboboxDonat()
        {
            cmbOgun.Items.Add("Kahvaltı");
            cmbOgun.Items.Add("Öğle Yemeği");
            cmbOgun.Items.Add("Akşam Yemeği");
            cmbOgun.Items.Add("Ara Öğün");
            cmbKategori.Items.Add("Süt ve Süt Ürünleri");
            cmbKategori.Items.Add("Et Ürünleri ve Yumurta");
            cmbKategori.Items.Add("Bakliyat");
            cmbKategori.Items.Add("Sebzeler");
            cmbKategori.Items.Add("Meyveler");
            cmbKategori.Items.Add("Tatlılar");
            cmbKategori.Items.Add("Atıştırmalıklar");
            cmbPorsiyon.Items.Add(0.5);
            cmbPorsiyon.Items.Add(1);
            cmbPorsiyon.Items.Add(1.5);
            cmbPorsiyon.Items.Add(2);
        }
        int secilenID = 0;


        private void dgwYiyecekler_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            secilenID = (int)dgwYiyecekler.CurrentRow.Cells[0].Value; //Datagridviewdaki seçilen yemeğin foodid sinin getiriyor.
        }



        private void btnOgunListele_Click(object sender, EventArgs e)
        {
            DGW2Listele();
            //öğün isimlerinin boşluklu yazılması
        }


        int yenilenYemekID = 0;


        private void YemekGuncelle()
        {
            var guncellenecekYimek = db.UserMeals.Where(x => x.UserMealsID == yenilenYemekID).FirstOrDefault();
            if (guncellenecekYimek.Portion == 0.5)
            {
                if (cmbPorsiyon.SelectedIndex == 1)
                {
                    guncellenecekYimek.Calorie = Math.Round(2 * guncellenecekYimek.Calorie, 2);
                    guncellenecekYimek.Fat = Math.Round(2 * guncellenecekYimek.Fat, 2);
                    guncellenecekYimek.Carbonhidrate = Math.Round(2 * guncellenecekYimek.Carbonhidrate, 2);
                    guncellenecekYimek.Protein = Math.Round(2 * guncellenecekYimek.Protein, 2);
                    guncellenecekYimek.Portion = Convert.ToDouble(cmbPorsiyon.Text);
                }
                if (cmbPorsiyon.SelectedIndex == 2)
                {
                    guncellenecekYimek.Calorie = Math.Round(3 * guncellenecekYimek.Calorie, 2);
                    guncellenecekYimek.Fat = Math.Round(3 * guncellenecekYimek.Fat, 2);
                    guncellenecekYimek.Carbonhidrate = Math.Round(3 * guncellenecekYimek.Carbonhidrate, 2);
                    guncellenecekYimek.Protein = Math.Round(3 * guncellenecekYimek.Protein, 2);
                    guncellenecekYimek.Portion = Convert.ToDouble(cmbPorsiyon.Text);


                }
                if (cmbPorsiyon.SelectedIndex == 3)
                {
                    guncellenecekYimek.Calorie = Math.Round(4 * guncellenecekYimek.Calorie, 2);
                    guncellenecekYimek.Fat = Math.Round(4 * guncellenecekYimek.Fat, 2);
                    guncellenecekYimek.Carbonhidrate = Math.Round(4 * guncellenecekYimek.Carbonhidrate, 2);
                    guncellenecekYimek.Protein = Math.Round(4 * guncellenecekYimek.Protein, 2);
                    guncellenecekYimek.Portion = Convert.ToDouble(cmbPorsiyon.Text);

                }


            }

            if (guncellenecekYimek.Portion == 1)
            {
                if (cmbPorsiyon.SelectedIndex == 0)
                {
                    guncellenecekYimek.Calorie = Math.Round(0.5 * guncellenecekYimek.Calorie, 2);
                    guncellenecekYimek.Fat = Math.Round(0.5 * guncellenecekYimek.Fat, 2);
                    guncellenecekYimek.Carbonhidrate = Math.Round(0.5 * guncellenecekYimek.Carbonhidrate, 2);
                    guncellenecekYimek.Protein = Math.Round(0.5 * guncellenecekYimek.Protein, 2);
                    guncellenecekYimek.Portion = Convert.ToDouble(cmbPorsiyon.Text);

                }
                if (cmbPorsiyon.SelectedIndex == 2)
                {
                    guncellenecekYimek.Calorie = Math.Round(1.5 * guncellenecekYimek.Calorie, 2);
                    guncellenecekYimek.Fat = Math.Round(1.5 * guncellenecekYimek.Fat, 2);
                    guncellenecekYimek.Carbonhidrate = Math.Round(1.5 * guncellenecekYimek.Carbonhidrate, 2);
                    guncellenecekYimek.Protein = Math.Round(1.5 * guncellenecekYimek.Protein, 2);
                    guncellenecekYimek.Portion = Convert.ToDouble(cmbPorsiyon.Text);

                }
                if (cmbPorsiyon.SelectedIndex == 3)
                {
                    guncellenecekYimek.Calorie = Math.Round(2 * guncellenecekYimek.Calorie, 2);
                    guncellenecekYimek.Fat = Math.Round(2 * guncellenecekYimek.Fat, 2);
                    guncellenecekYimek.Carbonhidrate = Math.Round(2 * guncellenecekYimek.Carbonhidrate, 2);
                    guncellenecekYimek.Protein = Math.Round(2 * guncellenecekYimek.Protein, 2);
                    guncellenecekYimek.Portion = Convert.ToDouble(cmbPorsiyon.Text);

                }
            }
            if (guncellenecekYimek.Portion == 1.5)
            {
                if (cmbPorsiyon.SelectedIndex == 0)
                {
                    guncellenecekYimek.Calorie = Math.Round(guncellenecekYimek.Calorie / 3, 2);
                    guncellenecekYimek.Fat = Math.Round(guncellenecekYimek.Fat / 3, 2);
                    guncellenecekYimek.Carbonhidrate = Math.Round(guncellenecekYimek.Carbonhidrate / 3, 2);
                    guncellenecekYimek.Protein = Math.Round(guncellenecekYimek.Protein / 3, 2);
                    guncellenecekYimek.Portion = Convert.ToDouble(cmbPorsiyon.Text);

                }
                if (cmbPorsiyon.SelectedIndex == 1)
                {
                    guncellenecekYimek.Calorie = Math.Round(0.66666666666667 * guncellenecekYimek.Calorie, 2);
                    guncellenecekYimek.Fat = Math.Round(0.66666666666667 * guncellenecekYimek.Fat, 2);
                    guncellenecekYimek.Carbonhidrate = Math.Round(0.66666666666667 * guncellenecekYimek.Carbonhidrate, 2);
                    guncellenecekYimek.Protein = Math.Round(0.66666666666667 * guncellenecekYimek.Protein, 2);
                    guncellenecekYimek.Portion = Convert.ToDouble(cmbPorsiyon.Text);

                }
                if (cmbPorsiyon.SelectedIndex == 3)
                {
                    guncellenecekYimek.Calorie = Math.Round(1.333333333333333 * guncellenecekYimek.Calorie, 2);
                    guncellenecekYimek.Fat = Math.Round(1.333333333333333 * guncellenecekYimek.Fat, 2);
                    guncellenecekYimek.Carbonhidrate = Math.Round(1.333333333333333 * guncellenecekYimek.Carbonhidrate, 2);
                    guncellenecekYimek.Protein = Math.Round(1.333333333333333 * guncellenecekYimek.Protein, 2);
                    guncellenecekYimek.Portion = Convert.ToDouble(cmbPorsiyon.Text);

                }
            }

            if (guncellenecekYimek.Portion == 2)
            {
                if (cmbPorsiyon.SelectedIndex == 0)
                {
                    guncellenecekYimek.Calorie = Math.Round(guncellenecekYimek.Calorie / 4, 2);
                    guncellenecekYimek.Fat = Math.Round(guncellenecekYimek.Fat / 4, 2);
                    guncellenecekYimek.Carbonhidrate = Math.Round(guncellenecekYimek.Carbonhidrate / 4, 2);
                    guncellenecekYimek.Protein = Math.Round(guncellenecekYimek.Protein / 4, 2);
                    guncellenecekYimek.Portion = Convert.ToDouble(cmbPorsiyon.Text);

                }
                if (cmbPorsiyon.SelectedIndex == 1)
                {
                    guncellenecekYimek.Calorie = Math.Round(guncellenecekYimek.Calorie / 2, 2);
                    guncellenecekYimek.Fat = Math.Round(guncellenecekYimek.Fat / 2, 2);
                    guncellenecekYimek.Carbonhidrate = Math.Round(guncellenecekYimek.Carbonhidrate / 3, 2);
                    guncellenecekYimek.Protein = Math.Round(guncellenecekYimek.Protein / 2, 2);
                    guncellenecekYimek.Portion = Convert.ToDouble(cmbPorsiyon.Text);

                }
                if (cmbPorsiyon.SelectedIndex == 2)
                {
                    guncellenecekYimek.Calorie = Math.Round(0.75 * guncellenecekYimek.Calorie, 2);
                    guncellenecekYimek.Fat = Math.Round(0.75 * guncellenecekYimek.Fat, 2);
                    guncellenecekYimek.Carbonhidrate = Math.Round(0.75 * guncellenecekYimek.Carbonhidrate, 2);
                    guncellenecekYimek.Protein = Math.Round(0.75 * guncellenecekYimek.Protein, 2);
                    guncellenecekYimek.Portion = Convert.ToDouble(cmbPorsiyon.Text);

                }
            }

            db.SaveChanges();
            db.UserMeals.ToList();
        }

        private void dataGridView2_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            yenilenYemekID = (int)dataGridView2.CurrentRow.Cells[0].Value;
        }

        private void DGW2Listele()
        {
            var listele = db.UserMeals.Where(x => x.UserInfoID == LoginPage.id);
            dataGridView2.DataSource = listele.ToList();
            dataGridView2.Columns[0].Visible = false;
            dataGridView2.Columns[9].Visible = false;
            dataGridView2.Columns[10].Visible = false;
            this.dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.RowHeadersVisible = false;
            dataGridView2.Columns[1].HeaderText = "Öğün Ekleme Tarihi";
            dataGridView2.Columns[2].HeaderText = "Öğün";
            dataGridView2.Columns[3].HeaderText = "Yemek İsmi";
            dataGridView2.Columns[4].HeaderText = "Kalori";
            dataGridView2.Columns[5].HeaderText = "Yağ";
            dataGridView2.Columns[6].HeaderText = "Karbonhidrat";
            dataGridView2.Columns[8].HeaderText = "Porsiyon";
            dataGridView2.Font = new Font("Calibri", 10);
        }

        private void YemekEkle()
        {
            var sorgu = db.Foods.Where(x => x.FoodID == secilenID);
            UserMeals userMeals = new UserMeals();
            userMeals.FoodName = sorgu.FirstOrDefault().FoodName;
            if (cmbPorsiyon.SelectedIndex == 0)
            {
                userMeals.Carbonhidrate = Math.Round(sorgu.FirstOrDefault().Carbonhidrate * 0.5, 2);
                userMeals.Fat = Math.Round(sorgu.FirstOrDefault().Fat * 0.5, 2);
                userMeals.Protein = Math.Round(sorgu.FirstOrDefault().Protein * 0.5, 2);
                userMeals.Calorie = Math.Round(sorgu.FirstOrDefault().Calorie * 0.5, 2);
                userMeals.Portion = Convert.ToDouble(cmbPorsiyon.Text);

            }
            if (cmbPorsiyon.SelectedIndex == 1)
            {
                userMeals.Carbonhidrate = Math.Round(sorgu.FirstOrDefault().Carbonhidrate, 2);
                userMeals.Fat = Math.Round(sorgu.FirstOrDefault().Fat, 2);
                userMeals.Protein = Math.Round(sorgu.FirstOrDefault().Protein, 2);
                userMeals.Calorie = Math.Round(sorgu.FirstOrDefault().Calorie, 2);
                userMeals.Portion = Convert.ToDouble(cmbPorsiyon.Text);

            }
            if (cmbPorsiyon.SelectedIndex == 2)
            {
                userMeals.Carbonhidrate = Math.Round(sorgu.FirstOrDefault().Carbonhidrate * 1.5, 2);
                userMeals.Fat = Math.Round(sorgu.FirstOrDefault().Fat * 1.5);
                userMeals.Protein = Math.Round(sorgu.FirstOrDefault().Protein * 1.5, 2);
                userMeals.Calorie = Math.Round(sorgu.FirstOrDefault().Calorie * 1.5, 2);
                userMeals.Portion = Convert.ToDouble(cmbPorsiyon.Text);


            }
            if (cmbPorsiyon.SelectedIndex == 3)
            {
                userMeals.Carbonhidrate = Math.Round(sorgu.FirstOrDefault().Carbonhidrate * 2, 2);
                userMeals.Fat = Math.Round(sorgu.FirstOrDefault().Fat * 2, 2);
                userMeals.Protein = Math.Round(sorgu.FirstOrDefault().Protein * 2, 2);
                userMeals.Calorie = Math.Round(sorgu.FirstOrDefault().Calorie * 2, 2);
                userMeals.Portion = Convert.ToDouble(cmbPorsiyon.Text);


            }

            userMeals.MealDate = DateTime.Now.Date;
            userMeals.UserInfoID = LoginPage.id;

            if (cmbOgun.SelectedIndex == 0)
            {
                userMeals.MealTimes = MealTimes.Kahvaltı;


            }
            if (cmbOgun.SelectedIndex == 1)
            {
                userMeals.MealTimes = MealTimes.ÖğleYemeği;


            }
            if (cmbOgun.SelectedIndex == 2)
            {
                userMeals.MealTimes = MealTimes.AkşamYemeği;

            }

            if (cmbOgun.SelectedIndex == 3)
            {
                userMeals.MealTimes = MealTimes.AraÖğün;

            }
            db.UserMeals.Add(userMeals);
            db.SaveChanges();
        }

        private void YemekleriListele()
        {
            if (cmbKategori.SelectedIndex == 0)
            {

                dgwYiyecekler.DataSource = db.Foods.Where(x => x.FoodCategoryID == 1).ToList();
                TabloDuzenle();


            }
            if (cmbKategori.SelectedIndex == 1)
            {
                dgwYiyecekler.DataSource = db.Foods.Where(x => x.FoodCategoryID == 2).ToList();
                TabloDuzenle();
            }
            if (cmbKategori.SelectedIndex == 2)
            {
                dgwYiyecekler.DataSource = db.Foods.Where(x => x.FoodCategoryID == 3).ToList();
                TabloDuzenle();
            }

            if (cmbKategori.SelectedIndex == 3)
            {
                dgwYiyecekler.DataSource = db.Foods.Where(x => x.FoodCategoryID == 4).ToList();
                TabloDuzenle();
            }
            if (cmbKategori.SelectedIndex == 4)
            {
                dgwYiyecekler.DataSource = db.Foods.Where(x => x.FoodCategoryID == 5).ToList();
                TabloDuzenle();
            }

            if (cmbKategori.SelectedIndex == 5)
            {
                dgwYiyecekler.DataSource = db.Foods.Where(x => x.FoodCategoryID == 6).ToList();
                TabloDuzenle();
            }
            if (cmbKategori.SelectedIndex == 6)
            {
                dgwYiyecekler.DataSource = db.Foods.Where(x => x.FoodCategoryID == 7).ToList();
                TabloDuzenle();
            }
        }


    }

}
