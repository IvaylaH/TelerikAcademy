jsConsole.writeLine('4. Write an expression that checks for given integer if its third digit (right-to-left) is 7. E. g. 1732  true.');
jsConsole.writeLine('');
/*jslint browser: true*/

function checkThirdDigit() {
    'use strict';

    var integer, result, remainder;
    integer = parseInt(document.getElementById("number").value, 10);

    if (!isNaN(integer)) {
        if (integer < 100) {
            jsConsole.writeLine('The number you have entered has less than 3 digits;');
        } else if (integer > 100 && integer < 1000) {
            result = integer / 100;
            printResult(Math.floor(result), integer);
        } else if (integer > 1000) {
            result = integer / 100;
            remainder = result % 10;
            printResult(Math.floor(remainder), integer);
        }
    } else {
        jsConsole.writeLine('Invalid input! Please enter an integer number');
    }
}

function printResult(result, inputNumber) {
    'use strict';

    if (result === 7) {
        jsConsole.writeLine('The third digit in the number "' + inputNumber + '" IS 7');
    } else {
        jsConsole.writeLine('The third digit in the number "' + inputNumber + '" is NOT 7');
    }
}