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
using System.Security.Cryptography.X509Certificates;

namespace RestaurantOtomasyon
{
    public partial class frmUrun : Form
    {
        Genel gnl = new Genel();

        SqlDataReader dr;

        public frmUrun()
        {
            InitializeComponent();
        }



        public void frmUrun_Load(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(gnl.conString))
            {

                listView1.Items.Clear();
                sqlCon.Open();
                SqlCommand komboKutusu = new SqlCommand("select  k.KATEGORI , u.URUNAD , u.FIYAT from urunler u inner join kategoriler k on k.ID = u.KATEGORIID", sqlCon);
                dr = komboKutusu.ExecuteReader();
                while (dr.Read())
                {
                    ListViewItem item = new ListViewItem(dr["URUNAD"].ToString());
                    item.SubItems.Add(dr["FIYAT"].ToString() + " TL");
                    item.SubItems.Add(dr["KATEGORI"].ToString());
                    listView1.Items.Add(item);

                }
                sqlCon.Close();





            }
        }

        
        private void btnGeri_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(gnl.conString))
            {
                sqlCon.Open();
                SqlCommand sqlCmd = new SqlCommand("urunAdd", sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@KATEGORIID", txtKategori.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@URUNAD", txtUrunAdi.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@FIYAT", txtFiyat.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@DURUM", cbStok.Checked);

                sqlCmd.ExecuteNonQuery();
                MessageBox.Show("Ürün Eklendi");

            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(gnl.conString))
            {
                sqlCon.Open();
                string query = "Select * from urunler Where URUNAD = '" + txtUrunAdi.Text.Trim() + "'";

                SqlDataAdapter sda = new SqlDataAdapter(query, sqlCon);

                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);

                if (dtbl.Rows.Count == 1)
                {
                    SqlCommand sqlCmd = new SqlCommand("DELETE from urunler Where URUNAD = '" + txtUrunAdi.Text.Trim() + "'", sqlCon);
                    
                    sqlCmd.ExecuteNonQuery();
                    MessageBox.Show("Silme İşlemi Başarılı");
                    sqlCon.Close();

                }
                else
                {
                    MessageBox.Show("Hatali Giris");
                    sqlCon.Close();
                }
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            frmUrun urun = new frmUrun();
            Close();
            urun.Show();
            
            
        }

        
    }
}
