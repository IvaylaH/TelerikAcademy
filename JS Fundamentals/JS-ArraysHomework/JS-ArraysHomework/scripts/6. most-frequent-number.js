jsConsole.writeLine('6. Write a program that finds the most frequent number in an array.');
jsConsole.writeLine('');

function printMostFrequentNum() {
    'use strict';

    var myArr, arrToStr, i, j, numOfRepetitions, maxNumOfRepetitions, currentElement, repeatedElement;

    myArr = [4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3];
    arrToStr = myArr.join(' ');
    numOfRepetitions = 1;
    maxNumOfRepetitions = 0;
    repeatedElement = '';

    for (i = 0; i < myArr.length - 1; i += 1) {
        currentElement = myArr[i];

        for (j = i + 1; j < myArr.length; j += 1) {
            if (currentElement === myArr[j]) {
                numOfRepetitions += 1;
            }
        }

        if (maxNumOfRepetitions < numOfRepetitions) {
            maxNumOfRepetitions = numOfRepetitions;
            repeatedElement = currentElement;
        }

        numOfRepetitions = 1;
    }

    printResult(arrToStr, maxNumOfRepetitions, repeatedElement);
}

function printResult(arrToStr, numberOfRepetitions, repeatedNum) {
    'use strict';

    jsConsole.writeLine('We have worked on the following array: ');
    jsConsole.writeLine(arrToStr + '.');
    jsConsole.writeLine('The most frequently repeated number in the above array is: <strong>' + repeatedNum + '</strong>');
    jsConsole.writeLine('It is repeated <strong>' + numberOfRepetitions + ' times.</strong>');
}