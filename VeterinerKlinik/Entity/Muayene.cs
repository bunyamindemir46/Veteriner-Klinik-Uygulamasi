using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterinerKlinik.Entity
{
    public class Muayene:BaseEntity
    {
        public string KupeNo { get; set; }
        public string Sikayet { get; set; }
        public string Tani { get; set; }
        public string Tedavi { get; set; }
        public string Ilaclar { get; set; }
        public string Alerji { get; set; }
    }
}
