using DataAccessLayer.Abstract.Stoks;
using DataAcessLayer.Concrete.EntityFramework.Context;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Linq.Expressions;

namespace DataAccessLayer.Concrete.EntityFramework.Repository
{
    public class EfStokRepository : IStokDal
    {
        //SiparisTakipContext context = new SiparisTakipContext(); 
        public Stok Getir(int id)
        {

            using (SiparisTakipContext context = new SiparisTakipContext())
            {
                return context.Stok.AsNoTracking().Where(x => x.StokID == id).SingleOrDefault();
            }


        }

        public int Guncelle(Stok entity)
        {
            //var result= context.Entry(entity);
            //result.State = EntityState.Modified;
            //context.SaveChanges();

            using (SiparisTakipContext context = new SiparisTakipContext())
            {
                context.Stok.AddOrUpdate(entity);
                return context.SaveChanges();
            }



        }

        public Stok Kaydet(Stok entity)
        {
            using (SiparisTakipContext context = new SiparisTakipContext())
            {
                context.Stok.Add(entity);
                context.SaveChanges();
                return entity;
            }


        }

        public List<Stok> Listele()
        {
            using (SiparisTakipContext context = new SiparisTakipContext())
            {
                return context.Stok.AsNoTracking().ToList();
            }



            //AsNotracking ditek database bakıyor
        }

        public List<Stok> Listele(Expression<Func<Stok, bool>> filter)
        {
            using (SiparisTakipContext context = new SiparisTakipContext())
            {
                return context.Stok.Where(filter).ToList();
            }
        }

        public bool Sil(int id)
        {
            using (SiparisTakipContext context = new SiparisTakipContext())
            {
                var stok = Getir(id);
                return Sil(stok);

            }
        }

        public bool Sil(Stok entity)
        {
            using (SiparisTakipContext context = new SiparisTakipContext())
            {

                context.Stok.Remove(entity);
                return context.SaveChanges() > 0;
            }

        }
    }
}
