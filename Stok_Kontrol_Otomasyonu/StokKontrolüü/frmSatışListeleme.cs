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
    public partial class frmSatışListeleme : Form
    {
        public frmSatışListeleme()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-2MPQS5LI;Initial Catalog=Stok_Kontrol;Integrated Security=True");
        DataSet daset = new DataSet();
        private void satışlistele()
        {
            baglanti.Open();
            SqlDataAdapter adbtr = new SqlDataAdapter("select *from satis", baglanti);
            adbtr.Fill(daset, "satis");
            dataGridView1.DataSource = daset.Tables["satis"];

            baglanti.Close();
        }
        private void frmSatışListeleme_Load(object sender, EventArgs e)
        {
            satışlistele();
        }
    }
}
