using Microsoft.AspNetCore.Mvc;
using Nkredi.BusinessLogicLayer;
using NKredi.DataAccessLayer.Entities;

namespace NKredi.PresentationLayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BankaController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Banka> GetirBanka()
        {
            SBanka sBanka = new SBanka();
            return sBanka.GetirBanka();
        }

        [HttpPost]
        public bool EkleBanka(Banka banka)
        {
            SBanka sBanka = new SBanka();
            return sBanka.EkleBanka(banka);
        }
        [HttpPut]
        public bool GuncelleBanka(Banka banka)
        {
            SBanka sBanka = new SBanka();
            sBanka.GuncelleBanka(banka);
            return true;
        }
        [HttpGet("Id")]
        public Banka OkuBanka(int id)
        {
            SBanka sBanka = new SBanka();
            return sBanka.OkuBanka(id);
        }
        [HttpDelete("Id")]
        public bool SilBanka(int id)
        {
            SBanka sBanka = new SBanka();
            sBanka.SilBanka(id);
            return true;
        }
    }
}
