using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Kullanıcı
{
    public interface IKullaniciService:IGenericService<Kullanici>
    {
        Kullanici KullaniciGiris(string kullaniciAdi,string parola);



    }
}
