using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterinerKlinik.Entity
{
    public class BaseEntity
    {
        [Key]
        public int Id { get; set; }
        public int Olusturan { get; set; }
        public int Guncelleyen { get; set; }
        public static DateTime? OlusTar { get; set; }
        public static DateTime? GuncelTar { get; set; }
        public string NullTarih { get; set; } = "1800-01-01 01:01:01";
        public bool IsActive { get; set; }
    }
}
