jsConsole.writeLine('7. Write a program that finds the index of given element in a sorted array of integers by using the binary search algorithm (find it in Wikipedia).');
jsConsole.writeLine('');

function binarySearch() {
    'use strict';

    var myArr, searchedElement, min, max, mid;

    myArr = sortArrayUsingSelectionSort();

    searchedElement = parseFloat(jsConsole.read('#element'));
    min = 0;
    max = myArr.length - 1;

    while (min <= max) {
        mid = ((max + min) / 2) | 0;

        if (myArr[mid] === searchedElement) {
            return mid;
        } else if (myArr[mid] < searchedElement) {
            min = mid + 1;
        } else {
            max = mid - 1;
        }
    }

    return -1;
}

function findIndex() {
    'use strict';

    var index = binarySearch();

    if (index === -1) {
        jsConsole.writeLine('The element CANNOT be found inside the array');
    } else {
        jsConsole.writeLine('The element is found at position: ' + index + '.');
    }
}

// this part is the same as in problem 5 where we had to sort array using the 'selection sort' algorithm
function parseInput() {
    'use strict';

    var myArr, input, i;

    myArr = [];
    input = jsConsole.read('#sequence').split(',');
    for (i = 0; i < input.length; i += 1) {
        myArr[i] = parseFloat(input[i]);
    }

    return myArr;
}

function sortArrayUsingSelectionSort() {
    'use strict';

    var myArr, i, j, min, arrToStr, sortedArrToStr;

    myArr = parseInput();
    arrToStr = myArr.join(' ');

    for (i = 0; i < myArr.length - 1; i += 1) {
        min = i;

        for (j = i + 1; j < myArr.length; j += 1) {
            if (myArr[min] > myArr[j]) {
                min = j;
            }
        }

        if (min !== i) {
            swapElements(myArr, i, min);
        }
    }

    sortedArrToStr = myArr.join(' ');
    printResult(arrToStr, sortedArrToStr);
    return myArr;
}

function swapElements(myArr, currentIndex, newIndex) {
    'use strict';

    var temp = myArr[currentIndex];
    myArr[currentIndex] = myArr[newIndex];
    myArr[newIndex] = temp;
}

function printResult(arrToStr, sortedArrToStr) {
    'use strict';

    jsConsole.writeLine('We started with the following array: ' + arrToStr + '.');
    jsConsole.writeLine('After applying the \'Selection sort\' algorithm we get the following array: ');
    jsConsole.writeLine(sortedArrToStr + '.');
}