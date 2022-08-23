using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Faturalar
{
    public interface IFaturaService:IGenericService<Fatura>
    {
       // IQueryable FaturaRaporu(Expression<Func<Fatura,bool>> filter);
        IQueryable FaturaRaporu(DateTime baslangic,DateTime bitis);
    }
}
