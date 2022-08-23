using DataAccessLayer.Abstract.FaturaDal;
using Entities.Models;
using Interfaces.Faturalar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Faturalar
{
    public class FaturaManager : IFaturaService
    {
        IFaturaDal _faturaDal;

        public FaturaManager(IFaturaDal faturaDal)
        {
            _faturaDal = faturaDal;
        }

        public IQueryable FaturaRaporu(DateTime baslangic, DateTime bitis)
        {
            return _faturaDal.FaturaRaporu(baslangic,bitis);
        }

        public Fatura Getir(int id)
        {
            return _faturaDal.Getir(id);
        }

        public int Guncelle(Fatura entity)
        {
            return _faturaDal.Guncelle(entity);
        }

        public Fatura Kaydet(Fatura entity)
        {
            return _faturaDal.Kaydet(entity);
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
