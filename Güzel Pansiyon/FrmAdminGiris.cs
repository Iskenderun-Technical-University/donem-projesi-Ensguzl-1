
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace GÜZEL_OTOMASYON
{
    public partial class FrmAdminGiris : Form
    {
        public FrmAdminGiris()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-7ABFHQF9\\SQLEXPRESS;Initial Catalog=GuzelPansiyon;Integrated Security=True");
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void BtnGiris_Click(object sender, EventArgs e)
        {
            
                baglanti.Open();
                string Sql = " select * from AdminGiris where Kullanici=@kullaniciadi AND Sifre = @Sifresi";
                SqlParameter prm1 = new SqlParameter("kullaniciadi", TxtKullaniciAdi.Text.Trim());
                SqlParameter prm2 = new SqlParameter("Sifresi", TxtSifre.Text.Trim());
                SqlCommand komut = new SqlCommand(Sql,baglanti);
                komut.Parameters.Add(prm1);
                komut.Parameters.Add(prm2);

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(komut);

                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    FrmAnaForm fr = new FrmAnaForm();
                    fr.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Hatalı Giriş");
                }
                baglanti.Close();
            
        }
    }
}