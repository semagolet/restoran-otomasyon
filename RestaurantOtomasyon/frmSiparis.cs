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
    public partial class frmSiparis : Form
    {
        SqlDataReader dr;
        public int toplam = 0;
        
        public frmSiparis()
        {
            InitializeComponent();
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            Genel gnl = new Genel();

            using (SqlConnection sqlCon = new SqlConnection(gnl.conString))
            {
                sqlCon.Open();
                SqlCommand sqlCmd = new SqlCommand("hesapAdd", sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                for (int j = 0; j < lbHesap.Items.Count; j++)
                {
                    toplam += Convert.ToInt32(lbHesap.Items[j]);



                }
                sqlCmd.Parameters.AddWithValue("@MASAID", txtMasaID.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@TOPLAMTUTAR", toplam);
                sqlCmd.ExecuteNonQuery();
                lblHesap.Text = "Hesap : " + toplam + " TL";
                MessageBox.Show("Hesap " + txtMasaID.Text.Trim() + " numaralı masaya eklendi.");
                sqlCon.Close();
            }
        }

        private void btnSiparis_Click(object sender, EventArgs e)
        {
            Genel gnl = new Genel();
            frmMasalar masaHesap = new frmMasalar();

            using (SqlConnection sqlCon = new SqlConnection(gnl.conString))
            {


                sqlCon.Open();
                SqlCommand komboKutusu = new SqlCommand("select URUNAD , FIYAT from urunler", sqlCon);
                dr = komboKutusu.ExecuteReader();


                for (int i = 0; i < clbSiparis.CheckedItems.Count; i++)
                {
                    sqlCon.Close();
                    lbEklenenUrunler.Items.Add(clbSiparis.CheckedItems[i].ToString());


                }
                for (int i = 0; i < clbSiparis.CheckedItems.Count; i++)
                {
                    sqlCon.Open();

                    SqlCommand query = new SqlCommand("select URUNAD,FIYAT from urunler where URUNAD ='" + clbSiparis.CheckedItems[i] + "'", sqlCon);
                    dr = query.ExecuteReader();
                    while (dr.Read())
                    {
                        lbHesap.Items.Add(dr[1]);
                    }
                    sqlCon.Close();
                }


            }
        }

        private void frmSiparis_Load(object sender, EventArgs e)
        {
            Genel gnl = new Genel();
            using (SqlConnection sqlCon = new SqlConnection(gnl.conString))
            {


                clbSiparis.Items.Clear();
                sqlCon.Open();
                SqlCommand komboKutusu = new SqlCommand("select *from urunler", sqlCon);
                dr = komboKutusu.ExecuteReader();
                while (dr.Read())
                {


                    clbSiparis.Items.Add(dr[2]);

                }
                sqlCon.Close();





            }
        }
    }
}
