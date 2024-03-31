using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProjeDemo2.Entities
{
    public abstract class Personel
    {
        public int Id { get; set; }
        public int TCNO { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string? Aciklama { get; set; }
        public DateTime DogumTarihi { get; set; }
        public DateTime IseBaslamaTarihi { get; set; }
        public DateTime? IsiBirakmaTarihi { get; set; }
    }
}
