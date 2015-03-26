jsConsole.writeLine('5. Write a boolean expression for finding if the bit 3 (counting from 0) of a given integer is 1 or 0.');
jsConsole.writeLine('');
/*jslint browser: true*/

function checkThirdBit() {
    'use strict';

    var number = parseInt(document.getElementById("inputNum").value, 10);
    if (!isNaN(number)) {
        var mask = 1 << 3;
        var numberAndMask = number & mask;
        var thirdBit = numberAndMask >> 3;

        if (thirdBit === 1) {
            jsConsole.writeLine('The third bit in "' + number + '" is: 1. Number in binary system: ' + number.toString(2));
        } else {
            jsConsole.writeLine('The third bit in "' + number + '" is: 0. Number in binary system: ' + number.toString(2));
        }
    } else {
        jsConsole.writeLine('Invalid input! Please enter a number!');
    }
}