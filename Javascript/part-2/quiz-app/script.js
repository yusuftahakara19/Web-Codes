// OOP: Nesne Tabanlı Programlama
// Object

// Sınıf, Constructor => nesne * 30
// ES5, ES6, ES7

const quiz = new Quiz(sorular);
const ui = new UI();

ui.btn_start.addEventListener("click", function () {
  if (quiz.sorular.length != quiz.soruIndex) {
    ui.quiz_box.classList.add("active");
    ui.soruSayisiniGoster(quiz.soruIndex + 1, quiz.sorular.length);
    ui.soruGoster(quiz.soruGetir());
  } else {
  }
});

ui.btn_next.addEventListener("click", function () {
  if (quiz.sorular.length != quiz.soruIndex + 1) {
    quiz.soruIndex++;
    ui.soruSayisiniGoster(quiz.soruIndex + 1, quiz.sorular.length);

    ui.soruGoster(quiz.soruGetir());
    if (quiz.soruIndex + 1 == quiz.sorular.length)
      btn_next.textContent = "Sonucu Göster";
    btn_next.classList.remove("visible");
    btn_next.classList.add("invisible");
  } else {
    ui.score_box.classList.add("active");
    ui.quiz_box.classList.remove("active");
    ui.skoruGoster(quiz.sorular.length, quiz.dogruCevapSayisi);
  }
});

let btn_next = document.querySelector(".next-btn");

function optionSelected(option) {
  let cevap = option.querySelector("span b").textContent;
  let soru = quiz.soruGetir();
  let iconFalse = `<div class="icon"><i class="fas fa-times"></i></div>
  `;
  let iconTrue = `<div class="icon"><i class="fas fa-check"></i></div>
  `;
  if (soru.cevabiKontrolEt(cevap)) {
    quiz.dogruCevapSayisi++;
    option.classList.add("correct");
    option.insertAdjacentHTML("beforeend", iconTrue); // Yeni HTML, div öğesinin sonuna eklenir
  } else {
    option.classList.add("incorrect");
    option.insertAdjacentHTML("beforeend", iconFalse);
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
