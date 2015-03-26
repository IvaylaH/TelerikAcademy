jsConsole.writeLine('4. Sort 3 real values in descending order using nested if statements.');
jsConsole.writeLine('');
/*jslint browser: true*/

function sortNumbers() {
    'use strict';

    var firstNum, secondNum, thirdNum;

    firstNum = parseFloat(document.getElementById("firstRealNum").value, 10);
    secondNum = parseFloat(document.getElementById("secondRealNum").value, 10);
    thirdNum = parseFloat(document.getElementById("thirdRealNum").value, 10);

    if (!isNaN(firstNum) && !isNaN(secondNum) && !isNaN(thirdNum)) {
        if (firstNum > secondNum) {
            if (firstNum > thirdNum) {
                if (secondNum > thirdNum) {
                    printInDescendingOrder(firstNum, 'first', secondNum, 'second', thirdNum, 'third');
                } else {
                    printInDescendingOrder(firstNum, 'first', thirdNum, 'third', secondNum, 'second');
                }
            } else {
                printInDescendingOrder(thirdNum, 'third', firstNum, 'first', secondNum, 'second');
            }
        } else {
            if (secondNum > thirdNum) {
                if (firstNum < thirdNum) {
                    printInDescendingOrder(secondNum, 'second', thirdNum, 'third', firstNum, 'first');
                } else {
                    printInDescendingOrder(secondNum, 'second', firstNum, 'first', thirdNum, 'third');
                }
            } else {
                printInDescendingOrder(thirdNum, 'third', secondNum, 'second', firstNum, 'first');
            }
        }
    } else {
        jsConsole.writeLine('Invalid input! Either one or all of the numbers are NOT in the correct format');
    }
}

function printInDescendingOrder(biggest, orderOfNumbersBiggest, middle, orderOfNumbersMiddle, smallest, orderOfNumbersSmallest) {
    'use strict';

    jsConsole.writeLine('The biggest of the 3 real numbers is the <strong>' + orderOfNumbersBiggest + '</strong> one = ' + biggest);
    jsConsole.writeLine('The middle of the 3 real numbers is the <strong>' + orderOfNumbersMiddle + '</strong> one = ' + middle);
    jsConsole.writeLine('The smalles of the 3 real numbers is the <strong>' + orderOfNumbersSmallest + '</strong> one = ' + smallest);
}