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
    public partial class FrmOdalar : Form
    {
        public FrmOdalar()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-7ABFHQF9\\SQLEXPRESS;Initial Catalog=GuzelPansiyon;Integrated Security=True");

        private void BtnOda101_Click(object sender, EventArgs e)
        {

        }

        private void BtnOda208_Click(object sender, EventArgs e)
        {

        }

        private void FrmOdalar_Load(object sender, EventArgs e)
        {
            //ODA101
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("select * from Oda101", baglanti);
            SqlDataReader oku1 = komut1.ExecuteReader();

            while (oku1.Read())
            {
                BtnOda101.Text = oku1["Adı"].ToString() + " " + oku1["Soyadı"].ToString();
            }
            baglanti.Close();
            if (BtnOda101.Text != "101")
            {
                BtnOda101.BackColor = Color.Red;
            }
            //ODA102
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("select * from Oda102", baglanti);
            SqlDataReader oku2 = komut2.ExecuteReader();

            while (oku2.Read())
            {
                BtnOda102.Text = oku2["Adı"].ToString() + " " + oku2["Soyadı"].ToString();
            }
            baglanti.Close();
            if (BtnOda102.Text != "102")
            {
                BtnOda102.BackColor = Color.Red;
            }
            //ODA103
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("select * from Oda103", baglanti);
            SqlDataReader oku3 = komut3.ExecuteReader();

            while (oku3.Read())
            {
                BtnOda103.Text = oku3["Adı"].ToString() + " " + oku3["Soyadı"].ToString();
            }
            baglanti.Close();
            if (BtnOda103.Text != "103")
            {
                BtnOda103.BackColor = Color.Red;
            }
            //ODA104
            baglanti.Open();
            SqlCommand komut4 = new SqlCommand("select * from Oda104", baglanti);
            SqlDataReader oku4 = komut4.ExecuteReader();

            while (oku4.Read())
            {
                BtnOda104.Text = oku4["Adı"].ToString() + " " + oku4["Soyadı"].ToString();
            }
            baglanti.Close();
            if (BtnOda104.Text != "104")
            {
                BtnOda104.BackColor = Color.Red;
            }//ODA105
            baglanti.Open();
            SqlCommand komut5 = new SqlCommand("select * from Oda105", baglanti);
            SqlDataReader oku5 = komut5.ExecuteReader();

            while (oku5.Read())
            {
                BtnOda105.Text = oku5["Adı"].ToString() + " " + oku5["Soyadı"].ToString();
            }
            baglanti.Close();
            if (BtnOda105.Text != "105")
            {
                BtnOda105.BackColor = Color.Red;
            }
            //ODA106
            baglanti.Open();
            SqlCommand komut6 = new SqlCommand("select * from Oda106", baglanti);
            SqlDataReader oku6 = komut6.ExecuteReader();

            while (oku6.Read())
            {
                BtnOda106.Text = oku6["Adı"].ToString() + " " + oku6["Soyadı"].ToString();
            }
            baglanti.Close();
            if (BtnOda106.Text != "106")
            {
                BtnOda106.BackColor = Color.Red;
            }
            //ODA107
            baglanti.Open();
            SqlCommand komut7 = new SqlCommand("select * from Oda107", baglanti);
            SqlDataReader oku7 = komut7.ExecuteReader();

            while (oku7.Read())
            {
                BtnOda107.Text = oku7["Adı"].ToString() + " " + oku7["Soyadı"].ToString();
            }
            baglanti.Close();
            if (BtnOda107.Text != "107")
            {
                BtnOda107.BackColor = Color.Red;
            }
            //ODA108
            baglanti.Open();
            SqlCommand komut8 = new SqlCommand("select * from Oda108", baglanti);
            SqlDataReader oku8 = komut8.ExecuteReader();

            while (oku8.Read())
            {
                BtnOda108.Text = oku8["Adı"].ToString() + " " + oku8["Soyadı"].ToString();
            }
            baglanti.Close();
            if (BtnOda108.Text != "108")
            {
                BtnOda108.BackColor = Color.Red;
            }
            //ODA109
            baglanti.Open();
            SqlCommand komut9 = new SqlCommand("select * from Oda109", baglanti);
            SqlDataReader oku9 = komut9.ExecuteReader();

            while (oku9.Read())
            {
                BtnOda109.Text = oku9["Adı"].ToString() + " " + oku9["Soyadı"].ToString();
            }
            baglanti.Close();
            if (BtnOda109.Text != "109")
            {
                BtnOda109.BackColor = Color.Red;
            }



            //ODA201
            baglanti.Open();
            SqlCommand komut01 = new SqlCommand("select * from Oda201", baglanti);
            SqlDataReader oku01 = komut01.ExecuteReader();

            while (oku01.Read())
            {
                BtnOda201.Text = oku01["Adı"].ToString() + " " + oku01["Soyadı"].ToString();
            }
            baglanti.Close();
            if (BtnOda201.Text != "201")
            {
                BtnOda201.BackColor = Color.Red;
            }
            //ODA202
            baglanti.Open();
            SqlCommand komut02 = new SqlCommand("select * from Oda202", baglanti);
            SqlDataReader oku02 = komut02.ExecuteReader();

            while (oku02.Read())
            {
                BtnOda202.Text = oku02["Adı"].ToString() + " " + oku02["Soyadı"].ToString();
            }
            baglanti.Close();
            if (BtnOda202.Text != "202")
            {
                BtnOda202.BackColor = Color.Red;
            }
            //ODA203
            baglanti.Open();
            SqlCommand komut03 = new SqlCommand("select * from Oda203", baglanti);
            SqlDataReader oku03 = komut03.ExecuteReader();

            while (oku03.Read())
            {
                BtnOda203.Text = oku03["Adı"].ToString() + " " + oku03["Soyadı"].ToString();
            }
            baglanti.Close();
            if (BtnOda203.Text != "203")
            {
                BtnOda203.BackColor = Color.Red;
            }
            //ODA204
            baglanti.Open();
            SqlCommand komut04 = new SqlCommand("select * from Oda204", baglanti);
            SqlDataReader oku04 = komut03.ExecuteReader();

            while (oku04.Read())
            {
                BtnOda204.Text = oku04["Adı"].ToString() + " " + oku04["Soyadı"].ToString();
            }
            baglanti.Close();
            if (BtnOda204.Text != "204")
            {
                BtnOda204.BackColor = Color.Red;
            }
            //ODA205
            baglanti.Open();
            SqlCommand komut05 = new SqlCommand("select * from Oda205", baglanti);
            SqlDataReader oku05 = komut05.ExecuteReader();

            while (oku05.Read())
            {
                BtnOda205.Text = oku05["Adı"].ToString() + " " + oku05["Soyadı"].ToString();
            }
            baglanti.Close();
            if (BtnOda205.Text != "205")
            {
                BtnOda205.BackColor = Color.Red;
            }
            //ODA206
            baglanti.Open();
            SqlCommand komut06 = new SqlCommand("select * from Oda206", baglanti);
            SqlDataReader oku06 = komut06.ExecuteReader();

            while (oku06.Read())
            {
                BtnOda206.Text = oku06["Adı"].ToString() + " " + oku06["Soyadı"].ToString();
            }
            baglanti.Close();
            if (BtnOda206.Text != "206")
            {
                BtnOda206.BackColor = Color.Red;
            }
            //ODA207
            baglanti.Open();
            SqlCommand komut07 = new SqlCommand("select * from Oda207", baglanti);
            SqlDataReader oku07 = komut07.ExecuteReader();

            while (oku07.Read())
            {
                BtnOda207.Text = oku07["Adı"].ToString() + " " + oku07["Soyadı"].ToString();
            }
            baglanti.Close();
            if (BtnOda207.Text != "207")
            {
                BtnOda207.BackColor = Color.Red;
            }
            //ODA208
            baglanti.Open();
            SqlCommand komut08 = new SqlCommand("select * from Oda208", baglanti);
            SqlDataReader oku08 = komut08.ExecuteReader();

            while (oku08.Read())
            {
                BtnOda208.Text = oku08["Adı"].ToString() + " " + oku08["Soyadı"].ToString();
            }
            baglanti.Close();
            if (BtnOda208.Text != "208")
            {
                BtnOda208.BackColor = Color.Red;
            }
            //ODA209
            baglanti.Open();
            SqlCommand komut09 = new SqlCommand("select * from Oda209", baglanti);
            SqlDataReader oku09 = komut09.ExecuteReader();

            while (oku09.Read())
            {
                BtnOda209.Text = oku09["Adı"].ToString() + " " + oku09["Soyadı"].ToString();
            }
            baglanti.Close();
            if (BtnOda209.Text != "209")
            {
                BtnOda209.BackColor = Color.Red;
            }
        }
        private void BtnOda104_Click(object sender, EventArgs e)
        {

        }

        private void BtnOda201_Click(object sender, EventArgs e)
        {

        }

        private void BtnOda202_Click(object sender, EventArgs e)
        {

        }

        private void BtnOda208_Click_1(object sender, EventArgs e)
        {

        }

        private void BtnOda103_Click(object sender, EventArgs e)
        {

        }
    }
}
