const container = document.querySelector(".container");
const image = document.querySelector("#music-image");
const title = document.querySelector("#music-details .title");
const singer = document.querySelector("#music-details .singer");

const prev = document.querySelector("#controls #prev");
const play = document.querySelector("#controls #play");
const next = document.querySelector("#controls #next");
const audio = document.querySelector("#audio");
const duration = document.querySelector(".duration");
const current_time = document.querySelector(".current-time");
const progressBar = document.querySelector("#progress-bar");
const volume = document.querySelector("#volume-icon");
const volume_bar = document.querySelector("#volume_bar");
const music_list_ul = document.querySelector("#music-list-ul");

const player = new MusicPlayer(musicList);

window.addEventListener("load", () => {
  let music = player.getMusic();
  displayMusic(music);
  displayMusicList(player.musicList);
  isPlayingNow();
});

function displayMusic(music) {
  image.src = "img/" + music.img;
  audio.src = "mp3/" + music.file;
  title.innerText = music.getName();
  singer.innerText = music.singer;
}

play.addEventListener("click", () => {
  const isMusicPlay = container.classList.contains("playing");

  isMusicPlay ? pauseMusic() : playMusic();
});

const pauseMusic = () => {
  container.classList.remove("playing");
  play.querySelector("i").classList = "fa-solid fa-play";
  audio.pause();
};

const playMusic = () => {
  container.classList.add("playing");
  play.querySelector("i").classList = "fa-solid fa-pause";
  audio.play();
};

next.addEventListener("click", () => {
  nextMusic();
});

const nextMusic = () => {
  player.next();
  let music = player.getMusic();
  displayMusic(music);
  playMusic();
  isPlayingNow();
};

prev.addEventListener("click", () => {
  prevMusic();
});

const prevMusic = () => {
  player.prev();
  let music = player.getMusic();
  displayMusic(music);
  playMusic();
  isPlayingNow();
};

let calculateTime = (totalSecond) => {
  let minute = Math.floor(totalSecond / 60);
  let second = Math.floor(totalSecond % 60);
  let secondLast = second < 10 ? `0${second}` : `${second}`;
  return `${minute}:${secondLast}`;
};

audio.addEventListener("loadedmetadata", () => {
  duration.innerText = calculateTime(audio.duration);
  progressBar.max = Math.floor(audio.duration);
});

audio.addEventListener("timeupdate", () => {
  progressBar.value = audio.currentTime;
  current_time.textContent = calculateTime(progressBar.value);
});

progressBar.addEventListener("input", () => {
  current_time.textContent = calculateTime(progressBar.value);
  audio.currentTime = progressBar.value;
});

let volume_state = "unmuted";
var volume_value;
volume.addEventListener("click", () => {
  if (volume_bar.value != 0) {
    volume_value = volume_bar.value;
  }

  if (volume_state === "unmuted") {
    volume.classList = "fa-solid fa-volume-xmark";
    audio.muted = true;
    volume_state = "muted";
    volume_bar.value = 0;
  } else {
    volume.classList = "fa-solid fa-volume-high";
    audio.muted = false;
    volume_state = "unmuted";
    volume_bar.value = volume_value;
  }
});

volume_bar.addEventListener("input", () => {
  volume_value = volume_bar.value;
  audio.muted = false;
  audio.volume = volume_value / 100;
  if (volume_value == 0) {
    volume.classList = "fa-solid fa-volume-xmark";
  } else {
    if (volume_value < 50) {
      volume.classList = "fa-solid fa-volume-low";
    } else {
      volume.classList = "fa-solid fa-volume-high";
    }
  }
});

const displayMusicList = (list) => {
  for (let i = 0; i < list.length; i++) {
    let liTag = `
    <li
    li-index = "${i}",
    onClick = "selectedMusic(this)"
    class="list-group-item d-flex justify-content-between align-items-center"
  >
    <span>${list[i].getName()} </span>
    <span id="music-${i}" class="badge bg-primary rounded-pill">3:40</span>

    <audio class="music-${i}" src = "mp3/${list[i].file}"> </audio>
  </li>
     `;
    music_list_ul.insertAdjacentHTML("beforeend", liTag);

    let liAudioDuration = music_list_ul.querySelector(`#music-${i}`);
    let liAudioTag = music_list_ul.querySelector(`.music-${i}`);

    liAudioTag.addEventListener("loadeddata", () => {
      liAudioDuration.innerText = calculateTime(liAudioTag.duration);
    });
  }
};

const selectedMusic = (li) => {
  player.index = parseInt(li.getAttribute("li-index"));
  console.log("Selected index : " + player.index);
  displayMusic(player.getMusic());

  playMusic();
  isPlayingNow();
};

const isPlayingNow = () => {
  for (let li of music_list_ul.querySelectorAll("li")) {
    if (li.classList.contains("playing")) {
      li.classList.remove("playing");
    }

    if (player.index == li.getAttribute("li-index")) {
      li.classList.add("playing");
    }
  }
};

audio.addEventListener("ended", () => {
  nextMusic();
});
