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
            //var sorgu2 = db.UserInfo.Where(x => x.UserInfoID == LoginPage.id).FirstOrDefault();
            //double toplamKalori = sorgu2.DailyCalorie;
            //double toplamProtein = 0;
            //double toplamYag = 0;
            //double toplamKarbonhidrat = 0;
            ComboboxDonat();
            YenilenYemekleriListele();
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
            lblTopKalori.Text = "0";

            if (secilenID == 0)
            {
                MessageBox.Show("Yemek Seçimi Yapmadınız.");
            }
            else
            {
                YemekEkle();


            }
            YenilenYemekleriListele();
            var sorgu2 = db.UserMeals.Where(x => x.UserInfoID == LoginPage.id);
            var sorgu3 = db.UserInfo.Where(x => x.UserInfoID == LoginPage.id).FirstOrDefault();
            foreach (var item in sorgu2)
            {
                sorgu3.DailyCalorie += item.Calorie;
                //toplamProtein += item.Protein;
                //toplamYag += item.Fat;
                //toplamKarbonhidrat += item.Carbonhidrate;

            }

            lblTopKalori.Text = sorgu3.DailyCalorie.ToString();
            //lblTopProtein.Text = toplamProtein.ToString();
            //lblTopYag.Text = toplamYag.ToString();
            //lblTopKarb.Text = toplamKarbonhidrat.ToString();

            //BURASI GÜNCELLENECEK!!!!!


        }


        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            YemekGuncelle();
            YenilenYemekleriListele();
        }

        
        private void btnSil_Click(object sender, EventArgs e)
        {
            var silinecekYemek = db.UserMeals.Where(x => x.UserMealsID == yenilenYemekID).FirstOrDefault();
            if (silinecekYemek == null)
                MessageBox.Show("Seçim Yapmadın");
            else
            {
                db.UserMeals.Remove(silinecekYemek);
                var sorgu3 = db.UserInfo.Where(x => x.UserInfoID == LoginPage.id).FirstOrDefault();
                sorgu3.DailyCalorie = sorgu3.DailyCalorie - silinecekYemek.Calorie;
                if (sorgu3.DailyCalorie < 0)
                {
                    sorgu3.DailyCalorie = 0;
                }
                lblTopKalori.Text = sorgu3.DailyCalorie.ToString(); //yeni yaren
                db.SaveChanges();
            }

            YenilenYemekleriListele();


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
            cmbKategori.Items.Add("Bakliyat ve Tahıllar");
            cmbKategori.Items.Add("Sebzeler");
            cmbKategori.Items.Add("Meyveler");
            cmbKategori.Items.Add("Tatlılar ve Hamurişleri");
            cmbKategori.Items.Add("Atıştırmalıklar ve Ek Malzemeler");
            cmbKategori.Items.Add("İçecekler");
            cmbKategori.Items.Add("Yağlar");
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
            YenilenYemekleriListele();
            //öğün isimlerinin boşluklu yazılması
        }


        int yenilenYemekID = 0;


        private void YemekGuncelle()
        {
            var guncellenecekYimek = db.UserMeals.Where(x => x.UserMealsID == yenilenYemekID).FirstOrDefault();

            if (guncellenecekYimek == null)
                MessageBox.Show("Seçim Yapmadınız.");
            else
            {
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
            }

            db.SaveChanges();
            db.UserMeals.ToList();
        }

        private void dataGridView2_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            yenilenYemekID = (int)dgwOgunler.CurrentRow.Cells[0].Value;
        }

        private void YenilenYemekleriListele()
        {
            var listele = db.UserMeals.Where(x => x.UserInfoID == LoginPage.id);
            dgwOgunler.DataSource = listele.ToList();
            dgwOgunler.Columns[0].Visible = false;
            dgwOgunler.Columns[9].Visible = false;
            dgwOgunler.Columns[10].Visible = false;
            this.dgwOgunler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgwOgunler.RowHeadersVisible = false;
            dgwOgunler.Columns[1].HeaderText = "Öğün Ekleme Tarihi";
            dgwOgunler.Columns[2].HeaderText = "Öğün";
            dgwOgunler.Columns[3].HeaderText = "Yemek İsmi";
            dgwOgunler.Columns[4].HeaderText = "Kalori";
            dgwOgunler.Columns[5].HeaderText = "Yağ";
            dgwOgunler.Columns[6].HeaderText = "Karbonhidrat";
            dgwOgunler.Columns[8].HeaderText = "Porsiyon";
            dgwOgunler.Font = new Font("Calibri", 10);
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


            var sorgu3 = db.UserInfo.Where(x => x.UserInfoID == LoginPage.id).FirstOrDefault();
            sorgu3.DailyCalorie = sorgu3.DailyCalorie + userMeals.Calorie;
            lblTopKalori.Text = sorgu3.DailyCalorie.ToString(); //yeni yaren



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
            if (cmbKategori.SelectedIndex == 7)
            {
                dgwYiyecekler.DataSource = db.Foods.Where(x => x.FoodCategoryID == 8).ToList();
                TabloDuzenle();
            }
            if (cmbKategori.SelectedIndex == 8)
            {
                dgwYiyecekler.DataSource = db.Foods.Where(x => x.FoodCategoryID == 9).ToList();
                TabloDuzenle();
            }

        }


    }

}
