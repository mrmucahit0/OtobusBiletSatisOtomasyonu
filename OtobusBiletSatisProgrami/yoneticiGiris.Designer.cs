﻿namespace OtobusBiletSatisProgrami
{
    partial class yoneticiGiris
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
            this.yoneticiAd = new System.Windows.Forms.TextBox();
            this.yoneticiSifre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // yoneticiAd
            // 
            this.yoneticiAd.Location = new System.Drawing.Point(150, 52);
            this.yoneticiAd.Name = "yoneticiAd";
            this.yoneticiAd.Size = new System.Drawing.Size(100, 20);
            this.yoneticiAd.TabIndex = 0;
            // 
            // yoneticiSifre
            // 
            this.yoneticiSifre.Location = new System.Drawing.Point(150, 82);
            this.yoneticiSifre.Name = "yoneticiSifre";
            this.yoneticiSifre.Size = new System.Drawing.Size(100, 20);
            this.yoneticiSifre.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Yönetici Ad :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Yönetici Şifre :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(105, 144);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Giriş Yap";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // yoneticiGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 210);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.yoneticiSifre);
            this.Controls.Add(this.yoneticiAd);
            this.Name = "yoneticiGiris";
            this.Text = "yoneticiGiris";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox yoneticiAd;
        private System.Windows.Forms.TextBox yoneticiSifre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}