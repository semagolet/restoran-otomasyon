using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace RestaurantOtomasyon
{
    public partial class frmMenu : Form
    {
        SqlDataReader dr;
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnUrunler_Click(object sender, EventArgs e)
        {
            Genel gnl = new Genel();
            frmUrun urunSayfasi = new frmUrun();
            urunSayfasi.Show();


          
        }

        private void btnMasalar_Click(object sender, EventArgs e)
        {
            frmMasalar masalar = new frmMasalar();
            masalar.Show();
        }

        private void btnSiparis_Click(object sender, EventArgs e)
        {
            frmSiparis siparis = new frmSiparis();
            siparis.Show();
        }

        private void btnHesaplar_Click(object sender, EventArgs e)
        {
            frmHesapOde hesaplar = new frmHesapOde();
            hesaplar.Show();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
