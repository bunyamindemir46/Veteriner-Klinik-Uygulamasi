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
    public partial class PersonelIslemleri : Form
    {
        public PersonelIslemleri()
        {
            InitializeComponent();
        }
        int datagrid_secili_satir;
        private string datagrid_secili_satirTC;

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtPersonelAra.Text == "")
            {
                HataYonetimi.UyariVer("Personel Arama", "Lütfen TC Kimlik No Giriniz.");
            }
            else
            {
                dtgridviewPersonelListesi.DataSource = YoneticiIslemler.Personel_Getir(txtPersonelAra.Text);
                dtgridviewPersonelListesi.Columns["Id"].Visible = false;
                dtgridviewPersonelListesi.Columns["IsActive"].Visible = false;
                if (dtgridviewPersonelListesi.Rows.Count <= 1)
                {
                    HataYonetimi.UyariVer("Personel Arama", "Aradığınız TC Kimlik No İle Personel Bulunamadı.");
                }
                //buradaki foreach datagridin düzenlenmesini önlemek için yapıldı.
                foreach (DataGridViewBand band in dtgridviewPersonelListesi.Columns)
                {
                    band.ReadOnly = true;
                }
            }
        }

        private void btnPersonelPasifYap_Click(object sender, EventArgs e)
        {
            if (datagrid_secili_satir > 0)
            {
                int sonuc = YoneticiIslemler.Pasife_Al("Personel", datagrid_secili_satir);
                if (sonuc > 0)
                {
                    HataYonetimi.Bilgilendirme("Personel Silme", "Seçili Personel Silindi.");
                    dtgridviewPersonelListesi.DataSource = YoneticiIslemler.Aktif_Personel_Getir();
                    dtgridviewPersonelListesi.Columns["Id"].Visible = false;
                    dtgridviewPersonelListesi.Columns["IsActive"].Visible = false;
                    foreach (DataGridViewBand band in dtgridviewPersonelListesi.Columns)
                    {
                        band.ReadOnly = true;
                    }
                }
            }
            else
            {
                HataYonetimi.UyariVer("Personel Silme", "Lütfen Tablodan Personel Seçiniz.");
            }
        }

        private void btnPersonelAktifYap_Click(object sender, EventArgs e)
        {
            if (datagrid_secili_satir > 0)
            {
                int sonuc = YoneticiIslemler.Aktif_Yap("Personel", datagrid_secili_satir);
                if (sonuc > 0)
                {
                    HataYonetimi.Bilgilendirme("Personel Aktifleştirme", "Seçili Personel Aktif Yapıldı.");
                    dtgridviewPersonelListesi.DataSource = YoneticiIslemler.Aktif_Personel_Getir();
                    dtgridviewPersonelListesi.Columns["Id"].Visible = false;
                    dtgridviewPersonelListesi.Columns["IsActive"].Visible = false;
                    foreach (DataGridViewBand band in dtgridviewPersonelListesi.Columns)
                    {
                        band.ReadOnly = true;
                    }
                }
            }
            else
            {
                HataYonetimi.UyariVer("Personel Aktifleştirme", "Seçili Personel Aktif Yapılamadı.");
            }
        }

        private void PersonelIslemleri_Load(object sender, EventArgs e)
        {
            dtgridviewPersonelListesi.DataSource = YoneticiIslemler.Aktif_Personel_Getir();
            dtgridviewPersonelListesi.Columns["Id"].Visible = false;
            dtgridviewPersonelListesi.Columns["IsActive"].Visible = false;
            foreach (DataGridViewBand band in dtgridviewPersonelListesi.Columns)
            {
                band.ReadOnly = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dtgridviewPersonelListesi.DataSource = YoneticiIslemler.Butun_Personel_Getir();
            dtgridviewPersonelListesi.Columns["Id"].Visible = false;
            foreach (DataGridViewBand band in dtgridviewPersonelListesi.Columns)
            {
                band.ReadOnly = true;
            }
        }

        private void dtgrdPersonelSil_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dtgridviewPersonelListesi.SelectedRows)
            {
                datagrid_secili_satir = Convert.ToInt32(row.Cells[0].Value); 
                datagrid_secili_satirTC = row.Cells[5].Value.ToString();
            }
        }

        private void btnPersonelParolaSifirla_Click(object sender, EventArgs e)
        {
            if (datagrid_secili_satir > 0)
            {
                int sonuc = YoneticiIslemler.Parola_Sifirla(datagrid_secili_satirTC);
                if (sonuc > 0)
                {
                    HataYonetimi.Bilgilendirme("Personel Parola İşlemleri", "Seçili Personelin Parolası Sıfırlandı.");
                    dtgridviewPersonelListesi.DataSource = YoneticiIslemler.Aktif_Personel_Getir();
                    dtgridviewPersonelListesi.Columns["Id"].Visible = false;
                    dtgridviewPersonelListesi.Columns["IsActive"].Visible = false;
                    foreach (DataGridViewBand band in dtgridviewPersonelListesi.Columns)
                    {
                        band.ReadOnly = true;
                    }
                }
            }
            else
            {
                HataYonetimi.UyariVer("Personel Parola İşlemleri", "Seçili Personel Parola Sıfırlama İşlemi Yapılamadı.");
            }
        }
    }
}
