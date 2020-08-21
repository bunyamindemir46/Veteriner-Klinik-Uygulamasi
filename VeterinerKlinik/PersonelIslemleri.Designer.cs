namespace VeterinerKlinik
{
    partial class PersonelIslemleri
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
            this.dtgridviewPersonelListesi = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPersonelAktifYap = new System.Windows.Forms.Button();
            this.btnPersonelPasifYap = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtPersonelAra = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnPersonelParolaSifirla = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgridviewPersonelListesi)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgridviewPersonelListesi
            // 
            this.dtgridviewPersonelListesi.BackgroundColor = System.Drawing.Color.Silver;
            this.dtgridviewPersonelListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgridviewPersonelListesi.Location = new System.Drawing.Point(4, 91);
            this.dtgridviewPersonelListesi.Margin = new System.Windows.Forms.Padding(4);
            this.dtgridviewPersonelListesi.Name = "dtgridviewPersonelListesi";
            this.dtgridviewPersonelListesi.RowHeadersWidth = 51;
            this.dtgridviewPersonelListesi.Size = new System.Drawing.Size(927, 352);
            this.dtgridviewPersonelListesi.TabIndex = 11;
            this.dtgridviewPersonelListesi.SelectionChanged += new System.EventHandler(this.dtgrdPersonelSil_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(1, 6);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Personel Arama";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnPersonelParolaSifirla);
            this.panel1.Controls.Add(this.btnPersonelAktifYap);
            this.panel1.Controls.Add(this.btnPersonelPasifYap);
            this.panel1.Controls.Add(this.dtgridviewPersonelListesi);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.txtPersonelAra);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(4, 27);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(945, 455);
            this.panel1.TabIndex = 9;
            // 
            // btnPersonelAktifYap
            // 
            this.btnPersonelAktifYap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPersonelAktifYap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnPersonelAktifYap.Location = new System.Drawing.Point(700, 4);
            this.btnPersonelAktifYap.Margin = new System.Windows.Forms.Padding(4);
            this.btnPersonelAktifYap.Name = "btnPersonelAktifYap";
            this.btnPersonelAktifYap.Size = new System.Drawing.Size(95, 57);
            this.btnPersonelAktifYap.TabIndex = 13;
            this.btnPersonelAktifYap.Text = "Aktif Et";
            this.btnPersonelAktifYap.UseVisualStyleBackColor = false;
            this.btnPersonelAktifYap.Click += new System.EventHandler(this.btnPersonelAktifYap_Click);
            // 
            // btnPersonelPasifYap
            // 
            this.btnPersonelPasifYap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPersonelPasifYap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnPersonelPasifYap.Location = new System.Drawing.Point(597, 4);
            this.btnPersonelPasifYap.Margin = new System.Windows.Forms.Padding(4);
            this.btnPersonelPasifYap.Name = "btnPersonelPasifYap";
            this.btnPersonelPasifYap.Size = new System.Drawing.Size(95, 57);
            this.btnPersonelPasifYap.TabIndex = 12;
            this.btnPersonelPasifYap.Text = "Pasife Al";
            this.btnPersonelPasifYap.UseVisualStyleBackColor = false;
            this.btnPersonelPasifYap.Click += new System.EventHandler(this.btnPersonelPasifYap_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button2.Location = new System.Drawing.Point(443, 4);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(146, 57);
            this.button2.TabIndex = 3;
            this.button2.Text = "Tümünü Listele";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1.Location = new System.Drawing.Point(303, 4);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 57);
            this.button1.TabIndex = 2;
            this.button1.Text = "Ara";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtPersonelAra
            // 
            this.txtPersonelAra.Location = new System.Drawing.Point(151, 15);
            this.txtPersonelAra.Margin = new System.Windows.Forms.Padding(4);
            this.txtPersonelAra.Name = "txtPersonelAra";
            this.txtPersonelAra.Size = new System.Drawing.Size(132, 22);
            this.txtPersonelAra.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(4, 15);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Personel No:";
            // 
            // btnPersonelParolaSifirla
            // 
            this.btnPersonelParolaSifirla.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPersonelParolaSifirla.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnPersonelParolaSifirla.Location = new System.Drawing.Point(803, 4);
            this.btnPersonelParolaSifirla.Margin = new System.Windows.Forms.Padding(4);
            this.btnPersonelParolaSifirla.Name = "btnPersonelParolaSifirla";
            this.btnPersonelParolaSifirla.Size = new System.Drawing.Size(128, 57);
            this.btnPersonelParolaSifirla.TabIndex = 14;
            this.btnPersonelParolaSifirla.Text = "Parola Sıfırla";
            this.btnPersonelParolaSifirla.UseVisualStyleBackColor = false;
            this.btnPersonelParolaSifirla.Click += new System.EventHandler(this.btnPersonelParolaSifirla_Click);
            // 
            // PersonelIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 484);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "PersonelIslemleri";
            this.Text = "PersonelIslemleri";
            this.Load += new System.EventHandler(this.PersonelIslemleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgridviewPersonelListesi)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgridviewPersonelListesi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtPersonelAra;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnPersonelPasifYap;
        private System.Windows.Forms.Button btnPersonelAktifYap;
        private System.Windows.Forms.Button btnPersonelParolaSifirla;
    }
}