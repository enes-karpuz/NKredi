using Microsoft.AspNetCore.Mvc;
using Nkredi.BusinessLogicLayer;
using NKredi.DataAccessLayer;
using NKredi.DataAccessLayer.Entities;

namespace NKredi.PresentationLayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DovizCinsiController : Controller
    {
        [HttpGet]
        public IEnumerable<DovizCinsi> GetirDoviz()
        {
            SDovizCinsi sDovizCinsi = new SDovizCinsi();
            return sDovizCinsi.GetirDoviz();
        }

        [HttpPost]
        public bool EkleDoviz(DovizCinsi dovizCinsi)
        {
            SDovizCinsi sDovizCinsi = new SDovizCinsi();
            return sDovizCinsi.EkleDoviz(dovizCinsi);
        }
        [HttpPut]
        public bool GuncelleDoviz(DovizCinsi dovizCinsi)
        {
            SDovizCinsi sDovizCinsi = new SDovizCinsi();
            sDovizCinsi.GuncelleDoviz(dovizCinsi);
            return true;
        }
        [HttpGet("Id")]
        public DovizCinsi OkuDoviz(int id)
        {
            SDovizCinsi sDovizCinsi = new SDovizCinsi();
            return sDovizCinsi.OkuDoviz(id);
        }
        [HttpDelete("Id")]
        public bool SilDoviz(int id)
        {
            SDovizCinsi sDovizCinsi = new SDovizCinsi();
            sDovizCinsi.SilDoviz(id);
            return true;
        }
    }
}
