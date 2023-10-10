using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NKredi.DataAccessLayer.Entities
{
    public class KurTablosu
    {
        public int Id { get; set; }
        public string DovizKodu { get; set; }
        public int Birim { get; set; }
        public string DovizCinsi { get; set; }
        public int DovizAlis { get; set; }
        public int DovizSatis { get; set; }
        public int EfektifAlis { get; set; }
        public int EfektifSatis { get; set; }
    }
}
