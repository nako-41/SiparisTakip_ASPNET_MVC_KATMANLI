using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SiparisTakip.AspNetMVCUI.Models
{
    [JsonObject(MemberSerialization.OptIn)]
    public class IslemSonucModel
    {
        [JsonProperty]
        public int IslemKodu { get; set; }
        [JsonProperty]
        public string Baslik { get; set; }
        [JsonProperty]
        public string Aciklama { get; set; }
        [JsonProperty]
        public string AciklamaDetay { get; set; }
        [JsonProperty]
        public object Data { get; set; }
        public IslemSonucModel()
        {

        }

        public IslemSonucModel(int islemKodu,string baslik,string aciklama,string aciklamaDetay,object data)
        {
            this.IslemKodu = islemKodu;
            this.Baslik = baslik;
            this.Aciklama = aciklama;
            this.AciklamaDetay = aciklamaDetay;
            this.Data = data;
        }
        public IslemSonucModel(IslemSonucuEnum.IslemSonucKodlari islemsonuckodu,string aciklama = "",string aciklamaDetay="",object data=null)
        {
            this.IslemKodu = (int)islemsonuckodu;
            this.Baslik = islemsonuckodu.ToString();
            this.Aciklama = aciklama;
            this.AciklamaDetay = aciklamaDetay;
            this.Data = data;
        }


    }
}