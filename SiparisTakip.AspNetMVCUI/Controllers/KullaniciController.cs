using BusinessLogicLayer.Kullanıcı;
using DataAccessLayer.Concrete.EntityFramework.Repository;
using Entities.Models;
using Interfaces.Kullanıcı;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SiparisTakip.AspNetMVCUI.Controllers
{
    public class KullaniciController : Controller
    {
        IKullaniciService _kullaniciService = new KullaniciManager(new EfKullaniciRepository());



        [HttpGet]
        public ActionResult KullaniciGiris()
        {
            return View();
        }
        [HttpPost]
        public JsonResult KullaniciGiris(Kullanici kullanici)
        {

            try
            {
               var _kullanici= _kullaniciService.KullaniciGiris(kullanici.KullaniciAdi,kullanici.Parola);
                if (_kullanici!=null)
                {
                    Session["KullaniciId"] = _kullanici.KullaniciID;
                    Session["KullaniciAdi"] = _kullanici.KullaniciAdi + " " + _kullanici.KullaniciSoyadi;
                }
                else
                {

                }

            }
            catch (Exception error)
            {

            }
            return new JsonResult();
        }

    }
}