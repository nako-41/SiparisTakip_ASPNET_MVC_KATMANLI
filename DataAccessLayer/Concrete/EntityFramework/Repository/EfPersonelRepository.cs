using DataAccessLayer.Abstract.Personels;
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
    public class EfPersonelRepository : IPersonelDal
    {
        SiparisTakipContext context = new SiparisTakipContext();

        public Personel Getir(int id)
        {
            throw new NotImplementedException();
        }

        public int Guncelle(Personel entity)
        {
            throw new NotImplementedException();
        }

        public Personel Kaydet(Personel entity)
        {
            throw new NotImplementedException();
        }

        public List<Personel> Listele()
        {
            throw new NotImplementedException();
        }

        public List<Personel> Listele(Expression<Func<Personel, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public bool Sil(int id)
        {
            throw new NotImplementedException();
        }

        public bool Sil(Personel entity)
        {
            throw new NotImplementedException();
        }
    }
}
