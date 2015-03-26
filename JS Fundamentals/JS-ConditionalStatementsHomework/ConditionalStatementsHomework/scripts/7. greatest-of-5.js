jsConsole.writeLine('7. Write a script that finds the greatest of given 5 variables.');
jsConsole.writeLine('');
/*jslint browser: true*/

function parseUserInput() {
    'use strict';

    var firstVar, secondVar, thirdVar, forthVar, fifthVar;

    firstVar = parseFloat(document.getElementById("firstVar").value, 10);
    secondVar = parseFloat(document.getElementById("secondVar").value, 10);
    thirdVar = parseFloat(document.getElementById("thirdVar").value, 10);
    forthVar = parseFloat(document.getElementById("forthVar").value, 10);
    fifthVar = parseFloat(document.getElementById("fifthVar").value, 10);

    if (isNaN(firstVar) || isNaN(secondVar) || isNaN(thirdVar) || isNaN(forthVar) || isNaN(fifthVar)) {
        // return jsConsole.writeLine('Invalid input! Either one or more of the variables are NOT in the correct format!');
        return undefined;
    }

    return [firstVar, secondVar, thirdVar, forthVar, fifthVar];
}

// first solution using array
function findGreatesUsingArray() {
    'use strict';

    var varArr, max, i;

    varArr = parseUserInput();

    if (varArr === undefined) {
        return jsConsole.writeLine('Invalid input! Either one or more of the variables are NOT in the correct format!');
    }
    max = varArr[0];

    for (i = 1; i < varArr.length; i += 1) {
        if (max < varArr[i]) {
            max = varArr[i];
        }
    }

    jsConsole.writeLine('The greatest of the 5 is <strong>' + max + '</strong>.');
}

// second solution using only if statements
// I know that assigning the 5 variables with the elements of the array is repetition of the code, but since the topic is Conditional statements, decided to solve the problem using them as well
function findGreatestUsingConditionals() {
    'use strict';

    var firstVar, secondVar, thirdVar, forthVar, fifthVar, parseArr, max;

    parseArr = parseUserInput();

    if (parseArr === undefined) {
        return jsConsole.writeLine('Invalid input! Either one or more of the variables are NOT in the correct format!');
    }

    firstVar = parseArr[0];
    secondVar = parseArr[1];
    thirdVar = parseArr[2];
    forthVar = parseArr[3];
    fifthVar = parseArr[4];
    max = firstVar;

    if (max < secondVar) {
        max = secondVar;
        if (max < thirdVar) {
            max = thirdVar;
            if (max < forthVar) {
                max = forthVar;
                if (max < fifthVar) {
                    max = fifthVar;
                    jsConsole.writeLine('The greatest of the 5 is <strong>' + max + '</strong>'); // greatest = fifth
                } else {
                    jsConsole.writeLine('The greatest of the 5 is <strong>' + max + '</strong>'); // greatest = forth
                }
            } else {
                if (max < fifthVar) {
                    max = fifthVar;
                    jsConsole.writeLine('The greatest of the 5 is <strong>' + max + '</strong>'); // greatest = fifth
                } else {
                    jsConsole.writeLine('The greatest of the 5 is <strong>' + max + '</strong>'); // greatest = third
                }
            }
        } else {
            if (max < forthVar) {
                max = forthVar;
                if (max < fifthVar) {
                    max = fifthVar;
                    jsConsole.writeLine('The greatest of the 5 is <strong>' + max + '</strong>'); // greatest = fifth
                } else {
                    jsConsole.writeLine('The greatest of the 5 is <strong>' + max + '</strong>'); // greatest = forth
                }
            } else {

                jsConsole.writeLine('The greatest of the 5 is <strong>' + max + '</strong>'); // greatest = second
            }
        }
    } else {
        if (max < thirdVar) {
            max = thirdVar;
            if (max < forthVar) {
                max = forthVar;
                if (max < fifthVar) {
                    max = fifthVar;
                    jsConsole.writeLine('The greatest of the 5 is <strong>' + max + '</strong>'); // greatest = fifth
                } else {
                    jsConsole.writeLine('The greatest of the 5 is <strong>' + max + '</strong>'); // greatest = forth
                }
            } else {
                if (max < fifthVar) {
                    max = fifthVar;
                    jsConsole.writeLine('The greatest of the 5 is <strong>' + max + '</strong>'); // greatest = fifth
                } else {
                    jsConsole.writeLine('The greatest of the 5 is <strong>' + max + '</strong>'); // greatest = third
                }
            }
        } else {
            jsConsole.writeLine('The greatest of the 5 is <strong>' + max + '</strong>'); // greatest - first
        }
    }
}
