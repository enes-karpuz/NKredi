using NKredi.DataAccessLayer;
using NKredi.DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nkredi.BusinessLogicLayer
{
    public class SKullanici
    {
        public SKullanici()
        {
        }

        public List<Kullanici> GetirKullaniciListesi()
        {
            EKullanici ekullanici = new EKullanici();
            try
            {
                return ekullanici.GetirKullanici();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool EkleKullanici(Kullanici kullanici)
        {
            EKullanici ekullanici = new EKullanici();
            SKullaniciTipi sKullaniciTipi = new SKullaniciTipi();
            try
            {
                var kullaniciTipi = sKullaniciTipi.OkuKullaniciTipi(kullanici.Tipi);
                if (kullaniciTipi.Id != 0)
                {
                    ekullanici.EkleKullanici(kullanici);
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                throw;
            }            
        }

        public Kullanici OkuKullanici(int id)
        {
            EKullanici ekullanici = new EKullanici();
            try
            {
                return ekullanici.OkuKullanici(id);
            }
            catch (Exception)
            {
                throw;
            }
            
        }

        public bool GuncelleKullanici(Kullanici kullanici)
        {
            EKullanici ekullanici = new EKullanici();
            try
            {
                ekullanici.GuncelleKullanici(kullanici);
                return true;
            }
            catch (Exception)
            {
                throw;
            }
            
        }

        public bool SilKullanici(int id)
        {
            EKullanici ekullanici = new EKullanici();
            try
            {
                ekullanici.SilKullanici(id);
                return true;
            }
            catch (Exception)
            {
                throw;
            }            
        }

        public string ReadPasswordByEmail(string email)
        {
            EKullanici eKullanici = new EKullanici();
            return eKullanici.ReadPasswordByEmail(email);
        }
        public bool IsPasswordCorrect(Kullanici kullanici)
        {
            //string kullaniciSifre = ReadPasswordByEmail(kullanici.email);

            //if (kullaniciSifre == kullanici.Sifre)
            //{
            //    return true;
            //}
            //return false;
            if (ReadPasswordByEmail(kullanici.email) == null)
            {
                return false;
            }
            return true;
        }
    }
}
