jsConsole.writeLine('3. Write a script that finds the biggest of three integers using nested if statements.');
jsConsole.writeLine('');
/*jslint browser: true*/

function findBiggestIntOfThree() {
    'use strict';

    var firstInt, secondInt, thirdInt;

    firstInt = parseInt(document.getElementById("firstInt").value, 10);
    secondInt = parseInt(document.getElementById("secondInt").value, 10);
    thirdInt = parseInt(document.getElementById("thirdInt").value, 10);

    if (!isNaN(firstInt) && !isNaN(secondInt) && !isNaN(thirdInt)) {
        if (firstInt > secondInt) {
            if (firstInt > thirdInt) {
                printBiggestInt(firstInt, 'first');
            } else {
                printBiggestInt(thirdInt, 'third');
            }
        } else {
            if (secondInt > thirdInt) {
                printBiggestInt(secondInt, 'second');
            } else {
                printBiggestInt(thirdInt, 'third');
            }
        }
    } else {
        jsConsole.writeLine('Invalid input! At least one of the numbers is NOT in the correct format!');
    }
}

function printBiggestInt(biggestInteger, orderOfNumbers) {
    'use strict';

    jsConsole.writeLine('The biggest of the 3 integer numbers is the <strong>' + orderOfNumbers + '</strong> one = ' + biggestInteger);
}