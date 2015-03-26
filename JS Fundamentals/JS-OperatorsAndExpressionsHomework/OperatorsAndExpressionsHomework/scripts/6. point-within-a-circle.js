jsConsole.writeLine('6. Write an expression that checks if given print (x,  y) is within a circle K(O, 5).');
jsConsole.writeLine('');
/*jslint browser: true*/

function checkIfPointIsWithinK() {
    'use strict';

    var x = parseFloat(document.getElementById("xNum").value, 10);
    var y = parseFloat(document.getElementById("yNum").value, 10);

    if (!isNaN(x) && !isNaN(y)) {
        if ((x > -5 && x < 5) && (y > -5 && x < 5)) {
            jsConsole.writeLine('The point (' + x + ', ' + y + ') is within circle K(0, 5).');
        } else {
            jsConsole.writeLine('The point (' + x + ', ' + y + ') is outside circle K(0, 5).');
        }
    } else {
        jsConsole.writeLine('Invalid input! Either x, or y are not in the correct format!');
    }
}