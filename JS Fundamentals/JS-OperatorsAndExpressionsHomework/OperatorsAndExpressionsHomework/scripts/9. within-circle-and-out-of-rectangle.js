jsConsole.writeLine('9. Write an expression that checks for given point (x, y) if it is within the circle K( (1,1), 3) and out of the rectangle R(top=1, left=-1, width=6, height=2).');
jsConsole.writeLine('');
/*jslint browser: true*/

function checkPointCoordinates() {
    'use strict';

    var x = parseFloat(document.getElementById("inputX").value, 10);
    var y = parseFloat(document.getElementById("inputY").value, 10);

    if (!isNaN(x) && !isNaN(y)) {
        if (((-3 < x && x < - 1.1) || (1.1 < x && x < 3)) && ((-3 < y && y < -1.1) || (1.1 < y && y < 3))) {
            jsConsole.writeLine('Point (' + x + ', ' + y + ') is within circle K((1,1), 3) and out of rectangle R(top=1, left=-1, width=6, height=2)');
        } else if ((3 < x  && x < 5) && (-1 < y && y < 1)) {
            jsConsole.writeLine('Point (' + x + ', ' + y + ') is out of circle K((1,1), 3) but inside rectangle R(top=1, left=-1, width=6, height=2)');
        } else if ((1.1 < x && x < 3) && (-1 < y && y < 1)) {
            jsConsole.writeLine('Point (' + x + ', ' + y + ') is inside both circle K((1,1), 3) and rectangle R(top=1, left=-1, width=6, height=2)');
        } else if ((x < -3 || x > 5) && (y < -3 || y > 3)) {
            jsConsole.writeLine('Point (' + x + ', ' + y + ') is out of circle K((1,1), 3) and out of rectangle R(top=1, left=-1, width=6, height=2)');
        } else {
            jsConsole.writeLine('Point (' + x + ', ' + y + ') is out of circle K((1,1), 3) and out of rectangle R(top=1, left=-1, width=6, height=2)');
        }
    } else {
        jsConsole.writeLine('Invalid input! Either x, or y are NOT in the correct format!');
    }
}