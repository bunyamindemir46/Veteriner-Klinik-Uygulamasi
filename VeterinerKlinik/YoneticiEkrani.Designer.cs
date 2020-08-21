namespace VeterinerKlinik
{
    partial class YoneticiEkrani
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
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn2
            // 
            this.btn2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn2.Location = new System.Drawing.Point(31, 128);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(189, 88);
            this.btn2.TabIndex = 5;
            this.btn2.Text = "Hayvan Arama İşlemleri";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn3.Location = new System.Drawing.Point(31, 241);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(189, 70);
            this.btn3.TabIndex = 4;
            this.btn3.Text = "Parola İşlemleri";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn1
            // 
            this.btn1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn1.Location = new System.Drawing.Point(31, 36);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(189, 70);
            this.btn1.TabIndex = 3;
            this.btn1.Text = "Hayvan Kayıt İşlemleri";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn5
            // 
            this.btn5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn5.Location = new System.Drawing.Point(242, 36);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(189, 70);
            this.btn5.TabIndex = 7;
            this.btn5.Text = "Personel Ekleme İşlemleri";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn6
            // 
            this.btn6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn6.Location = new System.Drawing.Point(242, 128);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(189, 88);
            this.btn6.TabIndex = 8;
            this.btn6.Text = "Personel İşlemleri";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // YoneticiEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 403);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn1);
            this.Name = "YoneticiEkrani";
            this.Text = "YoneticiEkrani";
            this.Load += new System.EventHandler(this.YoneticiEkrani_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
    }
}