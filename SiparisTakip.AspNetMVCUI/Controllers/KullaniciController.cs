using BusinessLogicLayer.Kullanıcı;
using DataAccessLayer.Concrete.EntityFramework.Repository;
using Entities.Models;
using Interfaces.Kullanıcı;
using SiparisTakip.AspNetMVCUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using static SiparisTakip.AspNetMVCUI.Models.IslemSonucuEnum;

namespace SiparisTakip.AspNetMVCUI.Controllers
{
    public class KullaniciController : Controller
    {
        IKullaniciService _kullaniciService = new KullaniciManager(new EfKullaniciRepository());

        //IKullaniciService _kullaniciService;

        //public KullaniciController(IKullaniciService kullaniciService)
        //{
        //   this._kullaniciService = kullaniciService;
        //}

        [HttpGet]
        public ActionResult KullaniciGiris()
        {
            return View();
        }
        //[HttpPost]
        //public ActionResult KullaniciGiris(Kullanici kullanici)
        //{ 

        //    try
        //    {
        //       var _kullanici= _kullaniciService.KullaniciGiris(kullanici.KullaniciKodu,kullanici.Parola);
        //        if (_kullanici!=null)
        //        {
        //            Session["KullaniciId"] = _kullanici.KullaniciID;
        //            Session["KullaniciAdi"] = _kullanici.KullaniciAdi + " " + _kullanici.KullaniciSoyadi;
        //            return RedirectToAction("Index","Anasayfa");
        //        }
        //        else
        //        {
                  
        //        }

        //    }
        //    catch (Exception error)
        //    {
        //        //
        //    }
        //    return new JsonResult();
        //}
        [HttpPost]
        public JsonResult KullaniciGiris(Kullanici kullanici)
        {
            IslemSonucModel islemSonuc;
            try
            {
                var _kullanici = _kullaniciService.KullaniciGiris(kullanici.KullaniciKodu, kullanici.Parola);
                if (_kullanici!=null)
                {
                    Session["KullaniciId"] = _kullanici.KullaniciID;
                    Session["KullaniciAdi"] = _kullanici.KullaniciAdi + " " + _kullanici.KullaniciSoyadi;

                    islemSonuc = new IslemSonucModel(IslemSonucKodlari.Basarili,"Kullanıcı Giriş Başarılı");
                }
                else
                {
                    islemSonuc = new IslemSonucModel(IslemSonucKodlari.Hata, "Kullanıcı Giriş Başarısız");
                }
            }
            catch (Exception error)
            {

                islemSonuc = new IslemSonucModel(IslemSonucKodlari.Hata, "Kullanıcı Giris Kontrol sırasında hata olustu." + error.Message);
            }
            return Json(islemSonuc);
        }
    }
}