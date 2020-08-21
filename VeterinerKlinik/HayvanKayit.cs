using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VeterinerKlinik.Entity;
using VeterinerKlinik.Islemler;
using VeterinerKlinik.Properties;

namespace VeterinerKlinik
{
    public partial class HayvanKayit : Form
    {
        public HayvanKayit()
        {
            InitializeComponent();
        }
       public static string DogTar, OlusTar;
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtHyvnKupeNo.Text == "" || txtHayvanAdi.Text == "" || txtHayvanKilo.Text == "" || txtHayvanBoy.Text == "" || txtHayvanCinsi.Text == "" || cmbHayvanCinsiyet.SelectedIndex < 1 || cmbHayvanTip.SelectedIndex < 1)
            {
                if (txtHyvnKupeNo.Text == "")
                {
                        lblZorunluHayvanKupeNo.Visible = true;
                        lblZorunluHayvanKupeNo.Text = "Zorunlu";
                        lblZorunluHayvanKupeNo.ForeColor = Color.Red;
                }
                else
                {
                    lblZorunluHayvanKupeNo.Visible = false;
                }
                if (txtHayvanAdi.Text == "")
                {

                    lblZorunluHayvanAd.Visible = true;
                    lblZorunluHayvanAd.Text = "Zorunlu";
                    lblZorunluHayvanAd.ForeColor = Color.Red;
                }
                else
                {
                    lblZorunluHayvanAd.Visible = false;
                }
                if (cmbHayvanTip.SelectedIndex < 1)
                {
                    lblZorunluHayvanTip.Visible = true;
                    lblZorunluHayvanTip.Text = "Zorunlu";
                    lblZorunluHayvanTip.ForeColor = Color.Red;
                }
                else
                {
                    lblZorunluHayvanTip.Visible = false;
                }
                if (txtHayvanKilo.Text == "")
                {
                    lblZorunluHayvanKilo.Visible = true;
                    lblZorunluHayvanKilo.Text = "Zorunlu";
                    lblZorunluHayvanKilo.ForeColor = Color.Red;
                }
                else
                {
                    lblZorunluHayvanKilo.Visible = false;
                }
                if (txtHayvanBoy.Text == "")
                {
                    lblZorunluHayvanBoy.Visible = true;
                    lblZorunluHayvanBoy.Text = "Zorunlu";
                    lblZorunluHayvanBoy.ForeColor = Color.Red;
                }
                else
                {
                    lblZorunluHayvanBoy.Visible = false;
                }
                if (txtHayvanCinsi.Text == "")
                {
                    lblZorunluHayvanCins.Visible = true;
                    lblZorunluHayvanCins.Text = "Zorunlu";
                    lblZorunluHayvanCins.ForeColor = Color.Red;
                }
                else
                {
                    lblZorunluHayvanCins.Visible = false;
                }
                if (cmbHayvanCinsiyet.SelectedIndex < 1)
                {
                    lblZorunluHayvanCinsiyet.Visible = true;
                    lblZorunluHayvanCinsiyet.Text = "Zorunlu";
                    lblZorunluHayvanCinsiyet.ForeColor = Color.Red;

                }
                else
                {
                    lblZorunluHayvanCinsiyet.Visible = false;
                }
                HataYonetimi.UyariVer("Hayvan Ekleme", "Lütfen Zorunlu Alanları Doldurunuz.");
            }
            else
            {
                Hayvan h = new Hayvan();
                h.KupeNo = txtHyvnKupeNo.Text;
                h.Ad = txtHayvanAdi.Text;
                h.AnaKupeNo = txtHayvanAnaKupeNo.Text;
                h.BabaKupeNo = txtHayvanBabaKupeNo.Text;
                h.IlId = cmbHayvanDogumIl.SelectedItem.ToString();
                DogTar = cmbHayvanDogumTar.Value.ToString("yyyy-MM-dd HH:mm:ss");
                h.Tip = cmbHayvanTip.SelectedItem.ToString();
                h.Cins = txtHayvanCinsi.Text;
                h.Cinsiyet = cmbHayvanCinsiyet.SelectedItem.ToString();
                h.Kilo =Convert.ToInt32(txtHayvanKilo.Text);
                h.Boy = Convert.ToInt32(txtHayvanBoy.Text);
                h.SahipTC = txtHayvanSahipTC.Text;
                h.SahipCepTel = txtHayvanSahipCepTel.Text;
                h.Adres = txtHayvanSahipAdres.Text;
                h.Olusturan = 1;
                DateTime myDateTime = DateTime.Now;
                OlusTar = myDateTime.ToString("yyyy-MM-dd HH:mm:ss");
                int l = PersonelIslemler.Hayvan_Ekle(h);
                if (l > 0)
                {
                    HataYonetimi.Bilgilendirme("Hayvan Ekleme", "Ekleme İşlemi Başarılı");
                }
                else
                {
                    HataYonetimi.HataVer("Hayvan Ekleme", "Ekleme İşlemi Başarısız");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Giris grs = new Giris();
            grs.Show();

        }

        private void HayvanKayit_Load(object sender, EventArgs e)
        {
            lblZorunluHayvanKupeNo.Visible = false;
            lblZorunluHayvanTip.Visible = false;
            lblZorunluHayvanCins.Visible = false;
            lblZorunluHayvanCinsiyet.Visible = false;
            lblZorunluHayvanAd.Visible = false;
            lblZorunluHayvanKilo.Visible = false;
            lblZorunluHayvanBoy.Visible = false;
        }

        private void txtHayvanCinsi_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbHayvanCinsiyet_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
