console.log('7. Write a function that returns the index of the first element in array that is bigger than its neighbors, or -1, if there’s no such element.');
console.log('');
/*jslint browser: true*/

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

function findFirstBiggerThanNeighbours() {
    'use strict';

    var numbersArr, i, len, indexOfFirstBigger, arrToStr;

    numbersArr = parseInputArr();
    arrToStr = numbersArr.join(' ');

    for (i = 1, len = numbersArr.length - 1; i < len; i += 1) {
        if (numbersArr[i - 1] < numbersArr[i] && numbersArr[i] > numbersArr[i + 1]) {
            indexOfFirstBigger = i;
            break;
        } else if (i === (len - 1)) {
            indexOfFirstBigger = -1;
        }
    }

    printResult(arrToStr, numbersArr, indexOfFirstBigger);
}

function printResult(arrToStr, array, index) {
    console.log('We have the following array: ' + arrToStr + '.');
    if (index !== -1) {
        console.log('The first number in the above array that is bigger than both its neighbours is: \'' + array[index] + '\' and it is at position \'' + index + '\'.');
    } else {
        console.log('In the above array there is NO such number that is bigger than both its neighbours!');
    }
}