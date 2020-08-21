using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VeterinerKlinik.Entity;
using VeterinerKlinik.Islemler;

namespace VeterinerKlinik
{
    public partial class PersonelEkle : Form
    {
        public PersonelEkle()
        {
            InitializeComponent();
        }
        public static string OlusTar,DogumTar;
        private void btnPersonelEkle_Click(object sender, EventArgs e)
        {
            if (txtperekleformtc.Text == "" || txtperekleformperno.Text == "" || txtperekleformpertur.Text == "" || txtperekleformperadi.Text == "" || txtperekleformpersoyad.Text == "" || txtperekleformpereposta.Text == "" || txtperekleformpertel.Text == "" || txtperekleformpercins.Text == "" || txtperekleformperdogtar.Value == null)
            {
                HataYonetimi.UyariVer("Personel Ekleme", "Lütfen Tüm Alanları Doldurunuz.");
            }
            else
            {
                Personel p = new Personel
                {
                    TC = txtperekleformtc.Text,
                    PersonelNo = Convert.ToInt32(txtperekleformperno.Text),
                    PerTur = txtperekleformpertur.SelectedItem.ToString(),
                    Ad = txtperekleformperadi.Text,
                    Soyad = txtperekleformperadi.Text
                };
                //şifre olarak T.C. son 4 hanesini alıyor
                    p.Sifre= p.TC.Substring(p.TC.Length - 4);
                p.Eposta = txtperekleformpereposta.Text;
                p.TelNo = txtperekleformpertel.Text;
                p.Cinsiyet = Convert.ToInt32(txtperekleformpercins.SelectedIndex);
                DogumTar = txtperekleformperdogtar.Value.ToString("yyyy-MM-dd HH:mm:ss");
                p.Olusturan = 1;
                DateTime myDateTime = DateTime.Now;
                OlusTar = myDateTime.ToString("yyyy-MM-dd HH:mm:ss");
                int l = YoneticiIslemler.Per_Ekle(p);
                if (l > 0)
                {
                    HataYonetimi.Bilgilendirme("Kullanıcı Girişi", "Ekleme İşlemi Başarılı");
                }
                else
                {
                    HataYonetimi.HataVer("Kullanıcı Girişi", "Ekleme İşlemi Başarısız");
                }
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void txtsekreeklesicil_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
