using DataAccessLayer.Abstract.Stoks;
using DataAcessLayer.Concrete.EntityFramework.Context;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.EntityFramework.Repository
{
    public class EfKullaniciRepository : IKullaniciDal
    {
        SiparisTakipContext context = new SiparisTakipContext();
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
            return context.Kullanici.Where(x=>x.KullaniciAdi==kullaniciAdi && x.Sifre==parola).SingleOrDefault();
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
