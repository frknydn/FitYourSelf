﻿using FitYorSelf.Entities.Concrete;
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
    public partial class TarifEkle : Form
    {
        public TarifEkle()
        {
            InitializeComponent();

        }


        FitYourSelfContext db;
        Recipies recipies;
        private void TarifEkle_Load(object sender, EventArgs e)
        {
            db = new FitYourSelfContext();

        }


        private void btnKaydet_Click(object sender, EventArgs e)
        {
            recipies = new Recipies()
            {
                RecipiesName = txtTarifBasligi.Text,
                RecipeIngredients = txtTarifMalzemeler.Text,
                RecipeDetail = txtTarifHazirlanis.Text,
                UserInfoID = LoginPage.id
            };
            db.Recipies.Add(recipies);
            db.SaveChanges();

            MessageBox.Show("Eklendi");
            txtTarifBasligi.Clear();
            txtTarifMalzemeler.Clear();
            txtTarifHazirlanis.Clear();
        }

        private void TarifEkle_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
            AnaSayfa.anaSayfa.Show();
        }
    }
}
