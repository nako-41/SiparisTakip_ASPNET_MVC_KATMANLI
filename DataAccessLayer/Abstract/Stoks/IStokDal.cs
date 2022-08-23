using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace DataAccessLayer.Abstract.Stoks
{
    public interface IStokDal
    {
        Stok Kaydet(Stok entity);
        List<Stok> Listele();
        List<Stok> Listele(Expression<Func<Stok,bool>> filter);
        Stok Getir(int id);
        int Guncelle(Stok entity);
        bool Sil(int id);
        bool Sil(Stok entity);
        
    }
}
