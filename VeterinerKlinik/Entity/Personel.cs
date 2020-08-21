using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterinerKlinik.Entity
{
   public class Personel: BaseEntity
    {
        public string TC { get; set; }
        public int PersonelNo { get; set; }
        public string PerTur { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Eposta { get; set; }
        public string TelNo { get; set; }
        public int Cinsiyet { get; set; } 
        public DateTime DogumTar { get; set; }
        public string Sifre { get; set; }
    }
}
