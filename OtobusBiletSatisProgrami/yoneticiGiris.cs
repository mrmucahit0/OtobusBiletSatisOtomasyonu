using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtobusBiletSatisProgrami
{
    public partial class yoneticiGiris : Form
    {
        public yoneticiGiris()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            string ad, sifre;
            ad = yoneticiAd.Text;
            sifre=yoneticiSifre.Text;

            if( ad=="admin" && sifre=="admin0334") 
            {
                this.Hide();
                yoneticiForm f4 = new yoneticiForm();
                f4.Show();
            }
            else
            {
                MessageBox.Show("Yanlış Ad Yada Şifre");
            }
        }
    }
}
