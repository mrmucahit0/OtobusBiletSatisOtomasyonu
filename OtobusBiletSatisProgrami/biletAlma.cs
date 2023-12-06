using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Permissions;

namespace OtobusBiletSatisProgrami
{
    public partial class biletAlma : Form
    {
        SqlConnection baglanti;
        SqlDataAdapter da;
        SqlCommand komut;
        public biletAlma()
        {
            
            InitializeComponent();
        }
        void doldur()
        {

            baglanti = new SqlConnection("Data Source=.; Initial Catalog=otobusBilet; User ID=sa; Password=123456"); //server 
            //Data Source = Server; Initial Catalog = Veritabani; Integrated Security = True; windows aut
            baglanti.Open();
            da = new SqlDataAdapter("select * from kisiBilgi", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgveri.DataSource = dt;
            baglanti.Close();
        }
        private void biletAlma_Load(object sender, EventArgs e)
        {
            doldur();
        }
       

        private void biletAlBTN_Click(object sender, EventArgs e)
        {
            

            if (string.IsNullOrEmpty(biletAdSoyad.Text) && string.IsNullOrEmpty(biletTelNo.Text))
            { MessageBox.Show("ad ve Soyad alanlarını lütfen doldurunuz.."); }
            else
            {
                
                string sorgu = "insert into kisiBilgi(adSoyad,telNo,ePosta,kalkisYeri,varisYeri) values(@adSoyad,@telNo,@ePosta,@kalkisYeri,@varisYeri)";
                baglanti.Open();
                komut = new SqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@adSoyad", biletAdSoyad.Text);
                komut.Parameters.AddWithValue("@telNo", biletTelNo.Text);
                komut.Parameters.AddWithValue("@ePosta", biletEposta.Text);
                komut.Parameters.AddWithValue("@kalkisYeri", biletBinisYeri.Text);
                komut.Parameters.AddWithValue("@varisYeri", biletİnisYeri.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();
                doldur();
            }


            /*
            this.Close();
            anaForm anaForm = new anaForm();
            anaForm.Show();  */
        }

        
        
        private void otobusTipi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(otobusTipi.Text=="2+1")
            {
                koltukSayisi.Items.Clear();
                koltukSayisi.Items.Add("1 ( ikili )");
                koltukSayisi.Items.Add("2 ( ikili )");
                koltukSayisi.Items.Add("3 ( ikili )");
                koltukSayisi.Items.Add("4 ( ikili )");
                koltukSayisi.Items.Add("5 ( ikili )");
                koltukSayisi.Items.Add("6 ( ikili )");
                koltukSayisi.Items.Add("7 ( ikili )");
                koltukSayisi.Items.Add("8 ( ikili )");
                koltukSayisi.Items.Add("9 ( ikili )");
                koltukSayisi.Items.Add("10 ( ikili )");
                koltukSayisi.Items.Add("11 ( ikili )");
                koltukSayisi.Items.Add("12 ( ikili )");
                koltukSayisi.Items.Add("13 ( ikili )");
                koltukSayisi.Items.Add("14 ( ikili )");
                koltukSayisi.Items.Add("15 ( ikili )");
                koltukSayisi.Items.Add("16 ( ikili )");
                koltukSayisi.Items.Add("17 ( ikili )");
                koltukSayisi.Items.Add("18 ( ikili )");
                koltukSayisi.Items.Add("19 ( ikili )");
                koltukSayisi.Items.Add("20 ( ikili )");
    
                koltukSayisi.Items.Add("1 ( Tekli )");
                koltukSayisi.Items.Add("2 ( Tekli )");
                koltukSayisi.Items.Add("3 ( Tekli )");
                koltukSayisi.Items.Add("4 ( Tekli )");
                koltukSayisi.Items.Add("5 ( Tekli )");
                koltukSayisi.Items.Add("6 ( Tekli )");
                koltukSayisi.Items.Add("7 ( Tekli )");
                koltukSayisi.Items.Add("8 ( Tekli )");
                koltukSayisi.Items.Add("9 ( Tekli )");
                koltukSayisi.Items.Add("10 ( Tekli )");
            }
            else if(otobusTipi.Text=="2+2")
            {
                koltukSayisi.Items.Clear();
                koltukSayisi.Items.Add("1 ( ikili )");
                koltukSayisi.Items.Add("2 ( ikili )");
                koltukSayisi.Items.Add("3 ( ikili )");
                koltukSayisi.Items.Add("4 ( ikili )");
                koltukSayisi.Items.Add("5 ( ikili )");
                koltukSayisi.Items.Add("6 ( ikili )");
                koltukSayisi.Items.Add("7 ( ikili )");
                koltukSayisi.Items.Add("8 ( ikili )");
                koltukSayisi.Items.Add("9 ( ikili )");
                koltukSayisi.Items.Add("10 ( ikili )");
                koltukSayisi.Items.Add("11 ( ikili )");
                koltukSayisi.Items.Add("12 ( ikili )");
                koltukSayisi.Items.Add("13 ( ikili )");
                koltukSayisi.Items.Add("14 ( ikili )");
                koltukSayisi.Items.Add("15 ( ikili )");
                koltukSayisi.Items.Add("16 ( ikili )");
                koltukSayisi.Items.Add("17 ( ikili )");
                koltukSayisi.Items.Add("18 ( ikili )");
                koltukSayisi.Items.Add("19 ( ikili )");
                koltukSayisi.Items.Add("20 ( ikili )");
                koltukSayisi.Items.Add("21 ( ikili )");
                koltukSayisi.Items.Add("22 ( ikili )");
                koltukSayisi.Items.Add("23 ( ikili )");
                koltukSayisi.Items.Add("24 ( ikili )");
                koltukSayisi.Items.Add("25 ( ikili )");
                koltukSayisi.Items.Add("26 ( ikili )");
                koltukSayisi.Items.Add("27 ( ikili )");
                koltukSayisi.Items.Add("28 ( ikili )");
                koltukSayisi.Items.Add("29 ( ikili )");
                koltukSayisi.Items.Add("30 ( ikili )");
                koltukSayisi.Items.Add("31 ( ikili )");
                koltukSayisi.Items.Add("32 ( ikili )");
                koltukSayisi.Items.Add("33 ( ikili )");
                koltukSayisi.Items.Add("34 ( ikili )");
                koltukSayisi.Items.Add("35 ( ikili )");
                koltukSayisi.Items.Add("36 ( ikili )");
                koltukSayisi.Items.Add("37 ( ikili )");
                koltukSayisi.Items.Add("38 ( ikili )");
                koltukSayisi.Items.Add("39 ( ikili )");
                koltukSayisi.Items.Add("40 ( ikili )");
            }
        }

        
    }
}
