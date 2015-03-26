console.log('4. Write a function to count the number of divs on the web page');
console.log('');
/*jslint browser: true*/

function countDivsInsideAnHtml() {
    'use strict';

    var counter = document.getElementsByTagName('div').length;
    console.log('There are ' + counter + ' div tags inside this HTML document.');
}