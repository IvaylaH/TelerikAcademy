jsConsole.writeLine('2. Write a script that compares two char arrays lexicographically (letter by letter).');
jsConsole.writeLine('Please enter 2 random words of your choice: ');
jsConsole.writeLine('');

function lexicographicallyCompare2Words() {
    'use strict';

    var firstWord, secondWord, i, length;

    firstWord = jsConsole.read('#first-word');
    secondWord = jsConsole.read('#second-word');

    if (firstWord.length > secondWord.length) {
        length = secondWord.length;
    } else {
        length = firstWord.length;
    }

    for (i = 0; i < length; i += 1) {
        if (firstWord.length !== secondWord.length) {
            if (firstWord[i] > secondWord[i]) {
                printResult('second', secondWord, firstWord);
                break;
            } else if (firstWord[i] < secondWord[i]) {
                printResult('first', firstWord, secondWord);
                break;
            } else if (i === length - 1) {
                if (length === firstWord.length) {
                    printResult('first', firstWord, secondWord);
                    break;
                } else {
                    printResult('second', secondWord, firstWord);
                    break;
                }
            }
        } else {
            if (firstWord[i] > secondWord[i]) {
                printResult('second', secondWord, firstWord);
                break;
            } else if (firstWord[i] < secondWord[i]) {
                printResult('first', firstWord, secondWord);
                break;
            } else if (i === length - 1) {
                jsConsole.writeLine('The two words are lexicographically equal.');
            }
        }
    }
}

function printResult(firstOrSecond, lexicographicallyFirst, lexicographicallySecond) {
    'use strict';

    jsConsole.writeLine('The ' + firstOrSecond + ' word is first lexicographically.');
    jsConsole.writeLine(lexicographicallyFirst);
    jsConsole.writeLine(lexicographicallySecond);
}