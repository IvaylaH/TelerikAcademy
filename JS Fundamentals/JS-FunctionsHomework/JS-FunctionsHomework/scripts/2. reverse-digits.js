console.log('2. Write a function that reverses the digits of given decimal number.');
console.log('');
/*jslint browser: true*/

function reverseDigits() {
    'use strict';

    var numberStr, reversedNumberStr, i, len;

    numberStr = document.getElementById('integer-num').value;
    reversedNumberStr = '';

    if (numberStr.length === 1) {
        console.log('Number: ' + numberStr + ' has only one digit, so it cannot be reversed.');
    } else {//if (numberStr.length % 2) {
        for (i = 0, len = numberStr.length; i < len; i += 1) {
            reversedNumberStr += numberStr[len - i - 1];
        }

        console.log('Original number: ' + numberStr + '. Reversed number: ' + reversedNumberStr + '.');
    }
}