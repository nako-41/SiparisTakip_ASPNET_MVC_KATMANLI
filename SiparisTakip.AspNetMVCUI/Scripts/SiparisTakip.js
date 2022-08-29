const { Modal } = require("../Content/js/bootstrap.bundle");

function KullaniciGiris() {
    try {
        var kkodu = $('#KullaniciKodu').val();
        var psw = $("#Parola").val();

        if (kkodu === "") {
            ModalBilgilendirme("UYARI", "Kullanıcı kodu bos gecilemez");
            return false;
        }
        if (psq === "") {
            alert('psw');
            ModalBilgilendirme("UYARI", "Parola boş gecilemez");
            return false;
        }
        $.ajax({
            type: "POST",
            url: "/Kullanici/KullaniciGiris",
            content: "application/json",
            dataType: 'json',
            data: $('#FrmKullaniciGiris').serialize(),
            async: true,
            success: function (data) {
                console.log(data);
                if (data.IslemKodu === 1) {
                    window.location.href = "../Anasayfa/Index"
                } else if (data.IslemKodu === 2) {
                    ModalBilgilendirme(IslemSonucTurleri.Hata, data.Aciklama);

                }

            },
            error: function (ex) {
                ModalBilgilendirme(IslemSonucTurleri.Hata, data.Aciklama);
            }
        });
    } catch (e) {
        console.log("Hata :" + e);
    }
}