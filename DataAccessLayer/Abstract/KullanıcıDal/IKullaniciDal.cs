using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace DataAccessLayer.Abstract.Stoks
{
    public interface IKullaniciDal
    {
        Kullanici Kaydet(Kullanici entity);
        List<Kullanici> Listele();
        List<Kullanici> Listele(Expression<Func<Kullanici, bool>> filter);
        Kullanici Getir(int id);
        int Guncelle(Kullanici entity);
        bool Sil(int id);
        bool Sil(Kullanici entity);
        Kullanici KullaniciGiris(string kullaniciAdi, string parola);

    }
}
