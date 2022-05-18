using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantOtomasyon
{
    public partial class frmGiris : Form
    {
        Genel gnl = new Genel();
        public frmGiris()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            Personeller p = new Personeller();
            bool result = p.personelEntryControl(txtSifre.Text, gnl._personelId);

            if (result)
            {
                this.Hide();
                frmMenu menu = new frmMenu();
                menu.Show();
            }
        }

        private void frmGiris_Load(object sender, EventArgs e)
        {
            Personeller p = new Personeller();
            p.personelBilgisiniGetir(cbKullanici);
        }

        private void cbKullanici_SelectedIndexChanged(object sender, EventArgs e)
        {
            Personeller p = (Personeller)cbKullanici.SelectedItem;
            gnl._personelId = p.PersonelId;
            gnl._gorevId = p.PersonelGorevId;
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
