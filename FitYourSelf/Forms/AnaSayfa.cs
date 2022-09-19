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

            db = new FitYourSelfContext();
            RenkleriAyarla();
            lblIsım.Text = LoginPage.userName;
            var sorgu = db.UserInfo.Where(x => x.UserInfoID == LoginPage.id).FirstOrDefault();
            lblBoy.Text = sorgu.Height.ToString();
            lblKilo.Text = sorgu.Weight.ToString();
            lblVKI.Text = sorgu.BodyMassIndex.ToString();
            lblDurum.Text = sorgu.BMIStatus.GetDisplayName();
            lblGunlukKalori.Text = sorgu.RequiredCalorie.ToString();



            DateTime currentTimeStamp = new DateTime();
            using (var db = new FitYourSelfContext())
            {
                foreach (var datenow in db.Water)
                    currentTimeStamp = datenow.DateTime;
            }
            DateTime currentNow = DateTime.Now;
            int changeDay = currentNow.Day;
            if (currentTimeStamp.Day != changeDay)
            {
                FitYourSelfContext.ResetItem();
            }

            if (sorgu.WaterAmount == 0)
            {
                lblSuLitre.Text = "Bugün hiç su içmedin.";
                btnSuSil.Enabled = false;
            }
            else
            {
                lblSuLitre.Text = $"{sorgu.WaterAmount} Litre içtin";

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

        private void RenkleriAyarla()
        {
            groupBox1.BackColor = Color.FromArgb(243, 222, 195);
            
        }




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

        DateTime startDateTime = DateTime.Today; //Today at 00:00:00
        DateTime endDateTime = DateTime.Today.AddDays(1).AddTicks(-1); //Today at 23:59:59
        private void btnSuEkle_Click(object sender, EventArgs e)
        {
            btnSuSil.Enabled = true;
            glassOfWater++;
            Water water = new Water()
            {
                GlassOfWater = 1,
                WaterAmount = db.UserInfo.Where(x => x.UserInfoID == LoginPage.id).FirstOrDefault().WaterAmount + 0.25,
                DateTime = DateTime.Today,
                UserInfoID = LoginPage.id

            };

            db.Water.Add(water);
            db.UserInfo.Where(x => x.UserInfoID == LoginPage.id).FirstOrDefault().WaterAmount =
                (double)water.WaterAmount;



            //var deneme = db.Water.Where(x => x.UserInfoID == LoginPage.id && x.DateTime > startDateTime && x.DateTime < endDateTime).OrderByDescending(x => x.WaterAmount);
            //int sayac = 0;

            //foreach (var item in deneme)
            //{
            //    sayac++;
            //    db.UserInfo.Where(x => x.UserInfoID == LoginPage.id).FirstOrDefault().WaterAmount = (double)item.WaterAmount;
            //    if (sayac == 1)
            //    {
            //        break;
            //    }            //}


            //var sorgu = db.UserInfo.Where(x => x.UserInfoID == LoginPage.id).FirstOrDefault();
            //sorgu.WaterAmount = (double)water.WaterAmount;


            db.SaveChanges();




            lblSuLitre.Text = $"İçilen Su Miktarı:  {db.UserInfo.Where(x => x.UserInfoID == LoginPage.id).FirstOrDefault().WaterAmount}  Litre";

            //Gün bittiğinde sıfırlasın su miktarını ve uygulama her açıldığında kaldığı yerden devam etsin

            hopeRoundProgressBar1.ValueNumber =(int)db.UserInfo.Where(x => x.UserInfoID == LoginPage.id).FirstOrDefault().WaterAmount;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("*İlk Kayıt Olduğunuzda Boy, Kilo ve varsa Günlük Kalori İhtiyacı bilgileriniz 0(sıfır) gösterilecektir.\n" +
                "*Boy, kilo ve günlük kalori ihtiyacınızı güncellemek için Üyelik Bilgileri sekmesinden " +
                "Üyelik Bilgileri Güncelle sayfasından ulaşabilirsiniz. Böylelikle Vücut Kitle İndeksiniz otomatik olarak hesaplanacaktır.", "İlk Kayıt Olunduğunda Yapılacaklar");
        }


        private void btnSuSil_Click(object sender, EventArgs e)
        {
            var sorgu = db.Water.Where(x => x.UserInfoID == LoginPage.id).OrderByDescending(x => x.WaterAmount);
            var sorgu2 = db.UserInfo.Where(x => x.UserInfoID == LoginPage.id).FirstOrDefault().WaterAmount;




            int sayac = 0;
            foreach (var item in sorgu)
            {
                sayac++;
                db.Water.Remove(item);
                if (sayac == 1)

                    break;

            }
            double yenisayi = db.UserInfo.Where(x => x.UserInfoID == LoginPage.id).FirstOrDefault().WaterAmount - 0.25;
            if (yenisayi <= 0)
            {
                yenisayi = 0;
                btnSuSil.Enabled = false;
            }

            db.UserInfo.Where(x => x.UserInfoID == LoginPage.id).FirstOrDefault().WaterAmount = yenisayi;



            db.SaveChanges();

            //var sorgu2 = db.UserInfo.Where(x => x.UserInfoID == LoginPage.id).FirstOrDefault().WaterAmount;
            //int sayac2 = 0;
            //foreach (var item in sorgu)
            //{
            //    sayac2++;
            //    sorgu2 =Convert.ToDouble(sorgu - 0.25);
            //    if (sayac2 == 1)
            //        break;

            //}
            //db.SaveChanges();


            lblSuLitre.Text = $"İçilen Su Miktarı:  {db.UserInfo.Where(x => x.UserInfoID == LoginPage.id).FirstOrDefault().WaterAmount}  Litre";
        }
    }
}