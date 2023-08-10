using NKredi.DataAccessLayer.Entities;
using NKredi.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nkredi.BusinessLogicLayer
{
    public class SKullaniciTipi
    {
        public SKullaniciTipi()
        {
        }
        public List<KullaniciTipi> GetirKullaniciTipiListesi()
        {
            EKullaniciTipi ekullaniciTipi= new EKullaniciTipi();
            return ekullaniciTipi.GetirKullaniciTipi();
        }
        public bool EkleKullaniciTipi(KullaniciTipi kullaniciTipi)
        {
            EKullaniciTipi ekullaniciTipi = new EKullaniciTipi();
            ekullaniciTipi.EkleKullaniciTipi(kullaniciTipi);
            return true;
        }
        public KullaniciTipi OkuKullaniciTipi(int id)
        {
            EKullaniciTipi ekullaniciTipi = new EKullaniciTipi();
            return ekullaniciTipi.OkuKullaniciTipi(id);
        }
        public bool GuncelleKullaniciTipi(KullaniciTipi kullaniciTipi)
        {
            EKullaniciTipi ekullaniciTipi = new EKullaniciTipi();
            ekullaniciTipi.GuncelleKullaniciTipi(kullaniciTipi);
            return true;
        }
        public bool SilKullaniciTipi(int id)
        {
            EKullaniciTipi ekullaniciTipi = new EKullaniciTipi();
            ekullaniciTipi.SilKullaniciTipi(id);
            return true;
        }
    }
}
