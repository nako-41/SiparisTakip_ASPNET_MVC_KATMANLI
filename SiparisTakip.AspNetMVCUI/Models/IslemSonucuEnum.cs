using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace SiparisTakip.AspNetMVCUI.Models
{
    public class IslemSonucuEnum                                        
    {
        public enum IslemSonucKodlari
        {
            [Description("BASARILI")]
            Basarili=1,
            [Description("HATA")]
            Hata = 2,
            [Description("UYARI")]
            Uyari = 3,
            [Description("BILGILENDIRME")]
            Bilgilendirme = 4
        }

    }
}