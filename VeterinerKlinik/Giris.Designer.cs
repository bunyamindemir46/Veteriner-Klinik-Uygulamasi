namespace VeterinerKlinik
{
    partial class Giris
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGirisParolaDegistir = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblilkgirisayrac = new System.Windows.Forms.Label();
            this.btngir = new System.Windows.Forms.Button();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtGirisTC = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGirisParolaDegistir
            // 
            this.btnGirisParolaDegistir.Location = new System.Drawing.Point(5, 186);
            this.btnGirisParolaDegistir.Margin = new System.Windows.Forms.Padding(4);
            this.btnGirisParolaDegistir.Name = "btnGirisParolaDegistir";
            this.btnGirisParolaDegistir.Size = new System.Drawing.Size(148, 33);
            this.btnGirisParolaDegistir.TabIndex = 14;
            this.btnGirisParolaDegistir.Text = "Şifre Değiştir";
            this.btnGirisParolaDegistir.UseVisualStyleBackColor = true;
            this.btnGirisParolaDegistir.Click += new System.EventHandler(this.btnGirisParolaDegistir_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(301, 11);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Giriş Ekranı:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnGirisParolaDegistir);
            this.panel1.Controls.Add(this.lblilkgirisayrac);
            this.panel1.Controls.Add(this.btngir);
            this.panel1.Controls.Add(this.txtSifre);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtGirisTC);
            this.panel1.Location = new System.Drawing.Point(232, 46);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(468, 225);
            this.panel1.TabIndex = 11;
            // 
            // lblilkgirisayrac
            // 
            this.lblilkgirisayrac.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblilkgirisayrac.Location = new System.Drawing.Point(115, 80);
            this.lblilkgirisayrac.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblilkgirisayrac.Name = "lblilkgirisayrac";
            this.lblilkgirisayrac.Size = new System.Drawing.Size(347, 2);
            this.lblilkgirisayrac.TabIndex = 6;
            // 
            // btngir
            // 
            this.btngir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btngir.Location = new System.Drawing.Point(221, 104);
            this.btngir.Margin = new System.Windows.Forms.Padding(4);
            this.btngir.Name = "btngir";
            this.btngir.Size = new System.Drawing.Size(148, 44);
            this.btngir.TabIndex = 5;
            this.btngir.Text = "Giriş Yap";
            this.btngir.UseVisualStyleBackColor = false;
            this.btngir.Click += new System.EventHandler(this.btngir_Click);
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(203, 54);
            this.txtSifre.Margin = new System.Windows.Forms.Padding(4);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.PasswordChar = '*';
            this.txtSifre.Size = new System.Drawing.Size(175, 22);
            this.txtSifre.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(69, 62);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Şifre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(7, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "T.C. Kimlik No:";
            // 
            // txtGirisTC
            // 
            this.txtGirisTC.Location = new System.Drawing.Point(203, 10);
            this.txtGirisTC.Margin = new System.Windows.Forms.Padding(4);
            this.txtGirisTC.Name = "txtGirisTC";
            this.txtGirisTC.Size = new System.Drawing.Size(175, 22);
            this.txtGirisTC.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::VeterinerKlinik.Properties.Resources.Login__1_;
            this.pictureBox1.Location = new System.Drawing.Point(16, 46);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(207, 225);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // Giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 288);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Giris";
            this.Text = "Giriş Ekranı";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGirisParolaDegistir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblilkgirisayrac;
        private System.Windows.Forms.Button btngir;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGirisTC;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

