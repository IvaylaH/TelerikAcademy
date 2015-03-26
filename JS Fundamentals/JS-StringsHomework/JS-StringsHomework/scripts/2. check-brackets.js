console.log('2. Write a JavaScript function to check if in a given expression the brackets are put correctly.');
console.log('');

function countBrackets(expression) {
    'use strict';

    var i, len, numOfLeftBrackets, numOfRightBrackets;

    numOfRightBrackets = 0;
    numOfLeftBrackets = 0;

    for (i = 0, len = expression.length; i < len; i += 1) {
        if (expression[i] === ')') {
            numOfRightBrackets += 1;
        } else if (expression[i] === '(') {
            numOfLeftBrackets += 1;
        }
    }

    if (numOfRightBrackets === numOfLeftBrackets) {
        return true;
    }

    return false;
}

function checkIfBracketsArePlacedCorrectly() {
    'use strict';

    var correctExp = '((a + b) / 5 - d)',
        incorrectExp = ')(a+b))';

    printResult(correctExp);
    printResult(incorrectExp);
}

function printResult(expression) {
    'use strict';

    if (countBrackets(expression)) {
        console.log('The brackets in the expression: \'' + expression + '\' were placed correctly!');
    } else {
        console.log('The brackets in the expression: \'' + expression + '\' were NOT placed correctly!');
    }
}