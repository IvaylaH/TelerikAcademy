/*globals window, document, console*/

var domModule = (function createDomModuler() {
    'use strict';

    var buffer = [],
        childElement,
        removedChild,
        appendEvent,
        appendToBuffer;

    // add DOM element to parent element given by selector
    childElement = function addChild(child, selector) {
        var parent = document.querySelector(selector);
        parent.appendChild(child);
    };

    // remove element from the DOM by given selector
    removedChild = function removeChild(selector) {
        var elementToRemove = document.querySelector(selector),
            parent = elementToRemove.parentNode;

        parent.removeChild(elementToRemove);
    };

    // attach event to given selector by given event type and event handler
    appendEvent = function addEvent(elementSelector, eventType, eventHandler) {
        var element = document.querySelector(elementSelector);
        if (element.addEventListener) {
            element.addEventListener(eventType, eventHandler, false);
        } else {
            element.attachEvent('on' + eventType, eventHandler);
        }
    };

    // add elements to buffer, which appends them to the DOM when their count for some selector becomes 100
    appendToBuffer = function appendToBuffer(selector, element) {
        if (!document.querySelector(selector)) {
            console.error('There is NO such element in the DOM!');
            return;
        }

        if (buffer[selector]) {
            buffer[selector].push(element);

            if (buffer[selector].length >= 100) {
                var docFragment = document.createDocumentFragment(),
                    currentElement,
                    currentDomElement,
                    len,
                    i;

                for (i = 0, len = buffer[selector].length; i < len; i += 1) {
                    currentElement = buffer[selector][i];
                    docFragment.appendChild(currentElement);
                }

                currentDomElement = document.querySelector(selector);
                currentDomElement.appendChild(docFragment);
                buffer[selector] = [];
            }
        } else {
            buffer[selector] = [];
            buffer[selector].push(element);
        }
    };

    return {
        appendChild: childElement,
        removeChild: removedChild,
        addEvent: appendEvent,
        appendToBuffer: appendToBuffer
    };
}());