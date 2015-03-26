jsConsole.writeLine('8. Write an expression that calculates trapezoid\'s area by given sides a and b and height h.');
jsConsole.writeLine('');
/*jslint browser: true*/

function calculateArea() {
    'use strict';

    var a = parseFloat(document.getElementById("inputA").value, 10);
    var b = parseFloat(document.getElementById("inputB").value, 10);
    var h = parseFloat(document.getElementById("inputH").value, 10);

    if (!isNaN(a) && !isNaN(b) && !isNaN(h)) {
        var area = (a + b) / 2 * h;
        jsConsole.writeLine('The area of the trapezoid is: ((a + b) / 2) * h = ' + area + '.');
    } else {
        jsConsole.writeLine('Invalid input! Either a, or b, or h is NOT in the correct format!');
    }
}