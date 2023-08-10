using NKredi.DataAccessLayer;
using NKredi.DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nkredi.BusinessLogicLayer
{
    public class SKullanici
    {
        public SKullanici()
        {
        }

        public List<Kullanici> GetirKullaniciListesi()
        {
            EKullanici ekullanici = new EKullanici();
            return ekullanici.GetirKullanici();
        }
        public bool EkleKullanici(Kullanici kullanici)
        {
            EKullanici ekullanici = new EKullanici();
            ekullanici.EkleKullanici(kullanici);
            return true;
        }
        public Kullanici OkuKullanici(int id)
        {
            EKullanici ekullanici = new EKullanici();
            return ekullanici.OkuKullanici(id);
        }
        public bool GuncelleKullanici(Kullanici kullanici)
        {
            EKullanici ekullanici = new EKullanici();
            ekullanici.GuncelleKullanici(kullanici);
            return true;
        }
        public bool SilKullanici(int id)
        {
            EKullanici ekullanici = new EKullanici();
            ekullanici.SilKullanici(id);
            return true;
        }
    }
}
