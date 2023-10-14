let a: number;
let b: string;
let c: boolean;
let d: any;
let e: number[] = [1, 2, 3];
let f: Array<number> = [1, 2, 3];
let g: any[] = [1, "a", true];
let h: [string, number, boolean] = ["a", 5, false];

const krediPayment = 0;
const havalePayment = 1;
const eftPayment = 2;

// BUNUN YERİNE ENUM DAHA GÜZEL

enum Payment {
  kredi,
  havale,
  eft,
}

let kredi = Payment.kredi; //0
let havale = Payment.havale; //1
let eft = Payment.eft; //2

//Başlangıçta değer ataması da yapabilirsin. Böylece sonradan bir şeyler eklediğinde enum içindeki değerler değişmemiş olur.
enum Payment2 {
  kredi = 0,
  havale = 1,
  kapıdaOdeme = 3,
  left = 2,
}
