using Microsoft.AspNetCore.Mvc;
using Nkredi.BusinessLogicLayer;
using NKredi.DataAccessLayer.Entities;

namespace NKredi.PresentationLayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KrediOranlariController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<KrediOranlari> GetirKrediOrani()
        {
            SKrediOranlari sKrediOranlari = new SKrediOranlari();
            return sKrediOranlari.GetirKrediOrani();
        }

        [HttpPost]
        public bool EkleKrediORani(KrediOranlari krediOranlari)
        {
            SKrediOranlari sKrediOranlari = new SKrediOranlari();
            return sKrediOranlari.EkleKrediOrani(krediOranlari);
        }
        [HttpPut]
        public bool GuncelleKrediORani(KrediOranlari krediOranlari)
        {
            SKrediOranlari sKrediOranlari = new SKrediOranlari();
            sKrediOranlari.GuncelleKrediOrani(krediOranlari);
            return true;
        }
        [HttpGet("Id")]
        public KrediOranlari OkuKrediOrani(int id)
        {
            SKrediOranlari sKrediOranlari = new SKrediOranlari();
            return sKrediOranlari.OkuKrediOrani(id);
        }
        [HttpDelete("Id")]
        public bool SilKrediOrani(int id)
        {
            SKrediOranlari sKrediOranlari = new SKrediOranlari();
            sKrediOranlari.SilKrediOrani(id);
            return true;
        }
    }
}
