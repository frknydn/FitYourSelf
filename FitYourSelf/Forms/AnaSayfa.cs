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
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
            anaSayfa = this;
        }

        FitYourSelfContext db;
        UserInfo user;

        public static AnaSayfa anaSayfa;
        private void Takip_Load(object sender, EventArgs e)
        {

            DateTime startDateTime = DateTime.Today; //Today at 00:00:00
            DateTime endDateTime = DateTime.Today.AddDays(1).AddTicks(-1); //Today at 23:59:59

            db = new FitYourSelfContext();
            RenkleriAyarla();
            lblIsım.Text = LoginPage.userName;
            var sorgu = db.UserInfo.Where(x => x.UserInfoID == LoginPage.id).FirstOrDefault();            
            lblBoy.Text = sorgu.Height.ToString();
            lblKilo.Text = sorgu.Weight.ToString();
            lblVKI.Text = sorgu.BodyMassIndex.ToString();
            lblDurum.Text = sorgu.BMIStatus.GetDisplayName();

            var water = db.Water.Where(x => x.UserInfoID == LoginPage.id).OrderByDescending(x => x.DateTime).FirstOrDefault();
            if (water.WaterAmount != 0)
            {
                lblSuLitre.Text = $"İçilen Su Miktarı: {water.WaterAmount} Litre";
            }
            else
            {
                lblSuLitre.Text = $"İçilen Su Miktarı: 0 Litre";
            }

        }



        private void öğünGirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OgunGiris ogun = new OgunGiris();
            ogun.ShowDialog();

        }

        private void günlükToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GunlukTakip gunlukTakip = new GunlukTakip();
            gunlukTakip.ShowDialog();
        }

        private void haftalıkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HaftalikTakip HaftalikTakip = new HaftalikTakip();
            HaftalikTakip.ShowDialog();
        }

        private void aylikToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AylikTakip aylikTakip = new AylikTakip();
            aylikTakip.ShowDialog();
        }

        private void tarifGirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TarifBul tarifBul = new TarifBul();
            tarifBul.ShowDialog();
        }

        private void tarifEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TarifEkle tarifEkle = new TarifEkle();
            tarifEkle.ShowDialog();
        }

        private void meydanOkumaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KendineMeydanOku kmo = new KendineMeydanOku();
            kmo.ShowDialog();
        }

        private void yardımToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Yardim yardim = new Yardim();
            yardim.ShowDialog();
        }

        private void üyelikBilgileriGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UyelikGuncellemeEkran uge = new UyelikGuncellemeEkran();
            uge.ShowDialog();
        }

        private void üyelikSilToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!! METHODS !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        #region Metotlar
        private void RenkleriAyarla()
        {
            groupBox1.BackColor = Color.FromArgb(243, 222, 195);
            btnKalIhtiyaciEkle.BackColor = Color.FromArgb(248, 175, 86);
        }


        #endregion

        //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!! METHODS !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!

        private void AnaSayfa_FormClosed(object sender, FormClosedEventArgs e)
        {

            Application.Exit();
        }

        private void lblKalanKaloriMiktari_Click(object sender, EventArgs e)
        {

        }

        private void txtBoy_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;


        }

        private void txtKilo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
                e.Handled = true;
            if (e.KeyChar == ',' && (sender as TextBox).Text.IndexOf(',') > -1)
                e.Handled = true;
        }

        private void btnSifirla_Click(object sender, EventArgs e)
        {
            lblCYSGunSayisi.Text = "0. GÜN";
            lblHedef.Text = "Henüz Hedef Belirlemediniz";
        }

        int glassOfWater = 0;

        private void btnSuEkle_Click(object sender, EventArgs e)
        {
            
            glassOfWater++;
            Water water = new Water()
            {
                GlassOfWater = glassOfWater,
                WaterAmount = 0.25 * glassOfWater,
                DateTime = DateTime.Today,
                UserInfoID = LoginPage.id
            };
            db.Water.Add(water);
            db.SaveChanges();

            


            lblSuLitre.Text = $"İçilen Su Miktarı:  {water.WaterAmount}  Litre";

            //Gün bittiğinde sıfırlasın su miktarını ve uygulama her açıldığında kaldığı yerden devam etsin



        }
    }
}
