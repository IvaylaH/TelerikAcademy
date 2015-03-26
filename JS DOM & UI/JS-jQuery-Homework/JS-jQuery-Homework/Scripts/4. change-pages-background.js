/*globals window, document, console, $*/

window.onload = function () {
    'use strict';

    var $container = $('#container'),
        $inputColor;

    // input type color is not supported on Firefox and IE, but is working OK in Chrome
    $inputColor = $('<input>')
        .attr({
            'type': 'color',
            'id': 'color-picker'
        })
        .on('change', changeBackgroundColor)
        .appendTo($container);

    function changeBackgroundColor() {
        var color = $inputColor.val();
        $('body').css('background-color', color);
    }
};