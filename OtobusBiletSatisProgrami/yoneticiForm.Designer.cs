namespace OtobusBiletSatisProgrami
{
    partial class yoneticiForm
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
            this.yonSeferGor = new System.Windows.Forms.Button();
            this.yonOtobusGor = new System.Windows.Forms.Button();
            this.yoneticiOtobusEkle = new System.Windows.Forms.Button();
            this.yoneticiRaporOlustur = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // yonSeferGor
            // 
            this.yonSeferGor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yonSeferGor.Location = new System.Drawing.Point(12, 12);
            this.yonSeferGor.Name = "yonSeferGor";
            this.yonSeferGor.Size = new System.Drawing.Size(142, 68);
            this.yonSeferGor.TabIndex = 1;
            this.yonSeferGor.Text = "Seferleri Görüntüle";
            this.yonSeferGor.UseVisualStyleBackColor = true;
            this.yonSeferGor.Click += new System.EventHandler(this.button2_Click);
            // 
            // yonOtobusGor
            // 
            this.yonOtobusGor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yonOtobusGor.Location = new System.Drawing.Point(160, 12);
            this.yonOtobusGor.Name = "yonOtobusGor";
            this.yonOtobusGor.Size = new System.Drawing.Size(134, 68);
            this.yonOtobusGor.TabIndex = 2;
            this.yonOtobusGor.Text = "Otobüsleri Görüntüle";
            this.yonOtobusGor.UseVisualStyleBackColor = true;
            this.yonOtobusGor.Click += new System.EventHandler(this.button1_Click);
            // 
            // yoneticiOtobusEkle
            // 
            this.yoneticiOtobusEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yoneticiOtobusEkle.Location = new System.Drawing.Point(300, 12);
            this.yoneticiOtobusEkle.Name = "yoneticiOtobusEkle";
            this.yoneticiOtobusEkle.Size = new System.Drawing.Size(135, 68);
            this.yoneticiOtobusEkle.TabIndex = 3;
            this.yoneticiOtobusEkle.Text = "Otobüs Ekle";
            this.yoneticiOtobusEkle.UseVisualStyleBackColor = true;
            // 
            // yoneticiRaporOlustur
            // 
            this.yoneticiRaporOlustur.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yoneticiRaporOlustur.Location = new System.Drawing.Point(441, 12);
            this.yoneticiRaporOlustur.Name = "yoneticiRaporOlustur";
            this.yoneticiRaporOlustur.Size = new System.Drawing.Size(134, 68);
            this.yoneticiRaporOlustur.TabIndex = 4;
            this.yoneticiRaporOlustur.Text = "Rapor Oluştur";
            this.yoneticiRaporOlustur.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 156);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(577, 171);
            this.dataGridView1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(-1231, -676);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // yoneticiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 339);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.yoneticiRaporOlustur);
            this.Controls.Add(this.yoneticiOtobusEkle);
            this.Controls.Add(this.yonOtobusGor);
            this.Controls.Add(this.yonSeferGor);
            this.Name = "yoneticiForm";
            this.Text = "yoneticiForm";
            this.Load += new System.EventHandler(this.yoneticiForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button yonSeferGor;
        private System.Windows.Forms.Button yonOtobusGor;
        private System.Windows.Forms.Button yoneticiOtobusEkle;
        private System.Windows.Forms.Button yoneticiRaporOlustur;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}