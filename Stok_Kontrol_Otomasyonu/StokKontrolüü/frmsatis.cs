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
    public partial class frmsatis : Form
    {
        public frmsatis()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-2MPQS5LI;Initial Catalog=Stok_Kontrol;Integrated Security=True");
        DataSet daset = new DataSet();
        private void sepetlistele()
        {
            baglanti.Open();
            SqlDataAdapter adbtr = new SqlDataAdapter("select *from sepet", baglanti);
            adbtr.Fill(daset, "sepet");
            dataGridView1.DataSource = daset.Tables["sepet"];
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].Visible = false;
            baglanti.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            sepetlistele();
        }

        private void txtAdSoyad_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmMüşteriEkleme ekleme = new frmMüşteriEkleme();
            ekleme.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmMüşteriListeleme listeleme = new frmMüşteriListeleme();
            listeleme.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            frmürünekleme ekle = new frmürünekleme();
            ekle.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmKategori kategori = new frmKategori();
            kategori.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmMarka marka = new frmMarka();
            marka.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            frmÜrünListeleme listele = new frmÜrünListeleme();
            listele.ShowDialog();
        }
        private void hesapla()
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("select sum(ToplamFiyati) from sepet",baglanti);
                lblgt.Text = komut.ExecuteScalar() + "TL";
                baglanti.Close();

            }
            catch (Exception)
            {

                ;
            }
        }
        private void txtTc_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBarkodNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTc_TextChanged_1(object sender, EventArgs e)
        {
            if (txtTc.Text=="")
            {
                txtAdSoyad.Text = "";
                txtTelefon.Text = "";
            }
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from müşteri where tc like '"+txtTc.Text+"'",baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                txtAdSoyad.Text = read["adsoyad"].ToString();
                txtTelefon.Text = read["telefon"].ToString();
            }
            baglanti.Close();
        }

        private void txtBarkodNo_TextChanged_1(object sender, EventArgs e)
        {
            Temizle();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from Ürün where Ürün_Barkod_No like '" + txtBarkodNo.Text + "'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                txtÜrünAdı.Text = read["Ürün_Adı"].ToString();
                txtSatışFiyatı.Text = read["Ürün_Satış_Fiyatı"].ToString();
            }
            baglanti.Close();
        }

        private void Temizle()
        {
            if (txtBarkodNo.Text == "")
            {
                foreach (Control item in groupBox2.Controls)
                {
                    if (item is TextBox)
                    {
                        if (item != txtÜrünMiktarı)
                        {
                            item.Text = "";
                        }
                    }

                }
            }
        }
        bool durum;
        private void barkodkontrol()
        {
            durum = true;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from sepet",baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                if (txtBarkodNo.Text==read["BarkodNo"].ToString())
                {
                    durum = false;
                }
            }
            baglanti.Close();
        }
        private void btnEkleme_Click(object sender, EventArgs e)
        {
            barkodkontrol();
            if (durum==true)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into sepet(AdSoyad,TC,Telefon,BarkodNo,ÜrünAdı,Ürünmiktari,SatışFiyati,ToplamFiyati,Tarih) values(@AdSoyad,@TC,@Telefon,@BarkodNo,@ÜrünAdı,@Ürünmiktari,@SatışFiyati,@ToplamFiyati,@Tarih)", baglanti);
                komut.Parameters.AddWithValue("@AdSoyad", txtAdSoyad.Text);
                komut.Parameters.AddWithValue("@TC", txtTc.Text);
                komut.Parameters.AddWithValue("@Telefon", txtTelefon.Text);
                komut.Parameters.AddWithValue("@BarkodNo", txtBarkodNo.Text);
                komut.Parameters.AddWithValue("@ÜrünAdı", txtÜrünAdı.Text);
                komut.Parameters.AddWithValue("@ÜrünMiktari", int.Parse(txtÜrünMiktarı.Text));
                komut.Parameters.AddWithValue("@SatışFiyati", double.Parse(txtSatışFiyatı.Text));
                komut.Parameters.AddWithValue("@ToplamFiyati", double.Parse(txtToplamFiyat.Text));
                komut.Parameters.AddWithValue("@Tarih", DateTime.Now.ToString());
                komut.ExecuteNonQuery();
                baglanti.Close();
            }
            else
            {
                baglanti.Open();
                SqlCommand komut2 = new SqlCommand("update sepet Ürünmiktari=Ürünmiktari+'"+int.Parse(txtÜrünMiktarı.Text)+ "'where BarkodNo='" + txtBarkodNo.Text + "'", baglanti);
                komut2.ExecuteNonQuery();
                SqlCommand komut3 = new SqlCommand("update sepet ToplamFiyati=Ürünmiktari*SatışFiyati where BarkodNo='"+txtBarkodNo.Text+"'", baglanti);
               
                komut3.ExecuteNonQuery();
                baglanti.Close();
            }
             txtÜrünMiktarı.Text = "1";
            daset.Tables["sepet"].Clear();
            sepetlistele();
            hesapla();
            foreach (Control item in groupBox2.Controls)
            {
                if (item is TextBox)
                {
                    if (item != txtÜrünMiktarı)
                    {
                        item.Text = "";
                    }
                }

            }
        }

        private void txtÜrünMiktarı_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtToplamFiyat.Text = (double.Parse(txtÜrünMiktarı.Text) * double.Parse(txtSatışFiyatı.Text)).ToString();
            }
            catch (Exception)
            {

                ; 
            }
        }

        private void txtSatışFiyatı_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtToplamFiyat.Text = (double.Parse(txtÜrünMiktarı.Text) * double.Parse(txtSatışFiyatı.Text)).ToString();
            }
            catch (Exception)
            {

                ;
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from sepet where BarkodNo='"+dataGridView1.CurrentRow.Cells["BarkodNo"].Value.ToString()+"'",baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Ürün Sepetten Başarılı Bir Şekilde Silindi!");
            daset.Tables["sepet"].Clear();
            sepetlistele();
            hesapla();
        }

        private void btnSatışıİptalEt_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from sepet", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Ürün Satışı İptal Edildi!");
            daset.Tables["sepet"].Clear();
            sepetlistele();
            hesapla();


        }

        private void button9_Click(object sender, EventArgs e)
        {
            frmSatışListeleme listele = new frmSatışListeleme();
            listele.ShowDialog();

        }

        private void btnSatışYap_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count-1; i++)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into satis(adsoyad,tc,telefon,barkodno,urunadi,urunmiktari,satisfiyati,toplamfiyati,tarih) values(@adsoyad,@tc,@telefon,@barkodno,@urunadi,@urunmiktari,@satisfiyati,@toplamfiyati,@tarih)", baglanti);
                komut.Parameters.AddWithValue("@adsoyad", txtAdSoyad.Text);
                komut.Parameters.AddWithValue("@tc", txtTc.Text);
                komut.Parameters.AddWithValue("@telefon", txtTelefon.Text);
                komut.Parameters.AddWithValue("@barkodno", dataGridView1.Rows[i].Cells["BarkodNo"].Value.ToString());
                komut.Parameters.AddWithValue("@urunadi", dataGridView1.Rows[i].Cells["Ürünadı"].Value.ToString());
                komut.Parameters.AddWithValue("@urunmiktari", int.Parse(dataGridView1.Rows[i].Cells["Ürünmiktari"].Value.ToString()));
                komut.Parameters.AddWithValue("@satisfiyati", double.Parse(dataGridView1.Rows[i].Cells["SatışFiyati"].Value.ToString()));
                komut.Parameters.AddWithValue("@toplamfiyati", double.Parse(dataGridView1.Rows[i].Cells["ToplamFiyati"].Value.ToString()));
                komut.Parameters.AddWithValue("@tarih", DateTime.Now.ToString());
                komut.ExecuteNonQuery();
                SqlCommand komut2 = new SqlCommand("update Ürün set Ürün Miktarı=Ürün Miktarı-'" + int.Parse(dataGridView1.Rows[i].Cells["Ürünmiktari"].Value.ToString()) + "'where Ürün Barkod No='" + dataGridView1.Rows[i].Cells["BarkodNo"].Value.ToString() + "'", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                
                
                
            }
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("delete from sepet", baglanti);
            komut3.ExecuteNonQuery();
            baglanti.Close();
            daset.Tables["sepet"].Clear();
            sepetlistele();
            hesapla();
        }
    }
}
