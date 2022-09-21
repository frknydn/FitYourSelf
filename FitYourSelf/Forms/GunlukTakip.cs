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
    public partial class GunlukTakip : Form
    {
        public GunlukTakip()
        {
            InitializeComponent();
        }

        FitYourSelfContext db;
        private void GunlukTakip_Load(object sender, EventArgs e)
        {
            db = new FitYourSelfContext();

        }
    }
}
