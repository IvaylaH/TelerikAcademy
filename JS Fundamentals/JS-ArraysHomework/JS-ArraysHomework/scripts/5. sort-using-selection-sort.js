jsConsole.writeLine('5. Write a script to sort an array. Use the "selection sort" algorithm.');
jsConsole.writeLine('');

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