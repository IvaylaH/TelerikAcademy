console.log('5. Write a function that counts how many times given number appears in given array. Write a test function to check if the function is working correctly.');
console.log('');
/*jslint browser: true*/

function parseInputNum() {
    'use strict';

    var number = parseFloat(document.getElementById('input-num').value, 10);

    if (isNaN(number)) {
        return console.log('Invalid input! Please enter a number of your choice!');
    }

    return number;
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

function findNumberOccurances() {
    'use strict';

    var searchedNumber, numbersArr, i, len, countOccurances, arrToStr;

    searchedNumber = parseInputNum();
    numbersArr = parseInputArr();
    countOccurances = 0;
    arrToStr = numbersArr.join(' ');

    for (i = 0, len = numbersArr.length; i < len; i += 1) {
        if (numbersArr[i] === searchedNumber) {
            countOccurances += 1;
        }
    }

    console.log('We have the following array of number: ' + arrToStr + '.');
    console.log('Number \'' + searchedNumber + '\' can be found ' + countOccurances + ' time/times inside the above array.');
}

function runTestFunction() {
    'use strict';

    var numsArr, isWorking, i, len;

    numsArr = [1, 5, 5, 5, 5, 5, 2, 2, 3, 3, 3, 4, 4, 4, 4, 8, 8, 8, 8, 8, 8, 8, 8];
    isWorking = true;

    for (i = 0, len = numsArr.length; i < len; i += 1) {
        if (!countOccurances(numsArr, numsArr[i])) {
            isWorking = false;
            break;
        }
    }

    if (isWorking) {
        console.log('Test completed! Program is working properly!');
    } else {
        console.log('Test completed! Program is NOT working properly! Please check your algorithm!');
    }
}

function countOccurances(array, searchedNum) {
    'use strict';

    var i, len, counter;

    counter = 0;

    for (i = 0, len = array.length; i < len; i += 1) {
        if (array[i] === searchedNum) {
            counter += 1;
        }
    }

    if (counter === searchedNum) {
        return true;
    }

    return false;
}