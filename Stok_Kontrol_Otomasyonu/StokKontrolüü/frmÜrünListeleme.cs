using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StokKontrolüü
{
    public partial class frmÜrünListeleme : Form
    {
        public frmÜrünListeleme()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-2MPQS5LI;Initial Catalog=Stok_Kontrol;Integrated Security=True");
        DataSet daset = new DataSet();
        private void frmÜrünListeleme_Load(object sender, EventArgs e)
        {
            ÜrünListele();
        }

        private void ÜrünListele()
        {
            baglanti.Open();
            SqlDataAdapter adbtr = new SqlDataAdapter("select *from Ürün", baglanti);
            adbtr.Fill(daset, "Ürün");
            dataGridView1.DataSource = daset.Tables["Ürün"];
            baglanti.Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ÜrünBarkodNotxt.Text = dataGridView1.CurrentRow.Cells["Ürün_Barkod_No"].Value.ToString();
            ÜrünKategorisitxt.Text = dataGridView1.CurrentRow.Cells["Ürün_Kategorisi"].Value.ToString();
            ÜrünMarkasıtxt.Text = dataGridView1.CurrentRow.Cells["Ürün_Markası"].Value.ToString();
            ÜrünAdıtxt.Text = dataGridView1.CurrentRow.Cells["Ürün_Adı"].Value.ToString();
            ÜrünMiktarıtxt.Text = dataGridView1.CurrentRow.Cells["Ürün_Miktarı"].Value.ToString();
            ÜrünAlışFiyatıtxt.Text = dataGridView1.CurrentRow.Cells["Ürün_Alış_Fiyatı"].Value.ToString();
            ÜrünSatışFiyatıtxt.Text = dataGridView1.CurrentRow.Cells["Ürün_Satış_Fiyatı"].Value.ToString();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from Ürün where Ürün_Barkod_No='" + dataGridView1.CurrentRow.Cells["Ürün_Barkod_No"].Value.ToString() + "'", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            daset.Tables["Ürün"].Clear();
            ÜrünListele();
            MessageBox.Show("Kayıt Başarılı Bir Şekilde Silindi!");
        }

        private void txtÜrünAra_TextChanged(object sender, EventArgs e)
        {
            DataTable tablo = new DataTable();
            baglanti.Open();
            SqlDataAdapter adbtr = new SqlDataAdapter("select *from Ürün where Ürün_Adı like'%" + txtÜrünAra.Text + "%'", baglanti);
            adbtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
