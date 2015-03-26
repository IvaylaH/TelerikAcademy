console.log('11. Write a function that formats a string using placeholders. The function should work with up to 30 placeholders and all types.');
console.log('');

function formatString() {
    'use strict';

    var stringToFormat, pos, numSubstr, placeholder, closingBracketIndex, placeholderNum;

    stringToFormat = String(arguments[0]);

    if (arguments.length === 0) {
        return undefined;
    }

    pos = stringToFormat.indexOf('{');

    while (pos !== -1) {
        closingBracketIndex = stringToFormat.indexOf('}', pos);
        numSubstr = stringToFormat.substring(pos + 1, closingBracketIndex).trim();
        placeholderNum = parseInt(numSubstr, 10);
        placeholder = stringToFormat.substring(pos, closingBracketIndex + 1).trim();

        stringToFormat = stringToFormat.replace(placeholder, arguments[placeholderNum + 1]);
        pos = stringToFormat.indexOf('{', pos + 1);
    }

    return stringToFormat;
}

function applyFormatStringFunc() {
    'use strict';

    var stringToFormat, formattedStr;

    stringToFormat = 'Hello {0}!\'';
    formattedStr = formatString(stringToFormat, 'Peter');

    console.log('Original string: ' + stringToFormat + '.');
    console.log('Formatted string: ' + formattedStr + '.');
}