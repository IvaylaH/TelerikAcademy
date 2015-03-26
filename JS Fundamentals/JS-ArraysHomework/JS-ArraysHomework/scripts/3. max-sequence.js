jsConsole.writeLine('3. Write a script that finds the maximal sequence of equal elements in an array.');
jsConsole.writeLine('');

function printMaxSequence() {
    'use strict';

    var myArr, i, j, sequenceLength, currentElement, maxSeqLength, maxSeqIndex, arrToStr;

    myArr = [2, 1, 1, 2, 3, 3, 2, 2, 2, 1];
    sequenceLength = 1;
    maxSeqLength = 0;
    maxSeqIndex = 0;
    arrToStr = myArr.join(', ');

    for (i = 0; i < myArr.length - 1; i += 1) {
        currentElement = myArr[i];

        for (j = i + 1; j < myArr.length; j += 1) {
            if (currentElement === myArr[j]) {
                sequenceLength += 1;
            } else {
                break;
            }
        }

        if (maxSeqLength < sequenceLength) {
            maxSeqLength = sequenceLength;
            maxSeqIndex = i;
        }

        sequenceLength = 1;
    }

    printResult(myArr, arrToStr, maxSeqLength, maxSeqIndex);
}

function printResult(array, arrayStr, seqLength, seqIndex) {
    'use strict';

    var i;

    jsConsole.writeLine('We work with the following array: ' + arrayStr + '.');
    jsConsole.writeLine('The max sequence has : ' + seqLength + ' elements.');
    jsConsole.write('The max sequence is: ');

    for (i = seqIndex; i < seqIndex + seqLength; i += 1) {
        jsConsole.write(array[i] + ' ');
    }
}