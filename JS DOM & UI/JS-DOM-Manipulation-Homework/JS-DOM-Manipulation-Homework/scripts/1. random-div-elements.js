/*globals window, document, console*/

window.onload = function () {
    'use strict';

    var numberOfDivs = GenerateRandomIntInRange(5, 25),
        container = document.getElementById('container'),
        listFragment = document.createDocumentFragment(),
        newDiv,
        i;

    for (i = 0; i < numberOfDivs; i += 1) {
        newDiv = document.createElement('div', i);
        SetAttributes(newDiv, i);

        listFragment.appendChild(newDiv);
    }

    container.appendChild(listFragment);

    function SetAttributes(divElement, i) {
        var numberWidth = GenerateRandomIntInRange(20, 100),
            numberHeight = GenerateRandomIntInRange(20, 100),
            bgColor = GenerateRandomColor(),
            fontColor = GenerateRandomColor();

        divElement.style.width = numberWidth + 'px';
        divElement.style.height = numberHeight + 'px';

        if (ShouldApplyProperty()) {
            var borderColor = GenerateRandomColor(),
                borderWidth = GenerateRandomIntInRange(1, 20),
                borderRadius = GenerateRandomIntInRange(0, 10);

            divElement.style.border = borderWidth + 'px solid' + borderColor;
            divElement.style.borderRadius = borderRadius;
        }

        if (ShouldApplyProperty()) {
            var strong = document.createElement('strong');
            strong.innerHTML = 'Div # ' + i;
            divElement.appendChild(strong);
        } else {
            divElement.innerHTML = 'Div # ' + i;
        }

        divElement.style.background = bgColor;
        divElement.style.color = fontColor;
        divElement.style.position = 'absolute';
        divElement.style.top = GenerateRandomIntInRange(15, 75) + '%';
        divElement.style.left = GenerateRandomIntInRange(0, 75) + '%';
    }


    function GenerateRandomIntInRange(min, max) {
        var number = Math.floor(Math.random() * (max - min + 1)) + min;

        return number;
    }

    function GenerateRandomColor() {
        var letters = '0123456789ABCDEF'.split(''),
            color = '#',
            j;

        for (j = 0; j < 6; j += 1) {
            color += letters[Math.floor(Math.random() * 16)];
        }

        return color;
    }

    function ShouldApplyProperty() {
        var number = Math.random(),
            numberToCheck = Math.floor(number * 100);

        if (numberToCheck >= 2 && numberToCheck % 2 === 0) {
            return true;
        }

        return false;
    }
};