using NKredi.DataAccessLayer.Entities;
using NKredi.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nkredi.BusinessLogicLayer
{
    public class SBanka
    {
        public SBanka()
        {
        }
        public List<Banka> GetirBanka()
        {
            EBanka ebanka = new EBanka();
            return ebanka.GetirBanka();
        }
        public bool EkleBanka(Banka banka)
        {
            EBanka ebanka = new EBanka();
            ebanka.EkleBanka(banka);
            return true;
        }
        public Banka OkuBanka(int id)
        {
            EBanka ebanka = new EBanka();
            return ebanka.OkuBanka(id);
        }
        public bool GuncelleBanka(Banka banka)
        {
            EBanka ebanka = new EBanka();
            ebanka.GuncelleBanka(banka);
            return true;
        }
        public bool SilBanka(int id)
        {
            EBanka ebanka = new EBanka();
            ebanka.SilBanka(id);
            return true;
        }
    }
}
