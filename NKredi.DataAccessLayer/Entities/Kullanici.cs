using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NKredi.DataAccessLayer.Entities
{
    public class Kullanici
    {
        public int Id { get; set; }
        public int Tipi { get; set; }
        public string? Ad { get; set; }
        public string? Soyad { get; set; }
        public string email { get; set; }
        public string Sifre { get; set; }
        public DateTime DogumTarihi { get; set; }
    }
}
