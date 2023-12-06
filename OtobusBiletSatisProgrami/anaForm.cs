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

namespace OtobusBiletSatisProgrami
{
    public partial class anaForm : Form
    {
        public anaForm()
        {
            InitializeComponent();
        }

        private void biletAlmaBTN_Click(object sender, EventArgs e)
        {
            this.Hide();
            biletAlma f5 = new biletAlma();
            f5.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            yoneticiGiris yoneticiGiris = new yoneticiGiris();
            yoneticiGiris.Show();
        }

        private void anaForm_Load(object sender, EventArgs e)
        {

        }
    }
}
