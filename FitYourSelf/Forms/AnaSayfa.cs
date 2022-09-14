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
        }

        FitYourSelfContext db;
        UserInfo user;


        private void Takip_Load(object sender, EventArgs e)
        {
            db = new FitYourSelfContext();
            RenkleriAyarla();
            lblIsım.Text = LoginPage.userName;
        }
        private void btnBoyKiloEkle_Click(object sender, EventArgs e)
        {


            if (BoyDogrumu() && KiloDogruMu())
            {
                var kullanici = db.UserInfo.Where(x => x.UserInfoID == LoginPage.id).FirstOrDefault();
                kullanici.Height = Convert.ToInt32(txtBoy.Text);
                kullanici.Weight = Convert.ToDouble(txtKilo.Text);
                kullanici.BodyMassIndex = BMIHesapla(kullanici.Height, kullanici.Weight);


                lblVKI.Text = kullanici.BodyMassIndex.ToString();

                if (kullanici.BodyMassIndex >= 0 && kullanici.BodyMassIndex <= 18.4)
                {
                    kullanici.BMIStatus = BMIStatus.Zayıf;
                    lblDurum.Text = BMIStatus.Zayıf.GetDisplayName();
                }
                if (kullanici.BodyMassIndex > 18.4 && kullanici.BodyMassIndex <= 24.9)
                {
                    kullanici.BMIStatus = BMIStatus.NormalKilolu;
                    lblDurum.Text = BMIStatus.NormalKilolu.GetDisplayName();
                }
                if (kullanici.BodyMassIndex > 25 && kullanici.BodyMassIndex <= 29.9)
                {
                    kullanici.BMIStatus = BMIStatus.FazlaKilolu;
                    lblDurum.Text = BMIStatus.FazlaKilolu.GetDisplayName();
                }
                if (kullanici.BodyMassIndex > 30 && kullanici.BodyMassIndex <= 34.9)
                {
                    kullanici.BMIStatus = BMIStatus.BirinciDereceObezite;
                    lblDurum.Text = BMIStatus.BirinciDereceObezite.GetDisplayName();
                }
                if (kullanici.BodyMassIndex > 35 && kullanici.BodyMassIndex <= 39.9)
                {
                    kullanici.BMIStatus = BMIStatus.İkinciDereceObezite;
                    lblDurum.Text = BMIStatus.İkinciDereceObezite.GetDisplayName();
                }
                if (kullanici.BodyMassIndex > 40)
                {
                    kullanici.BMIStatus = BMIStatus.ÜçüncüDereceObezite;
                    lblDurum.Text = BMIStatus.ÜçüncüDereceObezite.GetDisplayName();
                }

                db.SaveChanges();

                txtBoy.Text = kullanici.Height.ToString();
                txtBoy.Enabled = false;

                txtKilo.Text = kullanici.Weight.ToString();
                txtKilo.Enabled = false;

                btnBoyKiloEkle.Visible = false;
                




            }
            else
            {
                if (Convert.ToInt32(txtBoy.Text) <= 100 || Convert.ToInt32(txtBoy.Text) >= 220)
                    MessageBox.Show("Lütfen boy için 100 ila 220 cm arası bir değer giriniz.");
                if (Convert.ToInt32(txtKilo.Text) <= 20 || Convert.ToInt32(txtKilo.Text) >= 200)
                    MessageBox.Show("Lütfen kilo için 20 ila 200 kg arası bir değer giriniz.");
            }


        }

        private double BMIHesapla(double boy, double kilo)
        {
            double mBoy = boy / 100;
            double bmiIndex;
            bmiIndex =Math.Round( (kilo / (mBoy * mBoy)),2);
            return bmiIndex;
        }

        private bool KiloDogruMu()
        {
            if (Convert.ToInt32(txtKilo.Text) <= 20 || Convert.ToInt32(txtKilo.Text) >= 200)
                return false;
            else
                return true;
        }

        private bool BoyDogrumu()
        {
            if (Convert.ToInt32(txtBoy.Text) <= 100 || Convert.ToInt32(txtBoy.Text) >= 220)
                return false;
            else
                return true;


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
            btnBoyKiloEkle.BackColor = Color.FromArgb(248, 175, 86);
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
    }
}
