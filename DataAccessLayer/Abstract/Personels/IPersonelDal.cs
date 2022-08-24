using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract.Personels
{
    public interface IPersonelDal
    {
        Personel Kaydet(Personel entity);
        List<Personel> Listele();
        List<Personel> Listele(Expression<Func<Personel, bool>> filter);
        Personel Getir(int id);
        int Guncelle(Personel entity);
        bool Sil(int id);
        bool Sil(Personel entity);
    }
}
