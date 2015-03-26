jsConsole.writeLine('1. Write a script that prints all the numbers from 1 to N');
jsConsole.writeLine('');
/*jslint browser: true*/

function printNumbersToN() {
    'use strict';

    var number, i, numbersStr;

    number = parseInt(document.getElementById("input-number").value, 10);
    numbersStr = '';

    if (isNaN(number)) {
        return jsConsole.writeLine('Invalid input! Please enter a number of your choice!');
    }

    numbersStr += 'Numbers: ';
    for (i = 1; i <= number; i += 1) {

        numbersStr += i;
        if (i === number) {
            numbersStr += '.';
            break;
        }

        numbersStr += ', ';
    }

    return jsConsole.writeLine(numbersStr);
}