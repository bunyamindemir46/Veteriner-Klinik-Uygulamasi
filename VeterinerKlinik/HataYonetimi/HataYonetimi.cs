using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VeterinerKlinik
{
    public class HataYonetimi
    {
        public static void UyariVer(string baslik, string icerik)
        {
            MessageBox.Show(icerik, baslik, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        public static void Bilgilendirme(string baslik, string icerik)
        {
            MessageBox.Show(icerik, baslik, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static void HataVer(string baslik, string icerik)
        {
            MessageBox.Show(icerik, baslik, MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
    }
}
