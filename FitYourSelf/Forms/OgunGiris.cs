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

        private void OgunGiris_Load(object sender, EventArgs e)
        {
            db = new FitYourSelfContext();
            btnKaydet.BackColor = Color.FromArgb(248, 175, 86);
            ComboboxDonat();  
            
        }

      

        private void btnListele_Click(object sender, EventArgs e)
        {
            YemekleriListele();
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
        }
        int secilenID = 0;
        private void btnEkle_Click(object sender, EventArgs e)
        {

            UserMeals userMeals = new UserMeals();

            Foods foods = db.Foods.Find(secilenID);
            //db.UserMeals.Add(foods);
            //dataGridView2.DataSource = 
            //foods.FoodName= db.Foods.Find(secilenID).ToString();







            if (cmbOgun.SelectedIndex==0)
            {
                userMeals.MealTimes = MealTimes.Breakfast;
                

            }
            if (cmbOgun.SelectedIndex == 1)
            {
                userMeals.MealTimes = MealTimes.Lunch;


            }
            if (cmbOgun.SelectedIndex == 2)
            {
                userMeals.MealTimes = MealTimes.Dinner;


            }
            if (cmbOgun.SelectedIndex ==3)
            {
                userMeals.MealTimes = MealTimes.Snack;

            }
        }

        private void dgwYiyecekler_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            secilenID = (int)dgwYiyecekler.CurrentRow.Cells[0].Value; //Datagridviewdaki seçilen yemeğin foodid sinin getiriyor.
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }
    }
}
