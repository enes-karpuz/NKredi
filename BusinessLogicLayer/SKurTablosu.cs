using NKredi.DataAccessLayer.Entities;
using NKredi.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nkredi.BusinessLogicLayer
{
    public class SKurTablosu
    {
        public SKurTablosu()
        {
        }
        public List<KurTablosu> GetirKur()
        {
            EKurTablosu eKurTablosu = new EKurTablosu();
            return eKurTablosu.GetirKur();
        }
        public bool EkleKur(KurTablosu kurTablosu)
        {
            EKurTablosu eKurTablosu = new EKurTablosu();
            eKurTablosu.EkleKur(kurTablosu);
            return true;
        }
        public KurTablosu OkuKur(int id)
        {
            EKurTablosu eKurTablosu = new EKurTablosu();
            return eKurTablosu.OkuKur(id);
        }
        public bool GuncelleKur(KurTablosu kurTablosu)
        {
            EKurTablosu eKurTablosu = new EKurTablosu();
            eKurTablosu.GuncelleKur(kurTablosu);
            return true;
        }
        public bool SilKur(int id)
        {
            EKurTablosu eKurTablosu = new EKurTablosu();
            eKurTablosu.SilKur(id);
            return true;
        }
    }
}
