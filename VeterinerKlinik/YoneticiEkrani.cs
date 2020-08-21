using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VeterinerKlinik
{
    public partial class YoneticiEkrani : Form
    {
        public YoneticiEkrani()
        {
            InitializeComponent();
        }

        private void YoneticiEkrani_Load(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            HayvanKayit hk = new HayvanKayit();
            hk.Show();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            HayvanArama ha = new HayvanArama();
            ha.Show();
        }
        private void btn3_Click(object sender, EventArgs e)
        {
            ParolaDegistirme pd = new ParolaDegistirme();
            pd.Show();
        }
        private void btn4_Click(object sender, EventArgs e)
        {
            HayvanMuayeneIslemleri hm = new HayvanMuayeneIslemleri();
            hm.Show();
        }
        private void btn5_Click(object sender, EventArgs e)
        {
            PersonelEkle pe = new PersonelEkle();
            pe.Show();
        }
        private void btn6_Click(object sender, EventArgs e)
        {
            PersonelIslemleri pi = new PersonelIslemleri();
            pi.Show();
        }
    }
}
