/*globals document, window, console*/

var movingShapes = (function moveShapes() {
    'use strict';

    var randomColor,
        addingNewDiv;

    randomColor = function generateRandomColor() {
        var red = parseInt(Math.random() * 256, 10),
            green = parseInt(Math.random() * 256, 10),
            blue = parseInt(Math.random() * 256, 10);

        return 'rgb(' + red + ', ' + green + ', ' + blue + ')';
    };

    function moveInEllipse(angle, newDiv) {
        var r1 = 120,
            r2 = 160,
            xCenter = 350,   // x coordinate for the ellipse's center
            yCenter = 550,   // y coordinate for the ellipse's center
            x = Math.floor(xCenter + (r1 * Math.cos(angle))),
            y = Math.floor(yCenter + (r2 * Math.sin(angle)));

        angle = angle + 0.01;  // the angle changes with 0.01 every 20 milliseconds
        newDiv.style.top = x + "px";   // setting the x position of the div
        newDiv.style.left = y + "px";  // setting the y position of the div

        setTimeout(function () {   //repeats the function moveInEllipse which allows the constant movement of the selected div 
            moveInEllipse(angle, newDiv);
        }, 20);
    };

    function moveInRect(x, y, currentDirection, newDiv) {
        var totalX = 1250,         // width of the rectangle
            totalY = 600,         // height of the rectangle
            startX = 850,           // staring x position for the div
            startY = 250,  // starting y position for the div
            direction = currentDirection,     // initial direction of the movement
            offset;               // moving step

        if (direction === 'right' || direction === 'down') {
            offset = +1;
        } else if (direction === 'left' || direction === 'up') {
            offset = -1;
        }

        if (direction === 'up') {
            y += offset;
       //     isFirstTurn = false;
            if (y === startY) {
                direction = 'right';
                console.log(y);
                console.log(x);
            }
        } else if (direction === 'right') {
            x += offset;
            if (x === totalX) {
                direction = 'down';
                console.log(y);
                console.log(x);
            }
        } else if (direction === 'down') {
            y += offset;
            if (y === totalY) {
                direction = 'left';
                console.log(y);
                console.log(x);
            }
        } else if (direction === 'left') {
            x += offset;
            if (x === startX) {
                direction = 'up';
                console.log(y);
                console.log(x);
            }
        }

        newDiv.style.top = y + 'px';  // setting the x position of the div
        newDiv.style.left = x + 'px';  // setting the y position of the div

        setTimeout(function () { // repeats the moveInRect function which allows the constant movement of the selected div
            moveInRect(x, y, direction, newDiv);
        }, 20);
    };

    addingNewDiv = function add(shape) {
        var parentElement = document.querySelector('#moving-divs'),
            newDiv = document.createElement('div');

        // applying styles to the div element
        newDiv.style.backgroundColor = randomColor();
        newDiv.style.border = '1px solid' + randomColor();
        newDiv.style.borderRadius = '75px';
        newDiv.style.color = randomColor();
        newDiv.style.width = '50px';
        newDiv.style.textAlign = 'center';
        newDiv.style.position = 'absolute';
      //  newDiv.style.top = '0';
      //  newDiv.style.left = '0';
        newDiv.innerHTML = 'div';

        parentElement.appendChild(newDiv);

        if (shape === 'rect') {
            moveInRect(850, 250, 'right', newDiv);
        } else if (shape === 'ellipse') {
            moveInEllipse(0, newDiv);
        }
    };

    return {
        add: addingNewDiv
    };
}());