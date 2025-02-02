"use strict";

window.addEventListener("load", initialize);

//Elements on page
let inpWordInDutch, inpWordInEnglish, inpAnswer;
let txaDescriptionInDutch, txaDescriptionInEnglish;
let hdgQuestion;
let sctAddWordPair, sctExercises;
let divStats, divWordContainer, divErrorList;
let btnReset;

let currentWordIndex = 0;

//global vars
let words = [
  {
    dutch: "vork",
    english: "fork",
    dutchDescription: "Iets waarmee je eet dat doorgaans vier tanden heeft.",
    englishDescription: "Something you eat with that usually has four tines.",
    isKnown: false,
  },
  {
    dutch: "mes",
    english: "knife",
    dutchDescription: "Bestek dat snijdt.",
    englishDescription: "Cutlery that cuts.",
    isKnown: false,
  },
  {
    dutch: "lepel",
    english: "spoon",
    dutchDescription: "Bestek waarmee je soep eet.",
    englishDescription: "Cutlery you use to eat soup.",
    isKnown: false,
  },
];

function initialize() {
  bindElements();
  addEventListeners();

  sctExercises.className = "hidden";
  btnReset.className = "hidden";

  displayAvailableWords();
  updateStats();
}

function bindElements() {
  inpWordInDutch = document.getElementById("word-in-dutch");
  inpWordInEnglish = document.getElementById("word-in-english");
  inpAnswer = document.getElementById("answer");

  txaDescriptionInDutch = document.getElementById("description-in-dutch");
  txaDescriptionInEnglish = document.getElementById("description-in-english");

  sctAddWordPair = document.getElementById("add-word-pair");
  divStats = document.getElementById("stats-container");
  sctExercises = document.getElementById("exercises");

  hdgQuestion = document.getElementById("question");

  btnReset = document.getElementById("reset");

  divErrorList = document.getElementById("error-list");
  divWordContainer = document.getElementById("word-container");
}

function addEventListeners() {
  //add word
  const btnAddWord = document.getElementById("add-word");
  btnAddWord.addEventListener("click", function () {
    const errors = validateInput();

    if (errors.length === 0) {
      addWord();
      displayAvailableWords();
      updateStats();
      clearInputs();
    } else {
      displayErrors(errors);
    }
  });

  const btnStartExercising = document.getElementById("start-exercising");
  btnStartExercising.addEventListener("click", function () {
    switchToExerciseMode();
    showNextWord();
  });

  //give answer
  const btnGiveAnswer = document.getElementById("give-answer");
  btnGiveAnswer.addEventListener("click", giveAnswer);

  //reset
  btnReset.addEventListener("click", reset);
}

function addWord() {
  const newWord = {
    dutch: inpWordInDutch.value,
    english: inpWordInEnglish.value,
    dutchDescription: txaDescriptionInDutch.value,
    englishDescription: txaDescriptionInEnglish.value,
    isKnown: false,
  };

  words.push(newWord);
}

function displayAvailableWords() {
  divWordContainer.innerHTML = "";

  const orderedWords = words.sort((a, b) =>
    a.dutch > b.dutch ? 1 : b.dutch > a.dutch ? -1 : 0
  );

  for (let i = 0; i < orderedWords.length; i++) {
    const word = orderedWords[i];

    const spnWord = document.createElement("span");
    spnWord.textContent = word.dutch;

    if (!word.isKnown) spnWord.className = "word-to-learn";
    else spnWord.className = "known-word";

    divWordContainer.appendChild(spnWord);
  }
}

function updateStats() {
  divStats.innerHTML = "";

  const parKnownWords = document.createElement("p");
  parKnownWords.textContent = `Je kent al ${getNumberOfKnownWords()} van de ${getNumberOfWords()} woorden!`;

  const parMotivation = document.createElement("p");
  parMotivation.textContent = `Komaan! Je kan het! Je hebt nog ${getNumberOfUnKnownWords()} woordjes te leren!`;

  divStats.appendChild(parKnownWords);
  divStats.appendChild(parMotivation);
}

function getNumberOfWords() {
  return words.length;
}

function getNumberOfKnownWords() {
  const knownWords = words.filter((word) => word.isKnown);
  return knownWords.length;
}

function getNumberOfUnKnownWords() {
  const unknownWords = words.filter((word) => !word.isKnown);
  return unknownWords.length;
}

function validateInput() {
  const errors = [];

  if (inpWordInDutch.value === "")
    errors.push("Vul het Nederlandstalige woord in.");

  if (inpWordInEnglish.value === "")
    errors.push("Vul het Engelstalige woord in.");

  if (txaDescriptionInDutch.value === "")
    errors.push("Geef de beschrijving van het woord in het Nederlands in.");

  if (txaDescriptionInEnglish.value === "")
    errors.push("Geef de beschrijving van het woord in het Engels in.");

  if (txaDescriptionInDutch.value === txaDescriptionInEnglish.value)
    errors.push(
      "De Engelstalige en Nederlandstalige beschrijven mogen niet gelijk zijn."
    );

  if (words.some((question) => question.dutch === inpWordInDutch.value))
    errors.push(
      "Je kan niet twee keer hetzelfde Nederlandstalige woord toevoegen."
    );

  return errors;
}

function displayErrors(errors) {
  divErrorList.innerHTML = "";

  for (let i = 0; i < errors.length; i++) {
    const parError = document.createElement("p");
    parError.textContent = errors[i];
    parError.className = "error";
    divErrorList.appendChild(parError);
  }
}

function clearInputs() {
  inpWordInDutch.value = "";
  inpWordInEnglish.value = "";

  txaDescriptionInDutch.value = "";
  txaDescriptionInEnglish.value = "";
}

function switchToExerciseMode() {
  //every grid item has a position except for 'add-word-pairs' and 'exercises'
  //side only one is show at a time, they take up the only available space
  sctAddWordPair.className = "hidden";
  sctExercises.className = "";
}

function showNextWord() {
  inpAnswer.value = "";

  const mode = Math.floor(Math.random() * 3);
  const wordToShow = words[currentWordIndex];

  switch (mode) {
    case 0:
      askDutchToEnglish(wordToShow);
      break;
    case 1:
      askDutchDescriptionToEnglishWord(wordToShow);
      break;
    case 2:
      askEnglishDescriptionToEnglishWord(wordToShow);
      break;
    default:
      askDutchToEnglish(wordToShow);
      break;
  }
}

function askDutchToEnglish(word) {
  hdgQuestion.innerHTML = `Hoe zeg je <span class="question">${word.dutch}</span> in het Engels?`;
}

function askDutchDescriptionToEnglishWord(word) {
  hdgQuestion.innerHTML = `Hieronder een beschrijving van het woord in het Nederlands.
                             Naar welk Engels woord zijn we op zoek?<hr>
                             <span class="question">${word.dutchDescription}</span>`;
}

function askEnglishDescriptionToEnglishWord(word) {
  hdgQuestion.innerHTML = `Hieronder een beschrijving van het woord in het Engels.<br> 
                             Naar welk Engels woord zijn we op zoek?<br>
                             <span class="question">${word.englishDescription}</span>`;
}

//give stats does not use an anonymous function.
//Because we also use updateStats() and showNextWord() here, it's difficult to re-use this function now
function giveAnswer() {
  const answer = inpAnswer.value.toLowerCase();
  const currentWordInEnglish = words[currentWordIndex].english.toLowerCase();

  if (answer === "") {
    alert("Geef een antwoord!");
    return;
  }

  //the answer is ALWAYS in english
  if (answer === currentWordInEnglish) {
    words[currentWordIndex].isKnown = true;
  }

  //go to next question
  currentWordIndex++;

  updateStats();
  displayAvailableWords();

  if (currentWordIndex > words.length - 1) {
    alert(
      "Helemaal klaar met oefenen! Controleer welke woordjes je nog moet oefenen en probeer eventueel opnieuw!"
    );

    //make visible
    btnReset.className = "";
  } else {
    showNextWord();
  }
}

function reset() {
  //reset know words
  for (let i = 0; i < words.length; i++) {
    words[i].isKnown = false;
  }

  currentWordIndex = 0;

  btnReset.className = "hidden";

  displayAvailableWords();
  updateStats();
  showNextWord();
}
