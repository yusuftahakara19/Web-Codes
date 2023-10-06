function Soru(soruMetni, cevapSecenekleri, dogruCevap) {
  this.soruMetni = soruMetni;
  this.cevapSecenekleri = cevapSecenekleri;
  this.dogruCevap = dogruCevap;
}

Soru.prototype.cevabiKontrolEt = function (cevap) {
  return cevap === this.dogruCevap;
};

let sorular = [
  new Soru(
    "Hangisi javascript paket yönetim uygulasıdır?",
    { a: "Node.js", b: "Typescript", c: "Npm", d: "Nuget" },
    "c"
  ),
  new Soru(
    "Hangisi frontend kapsamında değerlendirilmez?",
    { a: "css", b: "html", c: "javascipt", d: "sql" },
    "d"
  ),
  new Soru(
    "Hangisi backend kapsamında değerlendirilir?",
    { a: "node.js", b: "typescript", c: "angular", d: "react" },
    "a"
  ),
  new Soru(
    "Hangisi javascript programlama dilini kullanmaz?",
    { a: "react", b: "angular", c: "vuejs", d: "asp.net" },
    "d"
  ),
];
