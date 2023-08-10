using NKredi.DataAccessLayer.Entities;
using NKredi.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nkredi.BusinessLogicLayer
{
    public class SKredi
    {
        public SKredi()
        {
        }

        public List<Kredi> GetirKredi()
        {
            EKredi ekredi = new EKredi();
            return ekredi.GetirKredi();
        }
        public bool EkleKredi(Kredi kredi)
        {
            EKredi ekredi = new EKredi();
            ekredi.EkleKredi(kredi);
            return true;
        }
        public Kredi OkuKredi(int id)
        {
            EKredi ekredi = new EKredi();
            return ekredi.OkuKredi(id);
        }
        public bool GuncelleKredi(Kredi kredi)
        {
            EKredi ekredi = new EKredi();
            ekredi.GuncelleKredi(kredi);
            return true;
        }
        public bool SilKredi(int id)
        {
            EKredi ekredi = new EKredi();
            ekredi.SilKredi(id);
            return true;
        }
    }
}
