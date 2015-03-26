jsConsole.writeLine('6. Enter the coefficients a, b and c of a quadratic equation: a*x2 + b*x + c = 0.');
jsConsole.writeLine('-> Calculate and print its real roots');
jsConsole.writeLine('');
/*jslint browser: true*/

function parseUserInput() {
    'use strict';

    var a, b, c;

    a = parseFloat(document.getElementById("coefficientA").value, 10);
    b = parseFloat(document.getElementById("coefficientB").value, 10);
    c = parseFloat(document.getElementById("coefficientC").value, 10);

    if (!isNaN(a) && !isNaN(b) && !isNaN(c)) {
        return {
            a: a,
            b: b,
            c: c
        };
    }
    //if after parsing the user input, one or more of the values are NaN, then the function should return 'undefined'
    return undefined;
}
function generateQuadraticEquation() {
    'use strict';

    var parseFunc = parseUserInput();

    // parseUserInput() returns undefined, return 'Invalid input!' 
    if (parseFunc === undefined) {
        return jsConsole.writeLine('Invalid input! Either one or all of the coefficients are NOT in the correct format!');
    }

    jsConsole.writeLine('The quadratic equation is: <strong>' + parseFunc.a + '*x2 + (' + parseFunc.b + '*x) + (' + parseFunc.c + ') = 0.</strong>');
    jsConsole.writeLine('');
}

function calculateRealRoots() {
    'use strict';

    var parseFunc, a, b, c, d, x1, x2;

    parseFunc = parseUserInput();

    // parseUserInput() returns undefined, return 'Invalid input!' therefore the program won't try to make any calculations for the roots of the equation.
    if (parseFunc === undefined) {
        return jsConsole.writeLine('Invalid input! Either one or all of the coefficients are NOT in the correct format!');
    }

    a = parseFunc.a;
    b = parseFunc.b;
    c = parseFunc.c;
    d = b * b - 4 * a * c;

    if (d > 0) {
        x1 = (-b + Math.sqrt(d)) / (2 * a);
        x2 = (-b - Math.sqrt(d)) / (2 * a);
        jsConsole.writeLine('The quadratic equation has 2 real root: <strong>x1 = ' + x1 + ', x2 = ' + x2 + '</strong>');
    } else if (d === 0) {
        x1 = x2 = - b / (2 * a);
        jsConsole.writeLine('The quadratic equation has 1 real root: <strong>x1 = x2 = ' + x1 + '</strong>.');
    } else {
        jsConsole.writeLine('The quadratic equation has no real roots!');
    }
}