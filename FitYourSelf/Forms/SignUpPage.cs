using FitYorSelf.Entities.Concrete;
using FitYourSelf.DataAccess.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitYourSelf.Forms
{
    public partial class SignUpPage : Form
    {
        public SignUpPage()
        {
            InitializeComponent();
        }

        FitYourSelfContext db;

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            OpenMainPage();

        }

        private void OpenMainPage()
        {
            MainPage main = new MainPage();
            main.Show();
            this.Close();
        }

        private void SignUpPage_Load(object sender, EventArgs e)
        {
            btnUyeOl.BackColor = Color.FromArgb(248, 175, 86);
            db = new FitYourSelfContext();
        }

        private void btnGeriDon_Click_1(object sender, EventArgs e)
        {
            MainPage main = new MainPage();
            main.Show();
            this.Hide();
        }

        private void btnUyeOl_Click(object sender, EventArgs e)
        {


            if (MailDogrula(txtKayıtEmail.Text) && SifreKontrol(txtSifre.Text) && SifreDogrulama(txtSifre.Text, txtSifreTekrar.Text) && KullaniciAdiDogrulama(txtKullaniciAdi.Text))
            {
                MessageBox.Show("Üyelik Başarılı");
                UserInfo YeniKullanici = new UserInfo()
                {
                    UserName = txtKullaniciAdi.Text,
                    Email = txtKayıtEmail.Text,
                    Password = txtSifre.Text,

                };
                db.UserInfo.Add(YeniKullanici);
                db.SaveChanges();

            }
            //AYNI EMAILLE KAYIT OLUNMASI ENGELLENECEK!!!!!!!!!!
            // RASTGELE ŞİFRE EKLENECEK!!!!!!!!

            else
            {
                if (KullaniciAdiDogrulama(txtKullaniciAdi.Text) == false)
                    MessageBox.Show("Kullanıcı adı boş bırakılamaz.");

                if (MailDogrula(txtKayıtEmail.Text) == false)
                    MessageBox.Show("Girdiğiniz mail doğru biçimde değil.");

                if (SifreKontrol(txtSifre.Text) == false)
                    MessageBox.Show("Girdiğiniz şifre doğru biçimde değil.");

                if (SifreDogrulama(txtSifre.Text, txtSifreTekrar.Text) == false)
                    MessageBox.Show("Girdiğiniz şifreler aynı değil.");
            }

        }



        private bool KullaniciAdiDogrulama(string kullaniciAdi)
        {
            if (kullaniciAdi == null || kullaniciAdi == "")
                return false;
            else
                return true;
        }

        private bool SifreDogrulama(string sifre, string sifreTekrar)
        {
            if (sifre != sifreTekrar)
                return false;

            else
                return true;
        }



        public bool SifreKontrol(string sifre)
        {
            int totalCharacter = 0, totalLetterChar = 0, totalDigitChar = 0, totalSpecialChar = 0;
            foreach (var item in sifre.ToCharArray())
            {
                if (char.IsDigit(item))
                    totalDigitChar++;
                if (char.IsLetter(item))
                    totalLetterChar++;
                if (!char.IsLetterOrDigit(item))
                    totalSpecialChar++;
                totalCharacter++;
            }
            if (totalCharacter < 8 || totalDigitChar == 0 || totalLetterChar == 0 || totalSpecialChar == 0)
            {
                return false;
            }
            else
            {
                return true;
            }

        }


        public bool MailDogrula(string email)
        {
            return Regex.IsMatch(email, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show
               ("* Şifreniz en az 8 karakterli olmalıdır\n" +
                "* Şifreniz en az bir özel karakter içermelidir.\n" +
                "* Şifreniz en az bir büyük harf içermelidir\n" +
                "* Şifreniz en az bir sayı içermelidir", "Şifre Kuralları");
        }


               




    }

}


