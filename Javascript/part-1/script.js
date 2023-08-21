// var ogrAd = "Ada Bilgi";

// var ogrOrt = (70 + 70 + 80) / 3;
// console.log(parseInt(ogrOrt));
// var dogumTarihi = "2012";

// let suAnkiYil = new Date().getFullYear();
// var yas = suAnkiYil - dogumTarihi;
// console.log(yas);

// var a = 10;
// sonuc = ++a;
// console.log(sonuc);
// console.log(a);

// var a = 10;
// var b = 12;
// sonuc = a != b;
// console.log(sonuc);

// var sonuc = 3 == "3";
// console.log(sonuc);
// var sonuc = 3 === "3";
// console.log(sonuc);

// xyz en büyük
// var x = 19;
// var y = 19;
// var z = 21;

// if (x > y && x > z) {
//   console.log("x en büyük");
// } else if (y > x && y > z) {
//   console.log("y en büyük");
// } else if (z > x && z > y) {
//   console.log("z en büyük");
// } else {
//   console.log("sayilar eşit");
// }

// 2 vize ve 1 final notuna göre hesaplama
// a- ortalama >50 ve final >50
//   var vize1 = 50,
//   vize2 = 80,
//   final = 80,
//   ortalama = 0;
//   ortalama = (vize1 + vize2 + final) / 3;

// if (ortalama > 50 && final > 50) {
//   console.log("gecti");
// } else {
//   console.log("kaldi");
// }

// c- finalden  70 alındığında ortalama 50'nin altında olsa bile geçersin

// var vize1 = 10,
//   vize2 = 10,
//   final = 80,
//   ortalama = 0;
// ortalama = (vize1 + vize2 + final) / 3;

// if (final > 70) {
//   console.log("gecti");
// } else if (ortalama > 50) {
//   console.log("gecti");
// } else {
//   console.log("kaldi.");
// }

// STRING and Ternary OperatorsS
// let ad = "Yusuf";
// let yas = 24;
// let emeklilikSinir = 65;
// let emeklilikDurumu =
//   emeklilikSinir - yas > 0
//     ? `Emekliliğinize ${emeklilikSinir - yas} yil kaldi.`
//     : `Emeklilik yaşını geçtiniz`;
// console.log(`Merhaba ben ${ad}. Emeklilik durumum : ${emeklilikDurumu}`);

// STRING METOTLARI
// let kursAdi = "Komple Uygulamalı Web Gelistirme";
// let sonuc;

// sonuc = kursAdi.toUpperCase();
// sonuc = kursAdi.toLowerCase();
// sonuc = kursAdi.length;
// sonuc = kursAdi.slice(0, 5);
// sonuc = kursAdi.slice(10);
// sonuc = kursAdi.slice(-10);
// sonuc = kursAdi.trim();
// sonuc = kursAdi.trimEnd();
// sonuc = kursAdi.indexOf("Komple");
// sonuc = kursAdi.split(" ");
// sonuc = kursAdi.split(" ")[0];

// console.log(sonuc);
// console.log(kursAdi);

// STRING UYGULAMA
// let url = "https://sadikturan.com/";
// let kursAdi = "Komple Web Geliştirme Eğitimi";

// let urlKarakterSayisi = url.length;
// let kursDiziUzunluk = kursAdi.split(" ").length;

// let httpsBaslamaDurumu = url.indexOf("https") == 0 ? true : false;
// let httpsBaslamaDurumu2 = url.startsWith("https");
// let kelimeVarMi = kursAdi.indexOf("Eğitimi") != -1 ? true : false;

// kursAdi = kursAdi.toLowerCase();
// kursAdi = kursAdi.replaceAll(" ", "-");

// console.log(`url karakter sayisi : ${urlKarakterSayisi}`);
// console.log(`kursAdi kaç kelimeden olusmaktadir : ${kursDiziUzunluk}`);
// console.log(`url https ile mi başlıyor : ${httpsBaslamaDurumu}`);
// console.log(`url https ile mi başlıyor 2: ${httpsBaslamaDurumu2}`);
// console.log(`kursAdi içerisinde Eğitimi kelimesi var mı : ${kelimeVarMi}`);
// console.log(url + "/" + kursAdi);

// Numbers
// let sonuc;
// sonuc = "10";
// sonuc = Number("10");
// sonuc = parseInt("10.6");
// sonuc = parseFloat("10.6");

// let sayi = 15.127456789;
// sonuc = sayi.toPrecision(5);
// console.log(sonuc);
// sonuc = sayi.toFixed(2);
// console.log(sonuc);

// sonuc = Math.round(2.4);
// console.log(sonuc);

// sonuc = Math.ceil(2.4);
// console.log(sonuc);

// sonuc = Math.floor(2.7);
// console.log(sonuc);

// sonuc = Math.sqrt(25);
// console.log(sonuc);

// sonuc = Math.pow(2, 5);
// console.log(sonuc);

// sonuc = Math.abs(-20);
// console.log(sonuc);

// sonuc = Math.min(1, 45, 25, 68, -10);
// console.log(sonuc);

// sonuc = Math.random() * 10;
// console.log(sonuc);

//Dates & Times
// let simdi = new Date();
// let sonuc = simdi;

// sonuc = simdi.getDate();
// sonuc = simdi.getDay();

// // simdi.setFullYear(2025);
// // simdi.setMonth(7);
// // simdi.setDate(19);
// sonuc = simdi;
// console.log(simdi);

// // let dogumTarihi = new Date(2000, 6, 19);
// sonuc = simdi - dogumTarihi;
// console.log("Yaş  : " + sonuc);

let simdi = new Date();
let dogumTarihi = new Date(2000, 6, 3);
let farkMilisaniye = simdi - dogumTarihi;

// Milisaniyeyi saniyeye çevirme
let farkSaniye = Math.floor(farkMilisaniye / 1000);

// Saniyeyi güne çevirme
let farkGun = Math.floor(farkSaniye / (60 * 60 * 24));

// Güneyi ay ve yıla çevirme
let farkAy = Math.floor(farkGun / 30.44);
let farkYil = Math.floor(farkAy / 12);

console.log("Saniye: " + farkSaniye);
console.log("Gün: " + farkGun);
console.log("Ay: " + farkAy);
console.log("Yıl: " + farkYil);
console.log(
  "Yaş: " +
    farkYil +
    " yıl " +
    (farkAy % 12) +
    " ay " +
    (farkGun % 30.44) +
    " gün"
);
