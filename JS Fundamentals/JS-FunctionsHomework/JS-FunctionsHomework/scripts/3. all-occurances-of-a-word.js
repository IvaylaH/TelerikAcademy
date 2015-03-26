console.log('3. Write a function that finds all the occurrences of word in a text');
console.log('');
/*jslint browser: true*/

function findAllOccurancesOfAWord() {
    'use strict';

    var text, wordsInText, searchedWord;

    text = 'Now I see fire Inside the mountain I see fire Burning the trees And I see fire Hollowing souls I see fire Blood in the breeze And I hope that you remember me';

    // using RegEx to split the text as a result we get an array with all the words from the text
    wordsInText = text.split(/\W+/);

    searchedWord = 'fire';

    countOccurances(wordsInText, searchedWord);
    countOccurances(wordsInText, searchedWord, true);
}

function countOccurances(text, searchedWord, isCaseSensitive) {
    'use strict';

    var count, i, len;

    isCaseSensitive = isCaseSensitive || false;

    if (isCaseSensitive) {
        count = 0;
        for (i = 0, len = text.length; i < len; i += 1) {
            if (searchedWord.toLowerCase() === text[i].toLowerCase()) {
                count += 1;
            }
        }

        console.log('The word \'' + searchedWord + '\' can be found ' + count + ' times inside the text.');
    } else {
        count = 0;
        for (i = 0, len = text.length; i < len; i += 1) {
            if (searchedWord === text[i]) {
                count += 1;
            }
        }

        console.log('The word \'' + searchedWord + '\' can be found ' + count + ' times inside the text.');
    }
}