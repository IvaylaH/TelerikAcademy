/*globals window, document, console*/

window.onload = function () {
    'use strict';

    var container = document.getElementById('container');
    container.style.width = '970px';
    container.style.height = '610px';
    container.style.backgroundColor = '#73dbf0';
    container.style.border = '1px solid #000';
    container.style.borderRadius = '10px';
    container.style.margin = '5px 150px';
    //container.style.alignContent = 'center';
    container.style.padding = '30px 45px';

    var svg = document.getElementById('the-svg');
    svg.style.border = '3px solid #daeaed';
    svg.style.borderRadius = '5px';
};