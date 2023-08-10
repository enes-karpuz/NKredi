using Microsoft.AspNetCore.Mvc;
using NKredi.DataAccessLayer;
using NKredi.DataAccessLayer.Entities;
using Nkredi.BusinessLogicLayer;

namespace NKredi.PresentationLayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KullaniciController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Kullanici> GetirKullaniciListesi()
        {
            SKullanici sKullanici = new SKullanici();
            return sKullanici.GetirKullaniciListesi();
        }

        [HttpPost]
        public bool EkleKullanici(Kullanici kullanici)
        {
            SKullanici sKullanici = new SKullanici();
            return sKullanici.EkleKullanici(kullanici);
        }
        [HttpPut]
        public bool GuncelleKullanici(Kullanici kullanici)
        {
            SKullanici sKullanici = new SKullanici();
            sKullanici.EkleKullanici(kullanici);
            return true;
        }
        [HttpGet("Id")]
        public Kullanici OkuKullanici(int id)
        {
            SKullanici sKullanici = new SKullanici();
            return sKullanici.OkuKullanici(id);
        }
        [HttpDelete("Id")]
        public bool SilKullanici(int id)
        {
            SKullanici sKullanici = new SKullanici();
            sKullanici.SilKullanici(id);
            return true;
        }
    }
}
