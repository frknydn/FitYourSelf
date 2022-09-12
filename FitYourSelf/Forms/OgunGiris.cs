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
    public partial class OgunGiris : Form
    {
        public OgunGiris()
        {
            InitializeComponent();
        }

        private void OgunGiris_Load(object sender, EventArgs e)
        {

            btnKaydet.BackColor = Color.FromArgb(248, 175, 86);
        }
    }
}
