﻿using FitYorSelf.Entities.Concrete;
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
    }
}
