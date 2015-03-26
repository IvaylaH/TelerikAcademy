console.log('5 Write a function that replaces non breaking white-spaces in a text with &nbsp;');
console.log('');

function replaceWhiteSpaces() {
    'use strict';

    var text, resultForLoop, resultArrayFuncs;

    text = 'Detective Sherlock Holmes and his stalwart partner Watson engage in a battle of wits and brawn with a nemesis whose plot is a threat to all of England.';

    resultArrayFuncs = solutionUsingSplitAndJoin(text);
    resultForLoop = solutionUsingForLoop(text);

    console.log(text);
    console.log('');
    console.log(resultArrayFuncs);
    console.log('');
    console.log(resultForLoop);
}

// solution using Array.split() - to get new array containing only the words and then Array.join() 
function solutionUsingSplitAndJoin(text) {
    'use strict';

    var wordsArr, result;

    wordsArr = text.split(' ');
    result = wordsArr.join('&nbsp;');

    return result;
}

// solution using for loop to iterate through the text
function solutionUsingForLoop(text) {
    'use strict';

    var symbol, result, i, len;

    symbol = '&nbsp;';
    result = '';

    for (i = 0, len = text.length; i < len; i += 1) {
        if (text[i] === ' ') {
            result += symbol;
        } else {
            result += text[i];
        }
    }

    return result;
}