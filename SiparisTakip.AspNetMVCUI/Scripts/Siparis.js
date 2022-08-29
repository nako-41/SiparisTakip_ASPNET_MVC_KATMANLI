var IslemSonucTurleri = {
    Basarili: "BASAILI",
    Hata: "HATA",
    Uyari: "UYARI",
    Bilgi: "BILGI"
};

var ISlemSonucKodlari =
{
    Basarili: 1,
    Hata: 2,
    Uyari: 3,
    Bİlgi: 4
};


function ModalBilgilendirme(baslik, aciklama) {
    $("#MdlBaslik").text(baslik);
    $("#MdlAciklama").text(aciklama);
    ModalGoster("MdlBilgilendirme");

}

function ModalGoster(modalId) {
    $("#" + modalId).modal("show");
}
function ModalKapat(modalId) {
    $("#" + modalId).modal("hide");
}