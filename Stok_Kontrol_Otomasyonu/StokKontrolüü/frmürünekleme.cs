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
    public partial class frmürünekleme : Form
    {
        public frmürünekleme()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-2MPQS5LI;Initial Catalog=Stok_Kontrol;Integrated Security=True");

        private void kategorigetir()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from KategoriBilgileri", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())

            {
                comboÜrünKategorisi.Items.Add(read["kategori"].ToString());
            }
            baglanti.Close();
        }
        private void frmürünekleme_Load(object sender, EventArgs e)
        {
            kategorigetir();
        }

        private void btnMevcutEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update Ürün set Ürün_Miktarı=Ürün_Miktarı+'"+int.Parse(ÜrünMiktarıtxt.Text)+"'where Ürün_Barkod_No='"+ÜrünBarkodNotxt.Text+"'",baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            foreach (Control item in groupBox2.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
            MessageBox.Show("Mevcut Olan Ürüne Ekleme Başarılı bir şekilde yapıldı.!");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboÜrünMarkası.Items.Clear();
            comboÜrünMarkası.Text = "";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from MarkaBilgileri where kategori='"+comboÜrünKategorisi.SelectedItem+"'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())

            {
                comboÜrünMarkası.Items.Add(read["marka"].ToString());
            }
            baglanti.Close();
        }

        private void btnYeniEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Ürün(Ürün_Barkod_No,Ürün_Kategorisi,Ürün_Markası,Ürün_Adı,Ürün_Miktarı,Ürün_Alış_Fiyatı,Ürün_Satış_Fiyatı,Tarih) values(@Ürün_Barkod_No,@Ürün_Kategorisi,@Ürün_Markası,@Ürün_Adı,@Ürün_Miktarı,@Ürün_Alış_Fiyatı,@Ürün_Satış_Fiyatı,@Tarih)",baglanti);
            komut.Parameters.AddWithValue("@Ürün_Barkod_No",txtÜrünBarkodNo.Text);
            komut.Parameters.AddWithValue("@Ürün_Kategorisi", comboÜrünKategorisi.Text);
            komut.Parameters.AddWithValue("@Ürün_Markası", comboÜrünMarkası.Text);
            komut.Parameters.AddWithValue("@Ürün_Adı", txtÜrünAdı.Text);
            komut.Parameters.AddWithValue("@Ürün_Miktarı",int.Parse(txtÜrünMiktarı.Text));
            komut.Parameters.AddWithValue("@Ürün_Alış_Fiyatı",double.Parse(txtÜrünAlışFiyatı.Text));
            komut.Parameters.AddWithValue("@Ürün_Satış_Fiyatı",double.Parse(txtÜrünSatışFiyatı.Text));
            komut.Parameters.AddWithValue("@Tarih", DateTime.Now.ToString());
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Ürün Başarılı Bir Şekilde Eklendi!");
            comboÜrünMarkası.Items.Clear();
            foreach(Control item in groupBox1.Controls)
            {
                if(item is TextBox)
                {
                    item.Text = "";
                }
                if(item is ComboBox)
                {
                    item.Text = "";
                }
            }

        }

        private void ÜrünBarkodNotxt_TextChanged(object sender, EventArgs e)
        {
            if (ÜrünBarkodNotxt.Text=="")
            {
                lblMiktari.Text = "";
                foreach (Control item in groupBox2.Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";
                    }
                }
            }
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from Ürün where Ürün_Barkod_No like '"+ÜrünBarkodNotxt.Text+ "' ", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read()) 
            {
                ÜrünKategorisitxt.Text = read["Ürün_Kategorisi"].ToString();
                ÜrünMarkasıtxt.Text = read["Ürün_Markası"].ToString();
                ÜrünAdıtxt.Text = read["Ürün_Adı"].ToString();
                lblMiktari.Text = read["Ürün_Miktarı"].ToString();
                ÜrünAlışFiyatıtxt.Text = read["Ürün_Alış_Fiyatı"].ToString();
                ÜrünSatışFiyatıtxt.Text = read["Ürün_Satış_Fiyatı"].ToString();
            }
            baglanti.Close();
            
        }

        private void ÜrünMiktarıtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
