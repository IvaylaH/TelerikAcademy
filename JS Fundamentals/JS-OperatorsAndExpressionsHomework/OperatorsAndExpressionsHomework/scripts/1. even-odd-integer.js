jsConsole.writeLine('1. Write an expression that checks if given integer is odd or even.');
jsConsole.writeLine('');

function onClickParseValue() {
    // I cheched my code with JSLint and it gave the following error: "Missing 'use strict' statement", I googled it and found that the 'use strict' statement is used to prevent certain actions and help us make fewer mistakes
    'use strict';

    /*jslint browser: true*/
    // here JSLint again indicated an error - 'Document was used before it was defined', a guy in StackOverflow has explainded that - document does not exist everywhere, so we have to manually tell JSLint that the js code will be executed in browser and thus the 'document' global variable is defined

    var integer = parseInt(document.getElementById("inputInt").value, 10);
    if (!isNaN(integer)) {
        if (integer % 2 === 0) {
            jsConsole.writeLine('The number "' + integer + '" you have entered is: even');
        } else {
            jsConsole.writeLine('The number "' + integer + '" you have entered is: odd');
        }
    } else {
        jsConsole.writeLine('Invalid input! Please enter an integer number!');
    }
}