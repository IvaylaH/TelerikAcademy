jsConsole.writeLine('2. Write a boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 in the same time.');
jsConsole.writeLine('');
/*jslint browser: true*/

function checkIfDivisible() {
    'use strict';
    var integer = parseInt(document.getElementById("inputInteger").value, 10);
    if (!isNaN(integer)) {
        if ((integer % 5 === 0) && (integer % 7 === 0)) {
            jsConsole.writeLine('The number "' + integer + '" you have entered is divisible by both "5" and "7"');
        } else if (integer % 5 === 0) {
            jsConsole.writeLine('The number "' + integer + '" you have entered is only divisible by "5"');
        }
        else if (integer % 7 === 0) {
            jsConsole.writeLine('The number "' + integer + '" you have entered is only divisible by "7"');
        }
    } else {
        jsConsole.writeLine('Invalid input! Please enter an integer number!');
    }
}