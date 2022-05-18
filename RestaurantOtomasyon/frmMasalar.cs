using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantOtomasyon
{
    public partial class frmMasalar : Form
    {
        public frmMasalar()
        {
            InitializeComponent();
        }

        private void btnMasa1_Click(object sender, EventArgs e)
        {
            btnMasa1.BackColor = Color.Red;
            frmSiparis frm = new frmSiparis();
            frm.Show();
        }

        private void btnMasa2_Click(object sender, EventArgs e)
        {
            btnMasa2.BackColor = Color.Red;
            frmSiparis frm = new frmSiparis();
            frm.Show();
        }

        private void btnMasa3_Click(object sender, EventArgs e)
        {
            btnMasa3.BackColor = Color.Red;
            frmSiparis frm = new frmSiparis();
            frm.Show();
        }

        private void btnMasa4_Click(object sender, EventArgs e)
        {

            btnMasa4.BackColor = Color.Red;
            frmSiparis frm = new frmSiparis();
            frm.Show();
        }

        private void btnMasa5_Click(object sender, EventArgs e)
        {
            btnMasa5.BackColor = Color.Red;
            frmSiparis frm = new frmSiparis();
            frm.Show();
        }

        private void btnMasa6_Click(object sender, EventArgs e)
        {

            btnMasa6.BackColor = Color.Red;
            frmSiparis frm = new frmSiparis();
            frm.Show();
        }

        private void btnMasa7_Click(object sender, EventArgs e)
        {

            btnMasa7.BackColor = Color.Red;
            frmSiparis frm = new frmSiparis();
            frm.Show();
        }

        private void btnMasa8_Click(object sender, EventArgs e)
        {
            btnMasa8.BackColor = Color.Red;
            frmSiparis frm = new frmSiparis();
            frm.Show();
        }

        private void btnMasa9_Click(object sender, EventArgs e)
        {
            btnMasa9.BackColor = Color.Red;
            frmSiparis frm = new frmSiparis();
            frm.Show();
        }

        private void btnMasa10_Click(object sender, EventArgs e)
        {
            btnMasa10.BackColor = Color.Red;
            frmSiparis frm = new frmSiparis();
            frm.Show();
        }

        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
