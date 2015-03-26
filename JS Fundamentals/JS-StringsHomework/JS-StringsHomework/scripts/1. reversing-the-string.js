console.log('1. Write a JavaScript function reverses string and returns it.');
console.log('');
/*jslint browser: true*/

function reverseString() {
    'use strict';

    var inputStr, i, len, reversedStr;

    inputStr = document.getElementById('input-string').value;
    reversedStr = '';

    for (i = 0, len = inputStr.length; i < len; i += 1) {
        reversedStr += inputStr[len - i - 1];
    }

    console.log('Original string: \'' + inputStr + '\'.');
    console.log('Reversed string: \'' + reversedStr + '\'.');
}