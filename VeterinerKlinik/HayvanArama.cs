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
    public partial class HayvanArama : Form
    {
        public HayvanArama()
        {
            InitializeComponent();
        }
        public static int datagrid_secili_satir;
        public static string Kupe;
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtHayvanAraEkraniKupeNo.Text=="")
            {
                HataYonetimi.UyariVer("Hayvan Arama", "Lütfen Hayvan Kupe No Giriniz.");
            }
            else
            {
                dataGridViewHayvanArama.DataSource = PersonelIslemler.Hayvan_Getir(txtHayvanAraEkraniKupeNo.Text);
                dataGridViewHayvanArama.Columns["Id"].Visible = false;
                dataGridViewHayvanArama.Columns["IsActive"].Visible = false;
                if (dataGridViewHayvanArama.Rows.Count<=1)
                {
                    HataYonetimi.UyariVer("Hayvan Arama", "Aradığınız KupeNo İle Hayvan Bulunamadı.");
                }
                //buradaki foreach datagridin düzenlenmesini önlemek için yapıldı.
                foreach (DataGridViewBand band in dataGridViewHayvanArama.Columns)
                {
                    band.ReadOnly = true;
                }
            }
        }

        private void HayvanArama_Load(object sender, EventArgs e)
        {
            dataGridViewHayvanArama.DataSource = PersonelIslemler.Butun_Hayvanlari_Getir();
            dataGridViewHayvanArama.Columns["Id"].Visible = false;
            dataGridViewHayvanArama.Columns["IsActive"].Visible = false;
            foreach (DataGridViewBand band in dataGridViewHayvanArama.Columns)
            {
                band.ReadOnly = true;
            }
        }

        private void btnHayvanSil_Click(object sender, EventArgs e)
        {
            if (datagrid_secili_satir>0)
            {
                int sonuc = PersonelIslemler.Pasife_Al("Hayvan", datagrid_secili_satir);
                if (sonuc>0)
                {
                    HataYonetimi.Bilgilendirme("Hayvan Silme", "Seçili Hayvan Silindi.");
                }
            }
            else
            {
                HataYonetimi.UyariVer("Hayvan Silme", "Lütfen Tablodan Hayvan Seçiniz.");
            }
        }

        private void Hayvan_Sec_Grid(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewHayvanArama.SelectedRows)
            {
                datagrid_secili_satir =Convert.ToInt32(row.Cells[0].Value);
                Kupe = row.Cells[5].Value.ToString();
            }
        }

        private void btnHayvanBilgiGuncelle_Click(object sender, EventArgs e)
        {
            if (datagrid_secili_satir<=0)
            {
                HataYonetimi.UyariVer("Hayvan Güncelleme", "Lütfen Tablodan Hayvan Seçiniz.");
            }
            else
            {
                HayvanGuncelle hk = new HayvanGuncelle();
                hk.Show();
            }
        }

        private void btnMuaneyeKaydi_Click(object sender, EventArgs e)
        {
            if (datagrid_secili_satir <= 0)
            {
                HataYonetimi.UyariVer("Muayene Kaydı", "Lütfen Tablodan Hayvan Seçiniz.");
            }
            else
            {
                HayvanMuayeneIslemleri hk = new HayvanMuayeneIslemleri();
                hk.Show();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
