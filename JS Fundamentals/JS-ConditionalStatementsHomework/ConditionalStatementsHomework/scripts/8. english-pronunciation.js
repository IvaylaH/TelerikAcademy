jsConsole.writeLine('Write a script that converts a number in the range [0...999] to a text corresponding to its English pronunciation.');
jsConsole.writeLine('');
/*jslint browser: true*/

function convertNumberToPronunciation() {
    'use strict';

    var result, remainder, inputNumber, pronunciation;
    inputNumber = parseInt(document.getElementById("inputNumber").value, 10);

    if (!isNaN(inputNumber)) {
        if (inputNumber < 10) {
            remainder = inputNumber % 10;
            pronunciation = convertUnits(remainder);

            jsConsole.writeLine('The English pronunciation of the number <strong>' + inputNumber + '</strong> is: <strong>' + pronunciation + '</strong>.');
        } else if (inputNumber > 9 && inputNumber < 20) {
            pronunciation = convertTeens(inputNumber);

            jsConsole.writeLine('The English pronunciation of the number <strong>' + inputNumber + '</strong> is: <strong>' + pronunciation + '</strong>.');
        } else if (inputNumber > 9 && inputNumber < 100) {
            result = inputNumber / 10 | 0;
            remainder = inputNumber % 10;
            pronunciation = convertTens(result);

            if (remainder !== 0) {
                pronunciation += '-' + convertUnits(remainder);
            }

            jsConsole.writeLine('The English pronunciation of the number <strong>' + inputNumber + '</strong> is: <strong>' + pronunciation + '</strong>.');
        } else {
            result = inputNumber / 100 | 0;
            pronunciation = convertHundreds(result);
            remainder = inputNumber % 100;

            if (remainder !== 0) {
                result = remainder / 10 | 0;
                remainder %= 10;
                pronunciation += ' ' + convertTens(result);

                if (remainder !== 0) {
                    pronunciation += '-' + convertUnits(remainder);
                }
            }

            jsConsole.writeLine('The English pronunciation of the number <strong>' + inputNumber + '</strong> is: <strong>' + pronunciation + '</strong>.');
        }
    } else {
        jsConsole.writeLine('Invalid input! Please try again to enter a number in the range [0...999]!');
    }
}

function convertUnits(digit) {
    'use strict';

    switch (digit) {
    case 0:
        return 'zero';
    case 1:
        return 'one';
    case 2:
        return 'two';
    case 3:
        return 'three';
    case 4:
        return 'four';
    case 5:
        return 'five';
    case 6:
        return 'six';
    case 7:
        return 'seven';
    case 8:
        return 'eight';
    case 9:
        return 'nine';
    default:
        return jsConsole.writeLine('Invalid input!');
    }
}

function convertTeens(number) {
    'use strict';

    switch (number) {
    case 10:
        return 'ten';
    case 11:
        return 'eleven';
    case 12:
        return 'twelve';
    case 13:
        return 'thirteen';
    case 14:
        return 'fourteen';
    case 15:
        return 'fifteen';
    case 16:
        return 'sixteen';
    case 17:
        return 'seventeen';
    case 18:
        return 'eightteen';
    case 19:
        return 'nineteen';
    default:
        return jsConsole.writeLine('Invalid input!');
    }
}

function convertTens(number) {
    'use strict';

    switch (number) {
    case 2:
        return 'twenty';
    case 3:
        return 'thirty';
    case 4:
        return 'forty';
    case 5:
        return 'fifty';
    case 6:
        return 'sixty';
    case 7:
        return 'seventy';
    case 8:
        return 'eighty';
    case 9:
        return 'ninety';
    default:
        return jsConsole.writeLine('Invalid input!');
    }
}

function convertHundreds(number) {
    'use strict';

    switch (number) {
    case 1:
        return 'one hundred';
    case 2:
        return 'two hundred';
    case 3:
        return 'three hundred';
    case 4:
        return 'four hundred';
    case 5:
        return 'five hundred';
    case 6:
        return 'six hundred';
    case 7:
        return 'seven hundred';
    case 8:
        return 'eight hundred';
    case 9:
        return 'nine hundred';
    default:
        return jsConsole.writeLine('Invalid input!');
    }
}

