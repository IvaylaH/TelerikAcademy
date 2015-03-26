/*jslint browser: true*/

(function () {
    'use strict';

    var canvas = document.getElementById('the-canvas'),
        ctx = canvas.getContext('2d'),
        width = ctx.canvas.width,
        height = ctx.canvas.height,
        currentPosition = {
            x: 0,
            y: height / 2
        },
        currentDirection = {
            x: +5,
            y: +5
        },
        justStarted = true;

    canvas.style.border = '1px solid #000';
    canvas.style.borderRadius = '5px';
    canvas.style.margin = '50px 450px';

    function ReleaseTheBall() {
        ctx.clearRect(0, 0, width, height);
        ctx.strokeRect(0, 0, width, height);
        DrawBall(currentPosition.x, currentPosition.y);

        if (justStarted !== true && CheckIfOnBorder(currentPosition.x, currentPosition.y, width, height)) {
            currentDirection = ChangeDirection(currentPosition.x, currentPosition.y, /*currentDirection,*/ width, height);
        }

        currentPosition.x += currentDirection.x;
        currentPosition.y += currentDirection.y;
        justStarted = false;

        requestAnimationFrame(ReleaseTheBall);
    }

    ReleaseTheBall();

    function DrawBall(x, y) {
        var radius = 20,
            centerX = x + radius,
            centerY = y + radius;

        ctx.fillStyle = 'cornflowerblue';
        ctx.strokeStyle = '#000';

        ctx.beginPath();
        ctx.arc(centerX, centerY, radius, 0, 2 * Math.PI);
        ctx.fill()
        ctx.stroke();
    }

    function CheckIfOnBorder(currentX, currentY, width, height) {
        var checkX = currentX <= 0 || currentX >= width - 20,
        checkY = currentY <= 0 || currentY >= height - 25;

        if (checkX || checkY) {
            return true;
        }

        return false;
    }

   /* function ChangeDIrection(currentDirection, radius, width, height) {
        if (currentDirection.x + radius <= 0) {
            currentDirection.x = +5;
        } else if (currentDirection.x + radius >= width - 20) {
            currentDirection.x = -5;
        } else if (currentDirection.y + radius <= 0) {
            currentDirection.y = +5;
        } else if (currentDirection.y + radius >= height - 25) {
            currentDirection.y = -5;
        }

        return currentDirection;
    }*/
    function ChangeDirection(currentX, currentY, /*currentDirection,*/ width, height) {
        var newDirection;

        /* if (currentX <= 0) {
            newDirection = {
                x: +5,
                y: +5
            };
        } else if (currentX >= width - 25) {
            newDirection = {
                x: -5,
                y: -5
            };
        } else if (currentY <= 0) {
            newDirection = {
                x: -5,
                y: +5
            };
        } else if (currentY >= height - 25) {
            newDirection = {
                x: +5,
                y: -5
            };
        }*/
        if (currentX <= 0 && currentDirection.y === -5) {
            newDirection = {
                x: +5,
                y: -5
            };
        } else if (currentX <= 0 && currentDirection.y === +5) {
            newDirection = {
                x: +5,
                y: +5
            };
        } else if (currentX >= width - 20 && currentDirection.y === +5) {
            newDirection = {
                x: -5,
                y: +5
            };
        } else if (currentX >= width - 20 && currentDirection.y === -5) {
            newDirection = {
                x: -5,
                y: -5
            };
        } else if (currentY <= 0 && currentDirection.x === +5) {
            newDirection = {
                x: +5,
                y: +5
            };
        }
        else if (currentY <= 0 && currentDirection.x === -5) {
            newDirection = {
                x: -5,
                y: +5
            };
        } else if (currentY >= height - 25 && currentDirection.x === +5) {
            newDirection = {
                x: +5,
                y: -5
            };
        } else if (currentY >= height - 25 && currentDirection.x === -5) {
            newDirection = {
                x: -5,
                y: -5
            };
        }
        
        return newDirection;
    }
} ())