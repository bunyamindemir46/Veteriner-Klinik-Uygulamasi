using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VeterinerKlinik.Entity;
using VeterinerKlinik.Islemler;

namespace VeterinerKlinik
{
    public partial class ParolaDegistirme : Form
    {
        public ParolaDegistirme()
        {
            InitializeComponent();
        }
        public static int PersonelNo;
        private void btnPersonelParolaDegistir_Click(object sender, EventArgs e)
        {
            bool result = string.Equals(txtParolaEkraniYeniParola, txtParolaEkraniYeniParola);
            if (txtParolaEkraniPersonelNo.Text == "" || txtParolaEkraniEskiParola.Text == "" || txtParolaEkraniYeniParola.Text == "" || txtParolaEkraniYeniParolaTekrar.Text == "")
            {
                HataYonetimi.UyariVer("Parola Değiştirme", "Lütfen Tüm Alanları Doldurunuz");
            }
            else if (result==false) {
                HataYonetimi.UyariVer("Parola Değiştirme", "Yeni Parolalar Uyuşmuyor");
            }
            else
            {
                ParolaViewModel pwm = new ParolaViewModel();
                PersonelNo = Convert.ToInt32(txtParolaEkraniPersonelNo.Text);
                pwm.Sifre = txtParolaEkraniEskiParola.Text;
                pwm.YeniSifre = txtParolaEkraniYeniParola.Text;

                int l = PersonelIslemler.Parola_Degistir(pwm);
                if (l > 0)
                {
                    HataYonetimi.Bilgilendirme("Tedavi Ekleme", "Ekleme İşlemi Başarılı");
                }
                else
                {
                    HataYonetimi.HataVer("Tedavi Ekleme", "Ekleme İşlemi Başarısız");
                }
            }
        }
    }
}
