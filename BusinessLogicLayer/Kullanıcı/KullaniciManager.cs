using DataAccessLayer.Abstract.Stoks;
using Entities.Models;
using Interfaces.Kullanıcı;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Kullanıcı
{
    public class KullaniciManager : IKullaniciService
    {
        IKullaniciDal _kullaniciDal;

        public KullaniciManager(IKullaniciDal kullaniciDal )
        {
            _kullaniciDal = kullaniciDal;
        }

        public Kullanici Getir(int id)
        {
            throw new NotImplementedException();
        }

        public int Guncelle(Kullanici entity)
        {
            throw new NotImplementedException();
        }

        public Kullanici Kaydet(Kullanici entity)
        {
            throw new NotImplementedException();
        }

        public Kullanici KullaniciGiris(string kullaniciAdi, string parola)
        {
            try
            {
                var kullanici = _kullaniciDal.KullaniciGiris(kullaniciAdi,parola);
                if (kullaniciAdi==null)
                {
                    throw new Exception("kulllanıcı ve parola uyusmuyor");
                }
                else
                {
                    return kullanici;
                }
            }
            catch (Exception ex)
            {

                throw new Exception("kullanıcı giriş hata :" + ex.Message);
            }
        }

        public List<Kullanici> Listele()
        {
            throw new NotImplementedException();
        }

        public List<Kullanici> Listele(Expression<Func<Kullanici, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public bool Sil(int id)
        {
            throw new NotImplementedException();
        }

        public bool Sil(Kullanici entity)
        {
            throw new NotImplementedException();
        }
    }
}
