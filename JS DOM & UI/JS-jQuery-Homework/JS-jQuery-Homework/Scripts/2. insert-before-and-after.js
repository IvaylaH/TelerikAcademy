/*globals window, document, console, $*/

window.onload = function () {
    'use strict';

    var $container = $('#container'),
        $picture = $('<div><img src="imgs/Purple-Flowers3.jpg" width="500" height="350" /></div>'),
        $buttonPrepend,
        $buttonAppend,
        $buttonInsertBefore,
        $buttonInsertAfter;

    $container.append($picture);
    $buttonAppend = $('<button>')
        .addClass('btn-append')
        .html('Append')
        .css('margin-top', '10px')
        .on('click', placeElementAfterFunctionUsingAppend)
        .appendTo($container);

    $buttonInsertAfter = $('<button>')
        .addClass('btn-insert-after')
        .html('Insert after')
        .css('margin-top', '10px')
        .on('click', placeElementAfterFunctionUsingInsertAfter)
        .appendTo($container);

    $buttonInsertBefore = $('<button>')
        .addClass('btn-insert-before')
        .html('Insert before')
        .css('margin-top', '10px')
        .on('click', placeElementBeforePictureUsingInsertBefore)
        .appendTo($container);

    $buttonPrepend = $('<button>')
        .addClass('btn-prepend')
        .html('Prepend')
        .css('margin-top', '10px')
        .on('click', placeElementBeforePictureUsingPrepend)
        .appendTo($container);

    // insertBefore() and insertAfter() place the element before/after the specified element in the main container
    function placeElementBeforePictureUsingInsertBefore() {
        var text = 'This "div" is placed before the picture using insertBefore().',
            $elementToPlace;

        $elementToPlace = $('<div>' + text + '<div/>')
            .css('font-weight', 'bold')
            .insertBefore($picture);
    }

    function placeElementAfterFunctionUsingInsertAfter() {
        var text = 'This "div" is placed after the picture using insertAfter().',
            $elementToPlace;

        $elementToPlace = $('<div>' + text + '<div/>')
            .css('font-weight', 'bold')
            .insertAfter($picture);
    }

    // append() and prepend() place the new element before/after the specified element but in the same container
    function placeElementBeforePictureUsingPrepend() {
        var text = 'This "div" is placed before the picture using prepend().',
            $elementToPlace;

        $elementToPlace = $('<div>' + text + '<div/>')
            .css('font-weight', 'bold');
        $picture.prepend($elementToPlace);
    }

    function placeElementAfterFunctionUsingAppend() {
        var text = 'This "div" is placed after the picture using append().',
            $elementToPlace;

        $elementToPlace = $('<div>' + text + '<div/>')
            .css('font-weight', 'bold');
        $picture.append($elementToPlace);
    }
};