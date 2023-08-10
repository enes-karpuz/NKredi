using Microsoft.AspNetCore.Mvc;
using Nkredi.BusinessLogicLayer;
using NKredi.DataAccessLayer.Entities;

namespace NKredi.PresentationLayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KrediController : Controller
    {
        [HttpGet]
        public IEnumerable<Kredi> GetirKredi()
        {
            SKredi sKredi = new SKredi();
            return sKredi.GetirKredi();
        }

        [HttpPost]
        public bool EkleKredi(Kredi kredi)
        {
            SKredi sKredi = new SKredi();
            return sKredi.EkleKredi(kredi);
        }
        [HttpPut]
        public bool GuncelleKredi(Kredi kredi)
        {
            SKredi sKredi = new SKredi();
            sKredi.GuncelleKredi(kredi);
            return true;
        }
        [HttpGet("Id")]
        public Kredi OkuKredi(int id)
        {
            SKredi sKredi = new SKredi();
            return sKredi.OkuKredi(id);
        }
        [HttpDelete("Id")]
        public bool SilKredi(int id)
        {
            SKredi sKredi = new SKredi();
            sKredi.SilKredi(id);
            return true;
        }
    }
}
