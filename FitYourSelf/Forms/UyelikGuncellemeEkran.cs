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
    public partial class UyelikGuncellemeEkran : Form
    {
        public UyelikGuncellemeEkran()
        {
            InitializeComponent();

        }


        FitYourSelfContext db;

        private void UyelikGuncellemeEkran_Load(object sender, EventArgs e)
        {
            db = new FitYourSelfContext();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (BoyDogrumu() && KiloDogruMu())
            {
                var kullanici = db.UserInfo.Where(x => x.UserInfoID == LoginPage.id).FirstOrDefault();
                kullanici.Height = Convert.ToInt32(txtBoy.Text);
                kullanici.Weight = Convert.ToDouble(txtKilo.Text);
                kullanici.BodyMassIndex = BMIHesapla(kullanici.Height, kullanici.Weight);
                AnaSayfa.anaSayfa.lblVKI.Text = kullanici.BodyMassIndex.ToString();
                AnaSayfa.anaSayfa.lblVKI.Text = kullanici.BodyMassIndex.ToString();
                AnaSayfa.anaSayfa.lblBoy.Text = kullanici.Height.ToString();
                AnaSayfa.anaSayfa.lblKilo.Text = kullanici.Weight.ToString();

                if (kullanici.BodyMassIndex >= 0 && kullanici.BodyMassIndex <= 18.4)
                {
                    kullanici.BMIStatus = BMIStatus.Zayıf;
                    AnaSayfa.anaSayfa.lblDurum.Text = BMIStatus.Zayıf.GetDisplayName();
                }
                if (kullanici.BodyMassIndex > 18.4 && kullanici.BodyMassIndex <= 24.9)
                {
                    kullanici.BMIStatus = BMIStatus.NormalKilolu;
                    AnaSayfa.anaSayfa.lblDurum.Text = BMIStatus.NormalKilolu.GetDisplayName();
                }
                if (kullanici.BodyMassIndex > 25 && kullanici.BodyMassIndex <= 29.9)
                {
                    kullanici.BMIStatus = BMIStatus.FazlaKilolu;
                    AnaSayfa.anaSayfa.lblDurum.Text = BMIStatus.FazlaKilolu.GetDisplayName();
                }
                if (kullanici.BodyMassIndex > 30 && kullanici.BodyMassIndex <= 34.9)
                {
                    kullanici.BMIStatus = BMIStatus.BirinciDereceObezite;
                    AnaSayfa.anaSayfa.lblDurum.Text = BMIStatus.BirinciDereceObezite.GetDisplayName();
                }
                if (kullanici.BodyMassIndex > 35 && kullanici.BodyMassIndex <= 39.9)
                {
                    kullanici.BMIStatus = BMIStatus.İkinciDereceObezite;
                    AnaSayfa.anaSayfa.lblDurum.Text = BMIStatus.İkinciDereceObezite.GetDisplayName();
                }
                if (kullanici.BodyMassIndex > 40)
                {
                    kullanici.BMIStatus = BMIStatus.ÜçüncüDereceObezite;
                    AnaSayfa.anaSayfa.lblDurum.Text = BMIStatus.ÜçüncüDereceObezite.GetDisplayName();
                }

                db.SaveChanges();

                MessageBox.Show("Eklendi");


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
            bmiIndex = Math.Round((kilo / (mBoy * mBoy)), 2);
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

        private void btnGeriDön_Click(object sender, EventArgs e)
        {
            this.Hide();

        }



    }
}
