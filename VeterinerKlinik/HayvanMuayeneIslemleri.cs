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
    public partial class HayvanMuayeneIslemleri : Form
    {
        public HayvanMuayeneIslemleri()
        {
            InitializeComponent();
        }

        private void btnHayvanReceteTemizle_Click(object sender, EventArgs e)
        {
            txtrecete.Text = "";
        }

        private void btnHayvanAlerjiTemizle_Click(object sender, EventArgs e)
        {
            txtalerji.Text = "";
        }

        private void btnHayvanTedaviTemizle_Click(object sender, EventArgs e)
        {
            txttedavi.Text = "";
        }

        public static string OlusTar;
        private void btnHayvanTedaviKaydet_Click(object sender, EventArgs e)
        {
            Muayene m = new Muayene();
            m.Sikayet = txtsikayet.Text;
            m.Tani = txttani.Text;
            m.Tedavi = txttedavi.Text;

            m.Olusturan = 1;
            DateTime myDateTime = DateTime.Now;
            OlusTar = myDateTime.ToString("yyyy-MM-dd HH:mm:ss");


            int l = YoneticiIslemler.Tedavi_Kaydet(m);
            if (l > 0)
            {
                HataYonetimi.Bilgilendirme("Tedavi Ekleme", "Ekleme İşlemi Başarılı");
            }
            else
            {
                HataYonetimi.HataVer("Tedavi Ekleme", "Ekleme İşlemi Başarısız");
            }
        }

        private void btnAlerjiKaydet_Click(object sender, EventArgs e)
        {
            Muayene m = new Muayene();
            m.Alerji = txtalerji.Text;
            m.Olusturan = 1;
            DateTime myDateTime = DateTime.Now;
            OlusTar = myDateTime.ToString("yyyy-MM-dd HH:mm:ss");
            int l = YoneticiIslemler.Alerji_Kaydet(m);
            if (l > 0)
            {
                HataYonetimi.Bilgilendirme("Alerji Ekleme", "Ekleme İşlemi Başarılı");
            }
            else
            {
                HataYonetimi.HataVer("Alerji Ekleme", "Ekleme İşlemi Başarısız");
            }
        }

        private void btnReceteKaydet_Click(object sender, EventArgs e)
        {
            Muayene m = new Muayene();
            m.Ilaclar = txtrecete.Text;
            m.Olusturan = 1;
            DateTime myDateTime = DateTime.Now;
            OlusTar = myDateTime.ToString("yyyy-MM-dd HH:mm:ss");
            int l = YoneticiIslemler.Recete_Kaydet(m);
            if (l > 0)
            {
                HataYonetimi.Bilgilendirme("Reçete Ekleme", "Ekleme İşlemi Başarılı");
            }
            else
            {
                HataYonetimi.HataVer("Reçete Ekleme", "Ekleme İşlemi Başarısız");
            }
        }

        private void HayvanMuayeneIslemleri_Load(object sender, EventArgs e)
        {
            dataGridOncekiIlaclar.DataSource = PersonelIslemler.Butun_Tedavileri_Getir();
            dataGridOncekiAlerjiler.DataSource = PersonelIslemler.Butun_Tedavileri_Getir();
            dataGridTedaviler.DataSource = PersonelIslemler.Butun_Tedavileri_Getir();


            dataGridOncekiIlaclar.Columns["Id"].Visible = false;
            dataGridOncekiIlaclar.Columns["Olusturan"].Visible = false;
            dataGridOncekiIlaclar.Columns["Guncelleyen"].Visible = false;
            dataGridOncekiIlaclar.Columns["OlusTar"].Visible = false;
            dataGridOncekiIlaclar.Columns["GuncelTar"].Visible = false;
            dataGridOncekiIlaclar.Columns["Sikayet"].Visible = false;
            dataGridOncekiIlaclar.Columns["Tani"].Visible = false;
            dataGridOncekiIlaclar.Columns["Tedavi"].Visible = false;
            dataGridOncekiIlaclar.Columns["Alerji"].Visible = false;




            dataGridOncekiAlerjiler.Columns["Id"].Visible = false;
            dataGridOncekiAlerjiler.Columns["Olusturan"].Visible = false;
            dataGridOncekiAlerjiler.Columns["Guncelleyen"].Visible = false;
            dataGridOncekiAlerjiler.Columns["OlusTar"].Visible = false;
            dataGridOncekiAlerjiler.Columns["GuncelTar"].Visible = false;
            dataGridOncekiAlerjiler.Columns["Sikayet"].Visible = false;
            dataGridOncekiAlerjiler.Columns["Tani"].Visible = false;
            dataGridOncekiAlerjiler.Columns["Tedavi"].Visible = false;
            dataGridOncekiAlerjiler.Columns["Ilaclar"].Visible = false;


            dataGridTedaviler.Columns["Id"].Visible = false;
            dataGridTedaviler.Columns["Olusturan"].Visible = false;
            dataGridTedaviler.Columns["Guncelleyen"].Visible = false;
            dataGridTedaviler.Columns["OlusTar"].Visible = false;
            dataGridTedaviler.Columns["GuncelTar"].Visible = false;
            dataGridTedaviler.Columns["Ilaclar"].Visible = false;
            dataGridTedaviler.Columns["Alerji"].Visible = false;



            foreach (DataGridViewBand band in dataGridOncekiAlerjiler.Columns)
            {
                band.ReadOnly = true;
            }
            foreach (DataGridViewBand band in dataGridOncekiIlaclar.Columns)
            {
                band.ReadOnly = true;
            }
            foreach (DataGridViewBand band in dataGridTedaviler.Columns)
            {
                band.ReadOnly = true;
            }
        }
    }
}
