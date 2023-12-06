namespace OtobusBiletSatisProgrami
{
    partial class anaForm
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
            this.biletAlmaBTN = new System.Windows.Forms.Button();
            this.biletİptal = new System.Windows.Forms.Button();
            this.yoneticiGiris = new System.Windows.Forms.Button();
            this.BiletGuncelle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // biletAlmaBTN
            // 
            this.biletAlmaBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.biletAlmaBTN.Location = new System.Drawing.Point(12, 12);
            this.biletAlmaBTN.Name = "biletAlmaBTN";
            this.biletAlmaBTN.Size = new System.Drawing.Size(149, 64);
            this.biletAlmaBTN.TabIndex = 0;
            this.biletAlmaBTN.Text = "Bilet Ekle";
            this.biletAlmaBTN.UseVisualStyleBackColor = true;
            this.biletAlmaBTN.Click += new System.EventHandler(this.biletAlmaBTN_Click);
            // 
            // biletİptal
            // 
            this.biletİptal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.biletİptal.Location = new System.Drawing.Point(322, 12);
            this.biletİptal.Name = "biletİptal";
            this.biletİptal.Size = new System.Drawing.Size(149, 64);
            this.biletİptal.TabIndex = 4;
            this.biletİptal.Text = "Bilet İptal Et";
            this.biletİptal.UseVisualStyleBackColor = true;
            // 
            // yoneticiGiris
            // 
            this.yoneticiGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yoneticiGiris.Location = new System.Drawing.Point(477, 12);
            this.yoneticiGiris.Name = "yoneticiGiris";
            this.yoneticiGiris.Size = new System.Drawing.Size(121, 64);
            this.yoneticiGiris.TabIndex = 5;
            this.yoneticiGiris.Text = "Yönetici Girişi";
            this.yoneticiGiris.UseVisualStyleBackColor = true;
            this.yoneticiGiris.Click += new System.EventHandler(this.button3_Click);
            // 
            // BiletGuncelle
            // 
            this.BiletGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BiletGuncelle.Location = new System.Drawing.Point(167, 12);
            this.BiletGuncelle.Name = "BiletGuncelle";
            this.BiletGuncelle.Size = new System.Drawing.Size(149, 64);
            this.BiletGuncelle.TabIndex = 6;
            this.BiletGuncelle.Text = "Bilet Güncelle";
            this.BiletGuncelle.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 148);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(586, 196);
            this.dataGridView1.TabIndex = 7;
            // 
            // anaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 348);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BiletGuncelle);
            this.Controls.Add(this.yoneticiGiris);
            this.Controls.Add(this.biletİptal);
            this.Controls.Add(this.biletAlmaBTN);
            this.Name = "anaForm";
            this.Text = "Bilet ana Ekranı";
            this.Load += new System.EventHandler(this.anaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button biletAlmaBTN;
        private System.Windows.Forms.Button biletİptal;
        private System.Windows.Forms.Button yoneticiGiris;
        private System.Windows.Forms.Button BiletGuncelle;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}