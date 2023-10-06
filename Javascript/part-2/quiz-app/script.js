// OOP: Nesne Tabanlı Programlama
// Object

// Sınıf, Constructor => nesne * 30
// ES5, ES6, ES7

const quiz = new Quiz(sorular);
const ui = new UI();

ui.btn_start.addEventListener("click", function () {
  if (quiz.sorular.length != quiz.soruIndex) {
    ui.quiz_box.classList.add("active");
    startTimer(10);
    startTimerLine();
    ui.soruSayisiniGoster(quiz.soruIndex + 1, quiz.sorular.length);
    ui.soruGoster(quiz.soruGetir());
  } else {
  }
});

ui.btn_next.addEventListener("click", function () {
  if (quiz.sorular.length != quiz.soruIndex + 1) {
    quiz.soruIndex++;
    clearInterval(counter); // eski saniye temizlenir.
    clearInterval(counter_line);
    startTimer(10);
    startTimerLine();
    ui.soruSayisiniGoster(quiz.soruIndex + 1, quiz.sorular.length);

    ui.soruGoster(quiz.soruGetir());
    if (quiz.soruIndex + 1 == quiz.sorular.length)
      btn_next.textContent = "Sonucu Göster";
    ui.btn_next.classList.remove("visible");
    ui.btn_next.classList.add("invisible");
  } else {
    clearInterval(counter);

    ui.score_box.classList.add("active");
    ui.quiz_box.classList.remove("active");
    ui.skoruGoster(quiz.sorular.length, quiz.dogruCevapSayisi);
  }
});

// let btn_next = document.querySelector(".next-btn");

function optionSelected(option) {
  clearInterval(counter);
  clearInterval(counter_line);
  let cevap = option.querySelector("span b").textContent;
  let soru = quiz.soruGetir();

  if (soru.cevabiKontrolEt(cevap)) {
    quiz.dogruCevapSayisi++;
    option.classList.add("correct");
    option.insertAdjacentHTML("beforeend", ui.iconTrue);
  } else {
    option.classList.add("incorrect");
    option.insertAdjacentHTML("beforeend", ui.iconFalse);
  }

  for (let i = 0; i < ui.option_list.children.length; i++) {
    ui.option_list.children[i].classList.add("disabled");
  }
  ui.btn_next.classList.remove("invisible");
  ui.btn_next.classList.add("visible");
}

ui.btn_quit.addEventListener("click", function () {
  window.location.reload();
});
ui.btn_replay.addEventListener("click", function () {
  quiz.soruIndex = 0;
  quiz.dogruCevapSayisi = 0;
  ui.btn_start.click();
  ui.score_box.classList.remove("active");
});

let counter;
function startTimer(time) {
  counter = setInterval(timer, 1000);

  function timer() {
    ui.time_second.textContent = time;
    time--;

    if (time < 0) {
      clearInterval(counter);
      ui.time_text.textContent = "Süre Bitti!";

      let cevap = quiz.soruGetir().dogruCevap;
      console.log(cevap);
      for (let option of ui.option_list.children) {
        if (option.querySelector("span b").textContent == cevap) {
          option.classList.add("correct");
          option.insertAdjacentHTML("beforeend", ui.iconTrue);
        }
        option.classList.add("disabled");
      }
      ui.btn_next.classList.add("visible");
      ui.btn_next.classList.remove("invisible");
    }
  }
}

let counter_line;
function startTimerLine() {
  let line_width = 0;
  counter_line = setInterval(timer, 50);

  function timer() {
    if (line_width > 547) {
      clearInterval(counter_line);
    }
    line_width += 2.5;
    ui.time_line.style.width = line_width + "px";
  }
}
