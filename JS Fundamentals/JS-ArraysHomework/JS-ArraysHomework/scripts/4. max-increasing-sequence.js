jsConsole.writeLine('4. Write a script that finds the maximal increasing sequence in an array.');
jsConsole.writeLine('');

function printMaxIncreasingSeq() {
    'use strict';

    var myArr, i, j, currentElement, sequenceLength, maxSeqLength, maxSeqIndex, arrToStr;

    myArr = [3, 2, 3, 4, 2, 2, 4];
    sequenceLength = 1;
    maxSeqLength = 0;
    maxSeqIndex = 0;
    arrToStr = myArr.join(' ');

    for (i = 0; i < myArr.length - 1; i += 1) {
        currentElement = myArr[i];

        for (j = i + 1; j < myArr.length; j += 1) {
            if (myArr[j] === currentElement + 1) {
                sequenceLength += 1;
                currentElement = myArr[j];
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

function printResult(myArr, arrayStr, seqLength, seqIndex) {
    'use strict';

    var i;
    jsConsole.writeLine('We have the following array: ' + arrayStr + '.');
    jsConsole.writeLine('The max increasing sequence has: ' + seqLength + ' elements.');
    jsConsole.write('The max increasing sequence is: ');

    for (i = seqIndex; i < seqIndex + seqLength; i++) {
        jsConsole.write(myArr[i] + ' ');
    }
}