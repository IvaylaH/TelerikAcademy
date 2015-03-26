jsConsole.writeLine('2. Write a script that shows the sign (+ or -) of the product of three real numbers without calculating it. Use a sequence of if statements.');
jsConsole.writeLine('');
/*jslint browser: true*/

function showProductSign() {
    'use strict';

    var firstNum, secondNum, thirdNum, negativeNumbers;

    firstNum = parseFloat(document.getElementById("firstNum").value, 10);
    secondNum = parseFloat(document.getElementById("secondNum").value, 10);
    thirdNum = parseFloat(document.getElementById("thirdNum").value, 10);

    negativeNumbers = 0;

    if (!isNaN(firstNum) && !isNaN(secondNum) && !isNaN(thirdNum)) {
        if (firstNum < 0) {
            negativeNumbers += 1;
        }
        if (secondNum < 0) {
            negativeNumbers += 1;
        }
        if (thirdNum < 0) {
            negativeNumbers += 1;
        }

        if (negativeNumbers === 1 || negativeNumbers === 3) {
            jsConsole.writeLine('The product of the numbers: ' + firstNum + ', ' + secondNum + ', ' + thirdNum + ', has <strong>negative</strong> sign.');
        } else {
            jsConsole.writeLine('The product of the numbers: ' + firstNum + ', ' + secondNum + ', ' + thirdNum + ', has <strong>positive</strong> sign.');
        }
    } else {
        jsConsole.writeLine('Invalid input! At least one of the numbers is NOT in the correct format!');
    }
}