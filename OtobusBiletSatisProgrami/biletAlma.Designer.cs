namespace OtobusBiletSatisProgrami
{
    partial class biletAlma
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.biletAdSoyad = new System.Windows.Forms.TextBox();
            this.biletTelNo = new System.Windows.Forms.TextBox();
            this.biletEposta = new System.Windows.Forms.TextBox();
            this.biletİnisYeri = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.biletBinisYeri = new System.Windows.Forms.ComboBox();
            this.biletCCisim = new System.Windows.Forms.TextBox();
            this.biletCCkartNum = new System.Windows.Forms.TextBox();
            this.biletCCccv = new System.Windows.Forms.TextBox();
            this.biletSKKcc = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.biletAlBTN = new System.Windows.Forms.Button();
            this.otobusTipi = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.koltukSayisi = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.odemeNakit = new System.Windows.Forms.RadioButton();
            this.odemeKart = new System.Windows.Forms.RadioButton();
            this.dgveri = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgveri)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad Soyad :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tel No :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "e-Posta :";
            // 
            // biletAdSoyad
            // 
            this.biletAdSoyad.Location = new System.Drawing.Point(93, 22);
            this.biletAdSoyad.Name = "biletAdSoyad";
            this.biletAdSoyad.Size = new System.Drawing.Size(100, 20);
            this.biletAdSoyad.TabIndex = 3;
            // 
            // biletTelNo
            // 
            this.biletTelNo.Location = new System.Drawing.Point(93, 48);
            this.biletTelNo.Name = "biletTelNo";
            this.biletTelNo.Size = new System.Drawing.Size(100, 20);
            this.biletTelNo.TabIndex = 4;
            // 
            // biletEposta
            // 
            this.biletEposta.Location = new System.Drawing.Point(93, 77);
            this.biletEposta.Name = "biletEposta";
            this.biletEposta.Size = new System.Drawing.Size(100, 20);
            this.biletEposta.TabIndex = 5;
            // 
            // biletİnisYeri
            // 
            this.biletİnisYeri.FormattingEnabled = true;
            this.biletİnisYeri.Items.AddRange(new object[] {
            "İstanbul",
            "Ankara",
            "Antalya",
            "İzmir",
            "Afyonkarahisar",
            "Edirne"});
            this.biletİnisYeri.Location = new System.Drawing.Point(93, 188);
            this.biletİnisYeri.Name = "biletİnisYeri";
            this.biletİnisYeri.Size = new System.Drawing.Size(121, 21);
            this.biletİnisYeri.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "İniş Yeri :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Biniş Yeri :";
            // 
            // biletBinisYeri
            // 
            this.biletBinisYeri.FormattingEnabled = true;
            this.biletBinisYeri.Items.AddRange(new object[] {
            "İstanbul",
            "Ankara",
            "Antalya",
            "İzmir",
            "Afyonkarahisar",
            "Edirne"});
            this.biletBinisYeri.Location = new System.Drawing.Point(93, 161);
            this.biletBinisYeri.Name = "biletBinisYeri";
            this.biletBinisYeri.Size = new System.Drawing.Size(121, 21);
            this.biletBinisYeri.TabIndex = 8;
            // 
            // biletCCisim
            // 
            this.biletCCisim.Location = new System.Drawing.Point(559, 17);
            this.biletCCisim.Name = "biletCCisim";
            this.biletCCisim.Size = new System.Drawing.Size(100, 20);
            this.biletCCisim.TabIndex = 10;
            // 
            // biletCCkartNum
            // 
            this.biletCCkartNum.Location = new System.Drawing.Point(559, 44);
            this.biletCCkartNum.Name = "biletCCkartNum";
            this.biletCCkartNum.Size = new System.Drawing.Size(100, 20);
            this.biletCCkartNum.TabIndex = 11;
            // 
            // biletCCccv
            // 
            this.biletCCccv.Location = new System.Drawing.Point(559, 79);
            this.biletCCccv.Name = "biletCCccv";
            this.biletCCccv.Size = new System.Drawing.Size(100, 20);
            this.biletCCccv.TabIndex = 12;
            // 
            // biletSKKcc
            // 
            this.biletSKKcc.Location = new System.Drawing.Point(539, 114);
            this.biletSKKcc.Name = "biletSKKcc";
            this.biletSKKcc.Size = new System.Drawing.Size(144, 20);
            this.biletSKKcc.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(448, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Kart Üzerindeki isim :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(474, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Kart Numarası :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(519, 82);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "CVV :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(430, 120);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Son Kullanım Tarihi :";
            // 
            // biletAlBTN
            // 
            this.biletAlBTN.Location = new System.Drawing.Point(253, 147);
            this.biletAlBTN.Name = "biletAlBTN";
            this.biletAlBTN.Size = new System.Drawing.Size(122, 47);
            this.biletAlBTN.TabIndex = 18;
            this.biletAlBTN.Text = "Bilet Al";
            this.biletAlBTN.UseVisualStyleBackColor = true;
            this.biletAlBTN.Click += new System.EventHandler(this.biletAlBTN_Click);
            // 
            // otobusTipi
            // 
            this.otobusTipi.FormattingEnabled = true;
            this.otobusTipi.Items.AddRange(new object[] {
            "2+1",
            "2+2"});
            this.otobusTipi.Location = new System.Drawing.Point(93, 231);
            this.otobusTipi.Name = "otobusTipi";
            this.otobusTipi.Size = new System.Drawing.Size(121, 21);
            this.otobusTipi.TabIndex = 19;
            this.otobusTipi.SelectedIndexChanged += new System.EventHandler(this.otobusTipi_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(19, 234);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Otobüs Tipi :";
            // 
            // koltukSayisi
            // 
            this.koltukSayisi.FormattingEnabled = true;
            this.koltukSayisi.Location = new System.Drawing.Point(93, 262);
            this.koltukSayisi.Name = "koltukSayisi";
            this.koltukSayisi.Size = new System.Drawing.Size(121, 21);
            this.koltukSayisi.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(20, 265);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Koltuk Sayısı :";
            // 
            // odemeNakit
            // 
            this.odemeNakit.AutoSize = true;
            this.odemeNakit.Location = new System.Drawing.Point(316, 51);
            this.odemeNakit.Name = "odemeNakit";
            this.odemeNakit.Size = new System.Drawing.Size(50, 17);
            this.odemeNakit.TabIndex = 23;
            this.odemeNakit.TabStop = true;
            this.odemeNakit.Text = "Nakit";
            this.odemeNakit.UseVisualStyleBackColor = true;
            // 
            // odemeKart
            // 
            this.odemeKart.AutoSize = true;
            this.odemeKart.Location = new System.Drawing.Point(316, 77);
            this.odemeKart.Name = "odemeKart";
            this.odemeKart.Size = new System.Drawing.Size(44, 17);
            this.odemeKart.TabIndex = 24;
            this.odemeKart.TabStop = true;
            this.odemeKart.Text = "Kart";
            this.odemeKart.UseVisualStyleBackColor = true;
            // 
            // dgveri
            // 
            this.dgveri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgveri.Location = new System.Drawing.Point(220, 215);
            this.dgveri.Name = "dgveri";
            this.dgveri.Size = new System.Drawing.Size(497, 171);
            this.dgveri.TabIndex = 25;
            // 
            // biletAlma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 456);
            this.Controls.Add(this.dgveri);
            this.Controls.Add(this.odemeKart);
            this.Controls.Add(this.odemeNakit);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.koltukSayisi);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.otobusTipi);
            this.Controls.Add(this.biletAlBTN);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.biletSKKcc);
            this.Controls.Add(this.biletCCccv);
            this.Controls.Add(this.biletCCkartNum);
            this.Controls.Add(this.biletCCisim);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.biletBinisYeri);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.biletİnisYeri);
            this.Controls.Add(this.biletEposta);
            this.Controls.Add(this.biletTelNo);
            this.Controls.Add(this.biletAdSoyad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "biletAlma";
            this.Text = "biletAlma";
            this.Load += new System.EventHandler(this.biletAlma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgveri)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox biletAdSoyad;
        private System.Windows.Forms.TextBox biletTelNo;
        private System.Windows.Forms.TextBox biletEposta;
        private System.Windows.Forms.ComboBox biletİnisYeri;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox biletBinisYeri;
        private System.Windows.Forms.TextBox biletCCisim;
        private System.Windows.Forms.TextBox biletCCkartNum;
        private System.Windows.Forms.TextBox biletCCccv;
        private System.Windows.Forms.DateTimePicker biletSKKcc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button biletAlBTN;
        private System.Windows.Forms.ComboBox otobusTipi;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox koltukSayisi;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RadioButton odemeNakit;
        private System.Windows.Forms.RadioButton odemeKart;
        private System.Windows.Forms.DataGridView dgveri;
    }
}