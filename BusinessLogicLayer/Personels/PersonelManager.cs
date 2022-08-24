using DataAccessLayer.Abstract.Personels;
using Entities.Models;
using Interfaces.Personels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Personels
{
    public class PersonelManager : IPersonelService
    {
        IPersonelDal _personelDal;

        public PersonelManager(IPersonelDal personelDal)
        {
            _personelDal = personelDal;
        }

        public Personel Getir(int id)
        {
            return _personelDal.Getir(id);
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
