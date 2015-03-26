console.log('6. Write a function that checks if the element at given position in given array of integers is bigger than its two neighbors (when such exist).');
console.log('');
/*jslint browser: true*/

function parseInputPos() {
    'use strict';

    var position = parseFloat(document.getElementById('input-position').value, 10);

    if (isNaN(position)) {
        return console.log('Invalid input! Please enter a number of your choice!');
    }

    return position;
}

function parseInputArr() {
    'use strict';

    var input, inputArr, i, len;

    input = document.getElementById('input-arr').value;
    input = input.split(',');
    inputArr = [];
    for (i = 0, len = input.length; i < len; i += 1) {
        inputArr[i] = parseFloat(input[i]);
    }

    return inputArr;
}

function checkIfBiggerThanNeighbours() {
    'use strict';

    var numbersArr, position, numberAtPos, isBigger, arrToStr;

    numbersArr = parseInputArr();
    position = parseInputPos();
    isBigger = false;
    arrToStr = numbersArr.join(' ');

    if (0 > position || position > numbersArr.length) {
        return console.log('Invalid input! The position we are checking must be in the range [0, ' + numbersArr.length + ']. Please try again!');
    }

    if (position === 0 || position === numbersArr.length - 1) {
        return console.log('The number at position ' + position + ' has only ONE neighbour!');
    }

    numberAtPos = numbersArr[position];

    if (numbersArr[position - 1] < numberAtPos && numberAtPos > numbersArr[position + 1]) {
        isBigger = true;
    }

    printResult(arrToStr, isBigger, position);
}

function printResult(arrToStr, isBigger, position) {
    console.log('We have the following array: ' + arrToStr + '.');
    if (isBigger) {
        console.log('The number at position \'' + position + '\' is greater than both its two neighbours.');
    } else {
        console.log('The number at position \'' + position + '\' is NOT greater than both its two neighbours.');
    }
}