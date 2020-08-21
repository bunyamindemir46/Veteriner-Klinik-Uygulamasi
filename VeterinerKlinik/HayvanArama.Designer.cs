namespace VeterinerKlinik
{
    partial class HayvanArama
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
            this.dataGridViewHayvanArama = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.txtHayvanAraEkraniKupeNo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnHayvanSil = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.btnMuaneyeKaydi = new System.Windows.Forms.Button();
            this.btnHayvanBilgiGuncelle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHayvanArama)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewHayvanArama
            // 
            this.dataGridViewHayvanArama.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHayvanArama.Location = new System.Drawing.Point(215, 84);
            this.dataGridViewHayvanArama.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewHayvanArama.Name = "dataGridViewHayvanArama";
            this.dataGridViewHayvanArama.RowHeadersWidth = 51;
            this.dataGridViewHayvanArama.Size = new System.Drawing.Size(840, 326);
            this.dataGridViewHayvanArama.TabIndex = 8;
            this.dataGridViewHayvanArama.SelectionChanged += new System.EventHandler(this.Hayvan_Sec_Grid);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(212, 3);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Hayvan Arama";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.txtHayvanAraEkraniKupeNo);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(208, 24);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(852, 402);
            this.panel1.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1.Location = new System.Drawing.Point(303, 4);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 43);
            this.button1.TabIndex = 2;
            this.button1.Text = "Ara";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtHayvanAraEkraniKupeNo
            // 
            this.txtHayvanAraEkraniKupeNo.Location = new System.Drawing.Point(151, 15);
            this.txtHayvanAraEkraniKupeNo.Margin = new System.Windows.Forms.Padding(4);
            this.txtHayvanAraEkraniKupeNo.Name = "txtHayvanAraEkraniKupeNo";
            this.txtHayvanAraEkraniKupeNo.Size = new System.Drawing.Size(132, 22);
            this.txtHayvanAraEkraniKupeNo.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(4, 15);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Hayvan Küpe No:";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnHayvanSil);
            this.panel2.Controls.Add(this.button6);
            this.panel2.Controls.Add(this.btnMuaneyeKaydi);
            this.panel2.Controls.Add(this.btnHayvanBilgiGuncelle);
            this.panel2.Location = new System.Drawing.Point(13, 29);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(149, 294);
            this.panel2.TabIndex = 9;
            // 
            // btnHayvanSil
            // 
            this.btnHayvanSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHayvanSil.ForeColor = System.Drawing.Color.Red;
            this.btnHayvanSil.Location = new System.Drawing.Point(-1, 163);
            this.btnHayvanSil.Margin = new System.Windows.Forms.Padding(4);
            this.btnHayvanSil.Name = "btnHayvanSil";
            this.btnHayvanSil.Size = new System.Drawing.Size(144, 50);
            this.btnHayvanSil.TabIndex = 1;
            this.btnHayvanSil.Text = "Hayvanı Sil";
            this.btnHayvanSil.UseVisualStyleBackColor = true;
            this.btnHayvanSil.Click += new System.EventHandler(this.btnHayvanSil_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button6.Location = new System.Drawing.Point(0, 238);
            this.button6.Margin = new System.Windows.Forms.Padding(4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(144, 50);
            this.button6.TabIndex = 0;
            this.button6.Text = "Çıkış";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnMuaneyeKaydi
            // 
            this.btnMuaneyeKaydi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMuaneyeKaydi.Location = new System.Drawing.Point(0, 21);
            this.btnMuaneyeKaydi.Margin = new System.Windows.Forms.Padding(4);
            this.btnMuaneyeKaydi.Name = "btnMuaneyeKaydi";
            this.btnMuaneyeKaydi.Size = new System.Drawing.Size(144, 50);
            this.btnMuaneyeKaydi.TabIndex = 0;
            this.btnMuaneyeKaydi.Text = "Muayene Kaydı";
            this.btnMuaneyeKaydi.UseVisualStyleBackColor = true;
            this.btnMuaneyeKaydi.Click += new System.EventHandler(this.btnMuaneyeKaydi_Click);
            // 
            // btnHayvanBilgiGuncelle
            // 
            this.btnHayvanBilgiGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHayvanBilgiGuncelle.Location = new System.Drawing.Point(0, 96);
            this.btnHayvanBilgiGuncelle.Margin = new System.Windows.Forms.Padding(4);
            this.btnHayvanBilgiGuncelle.Name = "btnHayvanBilgiGuncelle";
            this.btnHayvanBilgiGuncelle.Size = new System.Drawing.Size(144, 50);
            this.btnHayvanBilgiGuncelle.TabIndex = 0;
            this.btnHayvanBilgiGuncelle.Text = "Hayvan Bilgileri Güncelle";
            this.btnHayvanBilgiGuncelle.UseVisualStyleBackColor = true;
            this.btnHayvanBilgiGuncelle.Click += new System.EventHandler(this.btnHayvanBilgiGuncelle_Click);
            // 
            // HayvanArama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 447);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridViewHayvanArama);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "HayvanArama";
            this.Text = "Veteriner Hayvan Arama Ekranı";
            this.Load += new System.EventHandler(this.HayvanArama_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHayvanArama)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewHayvanArama;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtHayvanAraEkraniKupeNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btnMuaneyeKaydi;
        private System.Windows.Forms.Button btnHayvanBilgiGuncelle;
        private System.Windows.Forms.Button btnHayvanSil;
    }
}