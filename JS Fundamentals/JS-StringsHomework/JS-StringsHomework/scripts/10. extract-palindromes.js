console.log('10. Write a program that extracts from a given text all palindromes, e.g. "ABBA", "lamal", "exe".');
console.log('');

function extractAllPalindromes() {
    'use strict';

    var text, textToArr, palindromesArr, i, j, arrLen, wordLen, currentWord, curWordBackwards;

    text = 'Here there is a text with palindromes. The first one is \'ABBA\', then we have \'lamal\' and we\'re going to finish with \'exe\'. So, that\'s all, Folks!';
    textToArr = text.split(' ');
    palindromesArr = [];

    // I am not sure how to make it work universally -> in this case I see that after the split ',' and '.' remain and prevent the programm from working properly and I fix it, but if there are other punctuation marks that I have not noticed the problem will arise again

    for (i = 0, arrLen = textToArr.length; i < arrLen; i += 1) {
        currentWord = textToArr[i];
        if (currentWord[currentWord.length - 1] === ',' || currentWord[currentWord.length - 1] === '.') {
            currentWord = currentWord.slice(0, currentWord.length - 1);
        }
        curWordBackwards = '';

        for (j = 0, wordLen = currentWord.length; j < wordLen; j += 1) {
            curWordBackwards += currentWord[wordLen - j - 1];
        }

        if (currentWord === curWordBackwards && currentWord.length !== 1) {
            palindromesArr.push(currentWord);
        }

    }

    console.log('Text: \'' + text + '\'');
    console.log('');
    console.log('Inside the above text there are '+ palindromesArr.length + ' palindromes -> ' + palindromesArr.join(' ') + '.');
}

// found this in the forum, guess it can help me with the punctuation marks problem
// text = text.replace(".", " ").replace("!", " ").replace("?", " ").replace(",", " ");