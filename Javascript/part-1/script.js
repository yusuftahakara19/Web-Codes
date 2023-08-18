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

if (x > y && x > z) {
  console.log("x en büyük");
} else if (y > x && y > z) {
  console.log("y en büyük");
} else if (z > x && z > y) {
  console.log("z en büyük");
} else {
  console.log("sayilar eşit");
}

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

var vize1 = 10,
  vize2 = 10,
  final = 80,
  ortalama = 0;
ortalama = (vize1 + vize2 + final) / 3;

if (final > 70) {
  console.log("gecti");
} else if (ortalama > 50) {
  console.log("gecti");
} else {
  console.log("kaldi.");
}
