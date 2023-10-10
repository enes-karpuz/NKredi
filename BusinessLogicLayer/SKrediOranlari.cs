using NKredi.DataAccessLayer.Entities;
using NKredi.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nkredi.BusinessLogicLayer
{
    public class SKrediOranlari
    {
        public SKrediOranlari()
        {
        }
        public List<KrediOranlari> GetirKrediOrani()
        {
            EKrediOranlari ekrediOrani = new EKrediOranlari();
            return ekrediOrani.GetirKrediOrani();
        }
        public bool EkleKrediOrani(KrediOranlari krediOranlari)
        {
            EKrediOranlari ekrediOrani = new EKrediOranlari();
            ekrediOrani.EkleKrediOrani(krediOranlari);
            return true;
        }
        public KrediOranlari OkuKrediOrani(int id)
        {
            EKrediOranlari ekrediOrani = new EKrediOranlari();
            return ekrediOrani.OkuKrediOrani(id);
        }
        public bool GuncelleKrediOrani(KrediOranlari krediOranlari)
        {
            EKrediOranlari ekrediOrani = new EKrediOranlari();
            ekrediOrani.GuncelleKrediOrani(krediOranlari);
            return true;
        }
        public bool SilKrediOrani(int id)
        {
            EKrediOranlari ekrediOrani = new EKrediOranlari();
            ekrediOrani.SilKrediOrani(id);
            return true;
        }
    }
}
