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
    public partial class frmHesapOde : Form
    {
        SqlDataReader dr;
        public frmHesapOde()
        {
            InitializeComponent();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            frmHesapOde hesap = new frmHesapOde();
            Close();
            hesap.Show();
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnHesapAl_Click(object sender, EventArgs e)
        {
            Genel gnl = new Genel();
            using (SqlConnection sqlCon = new SqlConnection(gnl.conString))
            {
                sqlCon.Open();
                SqlCommand sqlCmd = new SqlCommand("DELETE from hesapOdemeleri where MASAID = " + txtMasaNumara.Text.Trim(), sqlCon);



                sqlCmd.ExecuteNonQuery();
                MessageBox.Show("Hesap Alındı");

                sqlCon.Close();
            }
        }

        private void frmHesapOde_Load(object sender, EventArgs e)
        {
            Genel gnl = new Genel();
            using (SqlConnection sqlCon = new SqlConnection(gnl.conString))
            {

                listView1.Items.Clear();
                sqlCon.Open();
                SqlCommand komboKutusu = new SqlCommand("select MASAID,TOPLAMTUTAR  from hesapOdemeleri", sqlCon);
                dr = komboKutusu.ExecuteReader();
                while (dr.Read())
                {
                    ListViewItem item = new ListViewItem(dr["MASAID"].ToString());
                    item.SubItems.Add(dr["TOPLAMTUTAR"].ToString() + " TL");

                    listView1.Items.Add(item);

                }
                sqlCon.Close();
            }
        }
    }
}
