using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace GÜZEL_OTOMASYON
{
    public partial class FrmSifreGüncelle : Form
    {
        public FrmSifreGüncelle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=LAPTOP-7ABFHQF9\SQLEXPRESS;Initial Catalog=GuzelPansiyon;Integrated Security=True");
        private void BtnGiris_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update AdminGiris set Kullanici='" + TxtKullaniciAdi.Text + "',Sifre='" + TxtSifre.Text + "'", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }
    }
}
