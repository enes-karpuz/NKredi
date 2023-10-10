using Microsoft.AspNetCore.Mvc;
using Nkredi.BusinessLogicLayer;
using NKredi.DataAccessLayer.Entities;

namespace NKredi.PresentationLayer.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class KurTablosuController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<KurTablosu> GetirBanka()
        {
            SKurTablosu sKurTablosu = new SKurTablosu();
            return sKurTablosu.GetirKur();
        }

        [HttpPost]
        public bool EkleKur(KurTablosu kurTablosu)
        {
            SKurTablosu sKurTablosu = new SKurTablosu();
            return sKurTablosu.EkleKur(kurTablosu);
        }
        [HttpPut]
        public bool GuncelleKur(KurTablosu kurTablosu)
        {
            SKurTablosu sKurTablosu = new SKurTablosu();
            sKurTablosu.GuncelleKur(kurTablosu);
            return true;
        }
        [HttpGet("Id")]
        public KurTablosu OkuKur(int id)
        {
            SKurTablosu sKurTablosu = new SKurTablosu();
            return sKurTablosu.OkuKur(id);
        }
        [HttpDelete("Id")]
        public bool SilKur(int id)
        {
            SKurTablosu sKurTablosu = new SKurTablosu();
            sKurTablosu.SilKur(id);
            return true;
        }
    }
}
