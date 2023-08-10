using NKredi.DataAccessLayer.Entities;
using NKredi.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nkredi.BusinessLogicLayer
{
    public class SDovizCinsi
    {
        public SDovizCinsi()
        {
        }
        public List<DovizCinsi> GetirDoviz()
        {
            EDovizCinsi eDovizCinsi = new EDovizCinsi();
            return eDovizCinsi.GetirDoviz();
        }
        public bool EkleDoviz(DovizCinsi dovizCinsi)
        {
            EDovizCinsi eDovizCinsi = new EDovizCinsi();
            eDovizCinsi.EkleDoviz(dovizCinsi);
            return true;
        }
        public DovizCinsi OkuDoviz(int id)
        {
            EDovizCinsi eDovizCinsi = new EDovizCinsi();
            return eDovizCinsi.OkuDoviz(id);
        }
        public bool GuncelleDoviz(DovizCinsi dovizCinsi)
        {
            EDovizCinsi eDovizCinsi = new EDovizCinsi();
            eDovizCinsi.GuncelleDoviz(dovizCinsi);
            return true;
        }
        public bool SilDoviz(int id)
        {
            EDovizCinsi eDovizCinsi = new EDovizCinsi();
            eDovizCinsi.SilDoviz(id);
            return true;
        }
    }
}
