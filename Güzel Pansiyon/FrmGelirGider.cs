﻿using System;
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
    public partial class FrmGelirGider : Form
    {
        public FrmGelirGider()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=LAPTOP-7ABFHQF9\SQLEXPRESS;Initial Catalog=GuzelPansiyon;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            int personel;
            personel = Convert.ToInt16(textBox1.Text);
            LblPersonelMaas.Text = (personel * 10000).ToString();

            int sonuc;
            sonuc = Convert.ToInt32(LblKasadakiToplamtutar.Text) - (Convert.ToInt32(LblPersonelMaas.Text) + Convert.ToInt32(LblAlınanUrunToplam1.Text) + Convert.ToInt32(LblAlınanUrunToplam2.Text) + Convert.ToInt32(LblAlınanUrunToplam3.Text) + Convert.ToInt32(LblFaturalar1.Text) + Convert.ToInt32(LblFaturalar2.Text) + Convert.ToInt32(LblFaturalar3.Text));
            LblSonuc.Text = sonuc.ToString();
        }

        private void FrmGelirGider_Load(object sender, EventArgs e)
        {
            //Kasada ki toplam tutar
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select sum(Ucret) as toplam from MusteriEkle", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                LblKasadakiToplamtutar.Text = oku["toplam"].ToString();
            }
            baglanti.Close();

            //Gidalar
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("select sum(Gida) as toplam1 from Stoklar", baglanti);
            SqlDataReader oku1 = komut1.ExecuteReader();
            while (oku1.Read())
            {
                LblAlınanUrunToplam1.Text = oku1["toplam1"].ToString();
            }
            baglanti.Close();


            //İçecekler
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("select sum(İcecek) as toplam2 from Stoklar", baglanti);
            SqlDataReader oku2 = komut2.ExecuteReader();
            while (oku2.Read())
            {
                LblAlınanUrunToplam2.Text = oku2["toplam2"].ToString();
            }
            baglanti.Close();

            //Cerezler
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("select sum(Cerezler) as toplam3 from Stoklar", baglanti);
            SqlDataReader oku3 = komut3.ExecuteReader();
            while (oku3.Read())
            {
                LblAlınanUrunToplam3.Text = oku3["toplam3"].ToString();
            }
            baglanti.Close();

            //Elektrik
            baglanti.Open();
            SqlCommand komut4 = new SqlCommand("select sum(Elektrik) as toplam4 from Faturalar", baglanti);
            SqlDataReader oku4 = komut4.ExecuteReader();
            while (oku4.Read())
            {
                LblFaturalar1.Text = oku4["toplam4"].ToString();
            }
            baglanti.Close();

            //Su
            baglanti.Open();
            SqlCommand komut5 = new SqlCommand("select sum(Su) as toplam5 from Faturalar", baglanti);
            SqlDataReader oku5 = komut5.ExecuteReader();
            while (oku5.Read())
            {
                LblFaturalar2.Text = oku5["toplam5"].ToString();
            }
            baglanti.Close();

            //İnternet
            baglanti.Open();
            SqlCommand komut6 = new SqlCommand("select sum(İnternet) as toplam6 from Faturalar", baglanti);
            SqlDataReader oku6 = komut6.ExecuteReader();
            while (oku6.Read())
            {
                LblFaturalar3.Text = oku6["toplam6"].ToString();
            }
            baglanti.Close();

        }
    }
}
