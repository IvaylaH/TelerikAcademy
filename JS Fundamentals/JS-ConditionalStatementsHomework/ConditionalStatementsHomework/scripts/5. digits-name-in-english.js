jsConsole.writeLine('5. Write script that asks for a digit and depending on the input shows the name of that digit (in English) using a switch statement.');
jsConsole.writeLine('');
/*jslint browser: true*/

function findDigitsInEnglish() {
    'use strict';

    var digit = parseInt(document.getElementById("digit").value, 10);

    if (!isNaN(digit)) {

        switch (digit) {
        case 0:
            printDigitsName(digit, 'zero');
            break;
        case 1:
            printDigitsName(1, 'one');
            break;
        case 2:
            printDigitsName(2, 'two');
            break;
        case 3:
            printDigitsName(3, 'three');
            break;
        case 4:
            printDigitsName(4, 'four');
            break;
        case 5:
            printDigitsName(5, 'five');
            break;
        case 6:
            printDigitsName(6, 'six');
            break;
        case 7:
            printDigitsName(7, 'seven');
            break;
        case 8:
            printDigitsName(8, 'eight');
            break;
        case 9:
            printDigitsName(9, 'nine');
            break;
        default:
            jsConsole.writeLine('Invalid input!');
            break;
        }
    } else {
        jsConsole.writeLine('Invalid input! Please try again and this time enter a digit from 0 to 9!');
    }
}

function printDigitsName(digit, name) {
    'use strict';

    jsConsole.writeLine(digit + ' in English is: <strong>' + name + '</strong>.');
}