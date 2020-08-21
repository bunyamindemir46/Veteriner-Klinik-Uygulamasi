using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterinerKlinik.Entity
{
    public class Hayvan:BaseEntity
    {
        public string KupeNo { get; set; }
        public string Ad { get; set; }
        public string AnaKupeNo { get; set; }
        public string BabaKupeNo { get; set; }
        public string IlId { get; set; }
        public DateTime DogTar { get; set; }
        public string Tip { get; set; }
        public string Cins { get; set; }
        public string  Cinsiyet { get; set; }
        public int Kilo { get; set; }
        public int Boy{ get; set; }
        public string SahipTC { get; set; }
        public string SahipCepTel { get; set; }
        public string  Adres { get; set; }
    }
}
