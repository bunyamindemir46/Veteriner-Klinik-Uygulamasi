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
    public partial class HayvanGuncelle : Form
    {
        public HayvanGuncelle()
        {
            InitializeComponent();
        }
        public static string DogTar, GuncelTarih;
        private void btnHayvanGuncelle_Click(object sender, EventArgs e)
        {
            if (txtHayvanAnaKupeNoGuncel.Text == "" || txtHayvanAdiGuncel.Text == "" || txtHayvanKiloGuncel.Text == "" || txtHayvanBoyGuncel.Text == "" || txtHayvanCinsiGuncel.Text == "" || cmbGuncelCinsiyet.SelectedIndex < 1 || cmbgunceltip.SelectedIndex < 1)
            {
                if (txtHayvanKupeNoGuncel.Text == "")
                {
                    lblZorunluHayvanKupeGuncel.Visible = true;
                    lblZorunluHayvanKupeGuncel.Text = "Zorunlu";
                    lblZorunluHayvanKupeGuncel.ForeColor = Color.Red;
                }
                else
                {
                    lblZorunluHayvanKupeGuncel.Visible = false;
                }
                if (txtHayvanAdiGuncel.Text == "")
                {

                    lblZorunluHayvanAdiGuncel.Visible = true;
                    lblZorunluHayvanAdiGuncel.Text = "Zorunlu";
                    lblZorunluHayvanAdiGuncel.ForeColor = Color.Red;
                }
                else
                {
                    lblZorunluHayvanAdiGuncel.Visible = false;
                }
                if (cmbgunceltip.SelectedIndex <-1)
                {
                    lblZorunluHayvanTipGuncel.Visible = true;
                    lblZorunluHayvanTipGuncel.Text = "Zorunlu";
                    lblZorunluHayvanTipGuncel.ForeColor = Color.Red;
                }
                else
                {
                    lblZorunluHayvanTipGuncel.Visible = false;
                }
                if (txtHayvanKiloGuncel.Text == "")
                {
                    lblZorunluHayvanKiloGuncel.Visible = true;
                    lblZorunluHayvanKiloGuncel.Text = "Zorunlu";
                    lblZorunluHayvanKiloGuncel.ForeColor = Color.Red;
                }
                else
                {
                    lblZorunluHayvanKiloGuncel.Visible = false;
                }
                if (txtHayvanBoyGuncel.Text == "")
                {
                    lblZorunluHayvanBoyGuncel.Visible = true;
                    lblZorunluHayvanBoyGuncel.Text = "Zorunlu";
                    lblZorunluHayvanBoyGuncel.ForeColor = Color.Red;
                }
                else
                {
                    lblZorunluHayvanBoyGuncel.Visible = false;
                }
                if (txtHayvanCinsiGuncel.Text == "")
                {
                    lblZorunluHayvanCinsGuncel.Visible = true;
                    lblZorunluHayvanCinsGuncel.Text = "Zorunlu";
                    lblZorunluHayvanCinsGuncel.ForeColor = Color.Red;
                }
                else
                {
                    lblZorunluHayvanCinsGuncel.Visible = false;
                }
                if (cmbGuncelCinsiyet.SelectedIndex <-1)
                {
                    lblZorunluHayvanCinsiyetGuncel.Visible = true;
                    lblZorunluHayvanCinsiyetGuncel.Text = "Zorunlu";
                    lblZorunluHayvanCinsiyetGuncel.ForeColor = Color.Red;

                }
                else
                {
                    lblCinsiyetGuncelCons.Visible = false;
                }
                HataYonetimi.UyariVer("Hayvan Güncelleme", "Lütfen Zorunlu Alanları Doldurunuz.");
            }
            else
            {
                Hayvan h = new Hayvan();
                h.KupeNo = txtHayvanAnaKupeNoGuncel.Text;
                h.Ad = txtHayvanAdiGuncel.Text;
                h.AnaKupeNo = txtHayvanAnaKupeNoGuncel.Text;
                h.BabaKupeNo = txtHayvanBabaKupeNoGuncel.Text;
                h.IlId = cmbIlGuncel.SelectedItem.ToString();
                DogTar = dtpckrgunceltarih.Value.ToString("yyyy-MM-dd HH:mm:ss");
                h.Tip = cmbgunceltip.SelectedItem.ToString();
                h.Cins = txtHayvanCinsiGuncel.Text;
                h.Cinsiyet = cmbGuncelCinsiyet.SelectedItem.ToString();
                h.Kilo = Convert.ToInt32(txtHayvanKiloGuncel.Text);
                h.Boy = Convert.ToInt32(txtHayvanBoyGuncel.Text);
                h.SahipTC = txtHayvanSahipTCGuncel.Text;
                h.SahipCepTel = txtHayvanCepGuncel.Text;
                h.Adres = txtHayvanAdresGuncel.Text;
                h.Olusturan = 1;
                DateTime myDateTime = DateTime.Now;
                GuncelTarih = myDateTime.ToString("yyyy-MM-dd HH:mm:ss");
                int l = PersonelIslemler.Hayvan_Guncelle(h);
                if (l > 0)
                {
                    HataYonetimi.Bilgilendirme("Hayvan Güncelleme", "Güncelleme İşlemi Başarılı");
                }
                else
                {
                    HataYonetimi.HataVer("Hayvan Güncelleme", "Güncelleme İşlemi Başarısız");
                }
            }
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Hide();
            Giris grs = new Giris();
            grs.Show();
        }

        private void HayvanGuncelle_Load(object sender, EventArgs e)
        {
            //Hayvan h = new Hayvan();
            //txtHayvanAnaKupeNoGuncel.Text = h.KupeNo;
            //txtHayvanAdiGuncel.Text = h.Ad;
            //txtHayvanAnaKupeNoGuncel.Text = h.AnaKupeNo;
            //txtHayvanBabaKupeNoGuncel.Text = h.BabaKupeNo;
            //cmbIlGuncel.SelectedItem = h.IlId;
            //cmbgunceltip.SelectedItem = h.Tip;
            //txtHayvanCinsiGuncel.Text = h.Cins;
            //cmbGuncelCinsiyet.SelectedItem = h.Cinsiyet;
            //txtHayvanKiloGuncel.Text = h.Kilo.ToString();
            //txtHayvanBoyGuncel.Text = h.Boy.ToString();
            //txtHayvanSahipTCGuncel.Text = h.SahipTC;
            //txtHayvanCepGuncel.Text = h.SahipCepTel;
            //txtHayvanAdresGuncel.Text = h.Adres;

            lblZorunluHayvanKupeGuncel.Visible = false;
            lblZorunluHayvanTipGuncel.Visible = false;
            lblZorunluHayvanCinsGuncel.Visible = false;
            lblCinsiyetGuncelCons.Visible = false;
            lblZorunluHayvanAdiGuncel.Visible = false;
            lblZorunluHayvanKiloGuncel.Visible = false;
            lblZorunluHayvanBoyGuncel.Visible = false;
        }
    }
}
