/*globals window, document, console*/

window.onload = function () {
    'use strict';

    var container = document.getElementById('container'),
        textArea,
        numberOfInputColors = 2,
        fontColor,
        bgColor,
        fragmentList = document.createDocumentFragment(),
        inputElements;

    GenerateHtmlElements();
    container.appendChild(fragmentList);
    inputElements = document.getElementsByTagName('input');

    inputElements[0].onchange = function () {
        fontColor = inputElements[0].value;
        textArea.style.color = fontColor;
    };

    inputElements[1].onchange = function () {
        bgColor = inputElements[1].value;
        textArea.style.background = bgColor;
    };

    function GenerateHtmlElements() {
        var i,
            inputs = [];

        textArea = document.createElement('textarea');
        SetAttributes(textArea);
        fragmentList.appendChild(textArea);

        for (i = 0; i < numberOfInputColors; i += 1) {
            inputs[i] = document.createElement('input');
            inputs[i].classList.add('input-' + i);
            inputs[i].type = 'color';
            inputs[i].style.position = 'absolute';
            inputs[i].style.top = 102 + 'px';

            if (i === 0) {
                inputs[i].style.left = 300 + 'px';
            } else {
                inputs[i].style.left = 360 + 'px';
            }

            fragmentList.appendChild(inputs[i]);
        }
    }

    function SetAttributes(divElement) {
        divElement.style.width = '180px';
        divElement.style.height = '100px';
        divElement.style.position = 'absolute';
        divElement.style.top = 100 + 'px';
        divElement.style.left = 100 + 'px';
        divElement.innerText = 'Let\'s change the font color of this particular textarea! Please be nice and pick BLUE :P';
    }
};