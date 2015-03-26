jsConsole.writeLine('1. Write an if statement that examines two integer variables and exchanges their values if the first one is greater than the second one.');
jsConsole.writeLine('');
/*jslint browser: true*/

function examineAndExchangeValues() {
    'use strict';

    var firstInt, secondInt;

    firstInt = parseInt(document.getElementById("firstInt").value, 10);
    secondInt = parseInt(document.getElementById("secondInt").value, 10);

    if (!isNaN(firstInt) && !isNaN(secondInt)) {
        if (firstInt > secondInt) {
            jsConsole.writeLine('The first integer number is greater than the second one.');
            jsConsole.writeLine('Number values before the exchange: first integer = ' + firstInt + ', second integer: ' + secondInt);

            //exchange the values of the 2 variables without introducing a third variable
            firstInt += secondInt;
            secondInt = firstInt - secondInt;
            firstInt -= secondInt;

            jsConsole.writeLine('Number values after the exchange: first integer = ' + firstInt + ', second integer: ' + secondInt);
        } else {
            jsConsole.writeLine('The second integer number is greater than the first one.');
        }
    } else {
        jsConsole.writeLine('Invalid input! Either one of the numbers, or both of them are NOT in the correct format!');
    }
}