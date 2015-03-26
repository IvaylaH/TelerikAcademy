jsConsole.writeLine('3. Write a script that finds the max and min number from a sequence of numbers');
jsConsole.writeLine('');
/*jslint browser: true*/

function parseInputArr() {
    'use strict';

    var inputStr, inputArr;

    inputStr = jsConsole.read('#sequence');
    inputArr = inputStr.split(',');

    return inputArr;
}

function printMin() {
    'use strict';

    var inputArr, min, i, arrToStr;

    inputArr = parseInputArr();
    min = parseFloat(inputArr[0]);
    arrToStr = '';

    for (i = 1; i < inputArr.length; i += 1) {
        if (min > parseFloat(inputArr[i])) {
            min = parseFloat(inputArr[i]);
        }
    }

    arrToStr = inputArr.join(', ');
    jsConsole.writeLine('We have the sequence: ' + arrToStr);
    jsConsole.writeLine('The <strong>min</strong> number from the above sequence is: ' + min);
}

function printMax() {
    'use strict';

    var inputArr, max, arrToStr, i;

    inputArr = parseInputArr();
    max = Number.MIN_VALUE;
    arrToStr = '';
    i = 0;

    do {
        if (max <  parseFloat(inputArr[i])) {
            max = parseFloat(inputArr[i]);
        }

        i += 1;
    } while (i < inputArr.length)

    arrToStr = inputArr.join(', ');
    jsConsole.writeLine('We have the following sequence: ' + arrToStr);
    jsConsole.writeLine('The <strong>max</strong> number in the above sequence is: ' + max);
}