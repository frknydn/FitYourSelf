using FitYourSelf.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitYourSelf
{
    public  partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();           
        }

        
       
        private void AdjustButtonColors()
        {
            btnUyeOl.BackColor = Color.FromArgb(0, 146, 143);
            btnGirisYap.BackColor = Color.FromArgb(248, 175, 86);
        }

        private void OpenSignUpPage()
        {
            SignUpPage signUpPage = new SignUpPage();
            signUpPage.Show();
            this.Hide();
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            AdjustButtonColors();           
            
        }           

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Bu uygulamanın amacı cart curt");
        }

        private void btnUyeOl_Click(object sender, EventArgs e)
        {
            OpenSignUpPage();
        }

        private void btnGirisYap_Click_1(object sender, EventArgs e)
        {
            OpenLoginPage();
        }

        private void OpenLoginPage()
        {
            LoginPage loginPage = new LoginPage();
            loginPage.Show();
            this.Hide();
        }
    }
}
