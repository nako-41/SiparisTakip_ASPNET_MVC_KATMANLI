using Interfaces.Stoks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Stok
{
    public class StokManager : IStokService
    {
        public Entities.Models.Stok Getir(int id)
        {
            throw new NotImplementedException();
        }

        public int Guncelle(Entities.Models.Stok entity)
        {
            throw new NotImplementedException();
        }

        public Entities.Models.Stok Kaydet(Entities.Models.Stok entity)
        {
            throw new NotImplementedException();
        }

        public List<Entities.Models.Stok> Listele()
        {
            throw new NotImplementedException();
        }

        public List<Entities.Models.Stok> Listele(Expression<Func<Entities.Models.Stok, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public bool Sil(int id)
        {
            throw new NotImplementedException();
        }

        public bool Sil(Entities.Models.Stok entity)
        {
            throw new NotImplementedException();
        }
    }
}
