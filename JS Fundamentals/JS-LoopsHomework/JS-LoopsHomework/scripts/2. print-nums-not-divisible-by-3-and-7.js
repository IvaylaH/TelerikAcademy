jsConsole.writeLine('2. Write a script that prints all the numbers from 1 to N, that are not divisible by 3 and 7 at the same time');
jsConsole.writeLine('');
/*jslint browser: true*/

function printNumbersNotDivisibleBy3And7() {
    'use strict';

    var startNum, endNum, numbersStr, strLength;

    startNum = 1;
    endNum = parseInt(document.getElementById("input-number").value, 10);
    numbersStr = '';
    strLength = 0;

    if (isNaN(endNum)) {
        return jsConsole.writeLine('Invalid input! Please enter a number of your choice!');
    }

    numbersStr += 'Numbers: ';
    while (startNum <= endNum) {
        if (startNum % 21) {
            numbersStr += startNum;
            numbersStr += ', ';
        }

        // I am using '+= 1' instead of '++' because at one of the lectures, Doncho said it works faster for JS
        startNum += 1;
    }

    // remove the last ',' in the string and replace it with a '.'
    strLength = numbersStr.length;
    numbersStr = numbersStr.substr(0, strLength - 2);
    numbersStr += '.';

    return jsConsole.writeLine(numbersStr);
}