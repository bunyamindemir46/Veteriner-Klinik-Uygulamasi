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
    public partial class PersonelEkrani : Form
    {
        public PersonelEkrani()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HayvanKayit pd = new HayvanKayit();
            pd.Show();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            ParolaDegistirme pd = new ParolaDegistirme();
            pd.Show();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            HayvanArama pd = new HayvanArama();
            pd.Show();
        }
    }
}
