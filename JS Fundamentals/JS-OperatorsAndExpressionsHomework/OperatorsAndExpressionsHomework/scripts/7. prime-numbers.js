jsConsole.writeLine('7. Write an expression that checks if given positive integer number n (n ≤ 100) is prime. E.g. 37 is prime.');
jsConsole.writeLine('');
/*jslint browser: true*/

function checkIfPrime() {
    'use strict';

    var number = parseInt(document.getElementById("positiveInt").value, 10);

    if (!isNaN(number) & number <= 100) {
        var divider = 2;
        var maxDivider = Math.sqrt(number) | 0;
        var isPrime = true;

        while (divider <= maxDivider && isPrime) {
            if (number % divider === 0) {
                isPrime = false;
            }

            divider++;
        }

        if (isPrime) {
            jsConsole.writeLine('Number "' + number + '" is prime: True!');
        } else {
            jsConsole.writeLine('Number "' + number + '" is prime: False!');
        }
    } else {
        jsConsole.writeLine('Invalid input! Please enter a positive integer number that is less than 100!');
    }
}