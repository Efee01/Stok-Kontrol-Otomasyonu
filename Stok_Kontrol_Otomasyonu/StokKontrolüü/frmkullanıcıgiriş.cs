using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StokKontrolüü
{
    public partial class frmkullanıcıgiriş : Form
    {
        public frmkullanıcıgiriş()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmkullanıcıgiriş_Load(object sender, EventArgs e)
        {

        }

        private void sifre_Click(object sender, EventArgs e)
        {
            sifre.Text="";
        }

        private void kullanici_Click(object sender, EventArgs e)
        {
            kullanici.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (kullanici.Text=="" || sifre.Text=="")
            {
                MessageBox.Show("Kullanıcı adı veya şifre boş olamaz!","Dikkat!");
            }
            else
            {
                if (kullanici.Text=="admin" && sifre.Text=="123" ||kullanici.Text=="efe" && sifre.Text=="123")
                {
                    frmsatis frm = new frmsatis();
                    frm.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("kullanıcı Adı ya da Şifre yanlış!", "Dikkat!");
                }
            }
        }
    }
}
