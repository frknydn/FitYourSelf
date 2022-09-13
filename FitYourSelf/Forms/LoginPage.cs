using FitYorSelf.Entities.Concrete;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace FitYourSelf.Forms
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        FitYourSelfContext db;
        private void LoginPage_Load_1(object sender, EventArgs e)
        {
            AdjustButtonColors();
            db = new FitYourSelfContext();
            txtGirisSifre.Text = "Şifre";
            txtGirisSifre.UseSystemPasswordChar = false;

        }
        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            OpenMainPage();
        }

        private void OpenMainPage()
        {
            MainPage main = new MainPage();
            main.Show();
            this.Hide();
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {

            var emailKontrol = db.UserInfo.Where(x => x.Email == txtGirisEmail.Text).FirstOrDefault();
            var sifreKontrol = db.UserInfo.Where(x => x.Password == txtGirisSifre.Text).FirstOrDefault();

            if (emailKontrol != null)
            {
                if (emailKontrol.Password == txtGirisSifre.Text)
                {
                    MessageBox.Show("Giriş başarılı");
                    AnaSayfa anaSayfa = new AnaSayfa();
                    anaSayfa.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Uyuşmuyor");
                }



            }
            else            
                MessageBox.Show("Kayıtlı kullanıcı bulunamadı");       
            
           
            
        }

        private void AdjustButtonColors()
        {
            btnGirisYap.BackColor = Color.FromArgb(248, 175, 86);
        }

        private void LoginPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void txtGirisSifre_TextChanged(object sender, EventArgs e)
        {

            txtGirisSifre.UseSystemPasswordChar = true;
        }

        private void txtGirisSifre_MouseClick(object sender, MouseEventArgs e)
        {
            txtGirisSifre.Clear();
        }

        private void txtGirisEmail_MouseClick(object sender, MouseEventArgs e)
        {
            txtGirisEmail.Clear();
        }
    }

   
}

