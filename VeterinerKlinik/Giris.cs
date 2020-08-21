using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VeterinerKlinik.Islemler;

namespace VeterinerKlinik
{
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }


        private void btngir_Click(object sender, EventArgs e)
        {
            if (txtGirisTC.Text==""||txtSifre.Text=="")
            {
                HataYonetimi.UyariVer("Personel Girişi", "Lütfen Giriş Bilgilerini Doldurunuz");
            }
            else
            {
                string sonuc = PersonelIslemler.GirisYap(txtGirisTC.Text, txtSifre.Text);
                if (string.Equals(sonuc,"Veteriner/Yönetici"))
                {
                    YoneticiEkrani pd = new YoneticiEkrani();
                    this.Visible = false;
                    pd.ShowDialog();

                }
                else if (string.Equals(sonuc, "Sekreter"))
                {
                    PersonelEkrani pd = new PersonelEkrani();
                    this.Visible = false;
                    pd.ShowDialog();

                }
                else
                {
                    HataYonetimi.UyariVer("Personel Girişi", "Kullanıcı Bulunamadı.");
                }
            }
        }

        private void btnGirisParolaDegistir_Click(object sender, EventArgs e)
        {
            ParolaDegistirme pd = new ParolaDegistirme();
            pd.Show();
        }
    }
}
