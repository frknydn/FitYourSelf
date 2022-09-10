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
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
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
            AnaSayfa anaSayfa = new AnaSayfa();
            anaSayfa.Show();
            this.Hide();
        }
        private void AdjustButtonColors()
        {
            btnGirisYap.BackColor = Color.FromArgb(248, 175, 86);
        }      

        private void LoginPage_FormClosed(object sender, FormClosedEventArgs e)
        {
           Application.Exit();
        }

        private void LoginPage_Load_1(object sender, EventArgs e)
        {
            AdjustButtonColors();
        }
    }
}
