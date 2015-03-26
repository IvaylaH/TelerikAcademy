console.log('1. Write a function that returns the last digit of given integer as an English word.');
console.log('');
/*jslint browser: true*/

function returnLastDigitAsWord() {
    'use strict';

    var number, remainder;

    number = parseInt(document.getElementById('integer-num').value, 10);

    if (isNaN(number)) {
        return console.log('Invalid input! Please enter an integer number!');
    }

    remainder = number % 10;
    console.log('We have the number: ' + number + '. Its last digit\'s English name is: ');
    switch (remainder) {
    case 0:
        return console.log('\'Zero\'');
    case 1:
        return console.log('\'One\'');
    case 2:
        return console.log('\'Two\'');
    case 3:
        return console.log('\'Three\'');
    case 4:
        return console.log('\'Four\'');
    case 5:
        return console.log('\'Five\'');
    case 6:
        return console.log('\'Six\'');
    case 7:
        return console.log('\'Seven\'');
    case 8:
        return console.log('\'Eight\'');
    case 9:
        return console.log('\'Nine\'');
    default:
        break;
    }
}