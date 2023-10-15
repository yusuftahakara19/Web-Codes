function getAverage(a: number, b: number, c?: number): string {
  let total = a + b;
  let count = 2;

  if (typeof c != "undefined") {
    total += c;
    count++;
  }
  const result = total / count;

  return "result: " + result;
}

function getAverage2(...a: number[]): string {
  let toplam = 0;
  for (let num of a) {
    toplam += num;
  }
  const average = toplam / (a.length - 1);

  return "average : " + average;
}

const getAverage3 = (): void => {};
