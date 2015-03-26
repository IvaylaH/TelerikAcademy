jsConsole.writeLine('3. Write an expression that calculates rectangle’s area by given width and height.');
jsConsole.writeLine('');
/*jslint browser: true*/

function calculateArea() {
    'use strict';

    // JSLint was giving me an error - 'Combine this with the previous 'var' statement', according to a guy on StackOverflow, JSLint wants you to declare all the variables using one 'var' and then intialize each one of the variables
    var width, height, area;

    width = parseFloat(document.getElementById("width").value, 10);
    height = parseFloat(document.getElementById("height").value, 10);

    if (!isNaN(width) && !isNaN(height)) {
        area = width * height;
        jsConsole.writeLine('The area of a rectangle with width = ' + width + ' and height = ' + height + ' is: ' + area);
    } else {
        jsConsole.writeLine('Invalid input! Either the width, or the height of the ractangle was not in the correct format!');
    }
}