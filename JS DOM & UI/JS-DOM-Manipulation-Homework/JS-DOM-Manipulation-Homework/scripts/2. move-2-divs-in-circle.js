/*globals window, document, console, screen*/

window.onload = function () {
    'use strict';

    var centerTop = parseInt((screen.height - 300) / 2, 10),
        centerLeft = parseInt((screen.width - 100) / 2, 10),
        pathRadius = 150,
        divsCount = 5,
        degrees = [],
        degreesIncrement = 5;

    GenerateDivs(divsCount);
    MoveDivsInCircle();

    function SetAttributes(divElement) {
        var numberWidth = 15 + 'px',
            numberHeight = 30 + 'px',
            bgColor = GenerateRandomColor();

        divElement.style.width = numberWidth;
        divElement.style.height = numberHeight;
        divElement.style.border = '1px solid #000';
        divElement.style.borderRadius = 50 + 'px';

        divElement.style.background = bgColor;
        divElement.style.position = 'absolute';
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

    function GenerateDivs(divsCount) {
        var container = document.getElementById('container'),
            divsFragment = document.createDocumentFragment(),
            initialAngel = 0,
            newAngle = parseInt(360 / divsCount, 10),
            circleDiv,
            i;

        for (i = 0; i < divsCount; i += 1) {
            circleDiv = document.createElement('div');
            circleDiv.classList.add('circle-div');
            SetAttributes(circleDiv);

            // setting the initial coordinates of the div elements
            CalculateNewPosition(circleDiv, centerTop, centerLeft, pathRadius, initialAngel);
            degrees.push(initialAngel);

            divsFragment.appendChild(circleDiv);
            initialAngel += newAngle;
        }

        container.appendChild(divsFragment);
    }

    // actually rotating the divs
    function MoveDivsInCircle() {
        var divsCollection = document.getElementsByClassName('circle-div'),
            currentDiv,
            currentDivsAngle,
            len,
            j;

        for (j = 0, len = divsCollection.length; j < len; j += 1) {
            currentDiv = divsCollection[j],
            degrees[j] += degreesIncrement;
            currentDivsAngle = degrees[j];

            if (currentDivsAngle >= 360) {
                currentDivsAngle = currentDivsAngle % 360;
            }

            CalculateNewPosition(currentDiv, centerTop, centerLeft, pathRadius, currentDivsAngle);
        }

       requestAnimationFrame(MoveDivsInCircle, 100);
    }

    function CalculateNewPosition(currentDiv, centerTop, centerLeft, radius, angle) {
        var angleInRads = angle * Math.PI / 180,
            left = parseInt(centerLeft + radius * Math.sin(angleInRads), 10),
            top = parseInt(centerTop - radius * Math.cos(angleInRads), 10);

        currentDiv.style.left = left + "px";
        currentDiv.style.top = top + "px";
    }
};