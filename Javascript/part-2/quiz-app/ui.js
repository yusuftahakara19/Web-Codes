function UI() {
  (this.btn_start = document.querySelector(".btn_start")),
    (this.btn_replay = document.querySelector(".btn_replay")),
    (this.btn_quit = document.querySelector(".btn_quit")),
    (this.btn_next = document.querySelector(".next-btn")),
    (this.quiz_box = document.querySelector(".quiz_box"));
  this.option_list = document.querySelector(".option_list");
  this.score_box = document.querySelector(".score_box");
}

UI.prototype.soruGoster = function (soru) {
  let question = quiz.soruIndex + 1 + `- <span>${soru.soruMetni}</span>`;
  let options = ``;

  for (let cevap in soru.cevapSecenekleri) {
    options += `
        <div class="option">
         <span><b>${cevap}</b>: ${soru.cevapSecenekleri[cevap]}</span>
      </div>
        `;
  }

  document.querySelector(".question_text").innerHTML = question;
  this.option_list.innerHTML = options;

  const option = this.option_list.querySelectorAll(".option");

  for (let opt of option) {
    opt.setAttribute("onclick", "optionSelected(this);");
  }
};

UI.prototype.soruSayisiniGoster = function (soruSirasi, toplamSoru) {
  let tag = ` <span class="badge bg-warning">${soruSirasi} / ${toplamSoru}</span>`;
  document.querySelector(".quiz_box .question_index").innerHTML = tag;
};

UI.prototype.skoruGoster = function (toplamSoru, dogruCevap) {
  let tag = `   Toplam ${toplamSoru} soruya ${dogruCevap} doğru cevap verdiniz.`;
  document.querySelector(".score_box .score_text").innerHTML = tag;
};
