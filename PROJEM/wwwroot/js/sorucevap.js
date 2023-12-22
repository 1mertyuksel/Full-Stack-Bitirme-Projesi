// wwwroot/sorucevap.js//
function cevaplarıKontrolEt() {
    let score = 0; // Skoru dışarıda tanımla

    for (let i = 1; i <= 5; i++) {
        let formId = i;
        let secilenCevap = document.querySelector('input[name="cevap' + formId + '"]:checked');

        // Soruya özel doğru cevapları belirleyebilirsiniz
        let dogruCevap;

        switch (formId) {
            case 1:
                dogruCevap = "A";
                break;
            case 2:
                dogruCevap = "C";
                break;
            case 3:
                dogruCevap = "A";
                break;
            case 4:
                dogruCevap = "A";
                break;
            case 5:
                dogruCevap = "A";
                break;
            default:
                dogruCevap = "";
        }

        if (secilenCevap && secilenCevap.value === dogruCevap) {
            score += 10;
        }
    }

    if (score >= 40) {
        alert("Tebrikler! Testi geçtiniz. Toplam Puan: " + score);
    } else {
        alert("Maalesef, başarısız oldunuz. Toplam Puan: " + score);
    }
}
