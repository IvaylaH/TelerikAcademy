/// <reference path="../libs/handlebars.js" />
/*globals window, document, console*/

window.onload = function () {
    'use strict';

    var options = [{
        value: 1,
        content: 'Coldplay - See you soon'
    }, {
        value: 2,
        content: 'Coldplay - What if'
    }, {
        value: 3,
        content: 'Coldplay - The Scientist'
    }, {
        value: 4,
        content: 'Coldplay - Christmas lights'
    }, {
        value: 5,
        content: 'Coldplay - Magic'
    }, {
        value: 6,
        content: 'Coldplay - Charlie Brown'
    }, {
        value: 7,
        content: 'Pink Floyd - Wish you were here'
    }];

    var container = document.getElementById('container'),
        selectStructure = document.getElementById('select-template'),
        optionsHtml = selectStructure.innerHTML,
        selectTemplate = Handlebars.compile(optionsHtml);

    container.innerHTML += selectTemplate({ options: options });
};