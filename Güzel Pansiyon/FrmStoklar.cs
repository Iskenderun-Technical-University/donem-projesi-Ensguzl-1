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
    public partial class FrmStoklar : Form
    {
        public FrmStoklar()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=LAPTOP-7ABFHQF9\SQLEXPRESS;Initial Catalog=GuzelPansiyon;Integrated Security=True");
        private void Veriler()
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Stoklar", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Gida"].ToString();
                ekle.SubItems.Add(oku["İcecek"].ToString());
                ekle.SubItems.Add(oku["Cerezler"].ToString());
                listView1.Items.Add(ekle);
            }
            baglanti.Close();

        }
        private void Veriler2()
        {
            listView2.Items.Clear();
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("select * from Faturalar", baglanti);
            SqlDataReader oku1 = komut1.ExecuteReader();
            while (oku1.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku1["Elektrik"].ToString();
                ekle.SubItems.Add(oku1["Su"].ToString());
                ekle.SubItems.Add(oku1["İnternet"].ToString());
                listView2.Items.Add(ekle);
            }
            baglanti.Close();

        }
        private void BtnKaydet_Click(object sender, EventArgs e)
        {
           
        }

        private void FrmStoklar_Load(object sender, EventArgs e)
        {
            Veriler();
            Veriler2();
        }

        private void BtnKaydet2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("insert into Faturalar ( Elektrik,Su,İnternet ) values ( '" + TxtElektrik.Text + "','" + TxtSu.Text + "','" + Txtİnternet.Text + "')", baglanti);
            komut1.ExecuteNonQuery();
            baglanti.Close();
            Veriler2();
        }

        private void BtnKaydet1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Stoklar ( Gida,İcecek,Cerezler ) values ( '" + TxtGıdalar.Text + "','" + Txtİcecekler.Text + "','" + TxtCerezler.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            Veriler();
        }
    }
}
