using DataAccessLayer.Abstract.FaturaDal;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.EntityFramework.Repository
{
    public class EfFaturaRepository : IFaturaDal
    {
        public IQueryable FaturaRaporu(DateTime baslangic, DateTime bitis)
        {
            throw new NotImplementedException();
        }

        public Fatura Getir(int id)
        {
            throw new NotImplementedException();
        }

        public int Guncelle(Fatura entity)
        {
            throw new NotImplementedException();
        }

        public Fatura Kaydet(Fatura entity)
        {
            throw new NotImplementedException();
        }

        public List<Fatura> Listele()
        {
            throw new NotImplementedException();
        }

        public List<Fatura> Listele(Expression<Func<Fatura, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public bool Sil(int id)
        {
            throw new NotImplementedException();
        }

        public bool Sil(Fatura entity)
        {
            throw new NotImplementedException();
        }
    }
}
