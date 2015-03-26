/*globals document, window, console*/

var specialeConsole = (function createSpecialConsole() {
    'use strict';

    // custom string.Format()
    function formatPlaceHolders(args) {
        var message = args[0],
            currentSymbol,
            number,
            messageStr = '',
            len,
            i;

        for (i = 0, len = message.length; i < len; i += 1) {
            currentSymbol = message[i];

            if (currentSymbol === '{' && message[i + 2] === '}') {
                number = parseInt(message[i + 1], 10);
                messageStr += args[number + 1];
                i += 2;
            } else {
                messageStr += currentSymbol;
            }
        }

        return messageStr;
    }

    // Writing a line to the console
    function writeLine(message, placeHolderContent) {
        var args = arguments.length,
            fullMessage;

        if (args === 1) {
            console.log(message.toString());
        } else {
            fullMessage = formatPlaceHolders(arguments);
            console.log(fullMessage.toString());
        }
    }

    // Writing errors and warnings to the console with and without format
    function writeError(message, placeHolderContent) {
        var args = arguments.length,
            errorMessage;

        if (args === 1) {
            console.error(message.toString());
        } else {
            errorMessage = formatPlaceHolders(arguments);
            console.error(errorMessage.toString());
        }
    }

    function writeWarning(message, placeHolderContent) {
        var args = arguments.length,
            warningMessage;

        if (args === 1) {
            console.warn(message.toString());
        } else {
            warningMessage = formatPlaceHolders(arguments);
            console.warn(warningMessage.toString());
        }
    }

    return {
        writeLine: writeLine,
        writeError: writeError,
        writeWaring: writeWarning
    };
}());