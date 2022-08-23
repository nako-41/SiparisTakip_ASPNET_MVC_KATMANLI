using DataAccessLayer.Abstract.Stoks;
using Entities.Models;
using Interfaces.Stoks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Stoks
{
    public class StokManager : IStokService
    {  
        IStokDal _stokdal;

        public StokManager(IStokDal stokdal)
        {
            _stokdal = stokdal;
        }

        public Stok Getir(int id)
        {
            return _stokdal.Getir(id);
        }

        public int Guncelle(Stok entity)
        {
            return _stokdal.Guncelle(entity);

        }

        public Stok Kaydet(Stok entity)
        {

            return _stokdal.Kaydet(entity);
        }

        public List<Stok> Listele()
        {
            return _stokdal.Listele();
        }

        public List<Stok> Listele(Expression<Func<Stok, bool>> filter)
        {
            return _stokdal.Listele(filter);
        }

        public bool Sil(int id)
        {
            return _stokdal.Sil(id);
        }

        public bool Sil(Stok entity)
        {
            return _stokdal.Sil(entity);
        }
    }
}
