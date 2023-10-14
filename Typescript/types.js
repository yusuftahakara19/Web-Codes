var a;
var b;
var c;
var d;
var e = [1, 2, 3];
var f = [1, 2, 3];
var g = [1, "a", true];
var h = ["a", 5, false];
var krediPayment = 0;
var havalePayment = 1;
var eftPayment = 2;
// BUNUN YERİNE ENUM DAHA GÜZEL
var Payment;
(function (Payment) {
    Payment[Payment["kredi"] = 0] = "kredi";
    Payment[Payment["havale"] = 1] = "havale";
    Payment[Payment["eft"] = 2] = "eft";
})(Payment || (Payment = {}));
var kredi = Payment.kredi; //0
var havale = Payment.havale; //1
var eft = Payment.eft; //2
//Başlangıçta değer ataması da yapabilirsin. Böylece sonradan bir şeyler eklediğinde enum içindeki değerler değişmemiş olur.
var Payment2;
(function (Payment2) {
    Payment2[Payment2["kredi"] = 0] = "kredi";
    Payment2[Payment2["havale"] = 1] = "havale";
    Payment2[Payment2["kap\u0131daOdeme"] = 3] = "kap\u0131daOdeme";
    Payment2[Payment2["left"] = 2] = "left";
})(Payment2 || (Payment2 = {}));
