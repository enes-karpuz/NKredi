using Microsoft.AspNetCore.Mvc;
using Nkredi.BusinessLogicLayer;
using NKredi.DataAccessLayer;
using NKredi.DataAccessLayer.Entities;

namespace NKredi.PresentationLayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KullaniciTipiController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<KullaniciTipi> GetirKullaniciTipiListesi()
        {
            SKullaniciTipi sKullaniciTipi = new SKullaniciTipi();
            return sKullaniciTipi.GetirKullaniciTipiListesi();
        }

        [HttpPost]
        public bool EkleKullaniciTipi(KullaniciTipi kullaniciTipi)
        {
            SKullaniciTipi sKullaniciTipi = new SKullaniciTipi();
            return sKullaniciTipi.EkleKullaniciTipi(kullaniciTipi);
        }
        [HttpPut]
        public bool GuncelleKullaniciTipi(KullaniciTipi kullaniciTipi)
        {
            SKullaniciTipi sKullaniciTipi = new SKullaniciTipi();
            sKullaniciTipi.GuncelleKullaniciTipi(kullaniciTipi);
            return true;
        }
        [HttpGet("Id")]
        public KullaniciTipi OkuKullaniciTipi(int id)
        {
            SKullaniciTipi sKullaniciTipi = new SKullaniciTipi();
            return sKullaniciTipi.OkuKullaniciTipi(id);
        }
        [HttpDelete("Id")]
        public bool SilKullaniciTipi(int id)
        {
            SKullaniciTipi sKullaniciTipi = new SKullaniciTipi();
            sKullaniciTipi.SilKullaniciTipi(id);
            return true;
        }
    }
}
