/*jslint browser: true*/

var canvas = document.getElementById('the-canvas'),
    manStartingPoint = {
        x: 15,
        y: 349
    },
    bicycleStartingPoint = {
        x: 163,
        y: 349
    },
    houseStartingPoint = {
        x: 490,
        y: 349
    };

canvas.style.border = '1px solid #000';
canvas.style.borderRadius = '3px';

function DrawMan() {
    'use strict';

    var x = manStartingPoint.x,
        y = manStartingPoint.y,
        ctx = canvas.getContext('2d'),
        radius = 55;

    ctx.fillStyle = '#90cad6';
    ctx.strokeStyle = '#22545e';
    ctx.lineWidth = 2;

    // draw the man's head
    ctx.beginPath();
    DrawCircle(ctx, x, y - 110, radius);
    ctx.fill();
    ctx.stroke();

    // draw the eyes
    ctx.beginPath();
    ctx.fillStyle = '#22545e';
    ctx.strokeStyle = '#22545e';
    DrawEye(ctx, x + 20, y - 70);
    ctx.fill();
    ctx.stroke();
    DrawEye(ctx, x + 65, y - 70);
    ctx.fill();
    ctx.stroke();
    ctx.closePath();

    // draw the nose
    DrawLine(ctx, x + 42, y - 70, x + 28, y - 43);
    DrawLine(ctx, x + 28, y - 43, x + 42, y - 43);

    // draw the mouth
    ctx.save();
    DrawMouth(ctx, x + 42, y - 20);

    // draw the hat
    ctx.restore();
    y -= 105;
    ctx.beginPath();
    ctx.fillStyle = '#396591';
    ctx.strokeStyle = '#000';
    DrawEllipse(ctx, 64, y, 125, 40);
    ctx.fill();
    ctx.stroke();
    DrawEllipse(ctx, 68, y - 10, 65, 30);
    ctx.fillRect(35, y - 80, 65, 70);
    DrawLine(ctx, 35, y - 80, 35, y - 10);
    DrawLine(ctx, 100, y - 80, 100, y - 10);
    DrawEllipse(ctx, 68, y - 78, 63, 35);
    ctx.fill();
    ctx.stroke();
    ctx.closePath();
}

function DrawBicycle() {
    'use strict';

    var x = bicycleStartingPoint.x,
        y = bicycleStartingPoint.y,
        ctx = canvas.getContext('2d'),
        radius,
        newX,
        newY;

    ctx.fillStyle = '#90cad6';
    ctx.strokeStyle = '#307a8c';
    ctx.lineWidth = 2;

    // draw left tyre
    radius = 55;
    ctx.beginPath();
    DrawCircle(ctx, x, y - 110, radius);
    y -= 55;
    ctx.fill();
    ctx.stroke();

    // draw the right tyre
    ctx.beginPath();
    DrawCircle(ctx, x + 210, y - 55, radius);
    ctx.fill();
    ctx.stroke();

    // draw the steering wheel of the bicycle
    newX = x + 265;
    DrawLine(ctx, newX, y, newX - 27, y - 115);
    newX -= 27;
    newY = y - 115;
    DrawLine(ctx, newX, newY, newX - 40, newY + 20);
    DrawLine(ctx, newX, newY, newX + 25, newY - 35);

    // draw the frame of the bicycle
    //ctx.beginPath();
    x += 50;
    DrawLine(ctx, x, y, x + 70, y - 70);
    x += 70;
    y -= 70;
    DrawLine(ctx, x, y, x + 130, y);
    x += 130;
    DrawLine(ctx, x, y, x - 105, y + 67);
    x -= 105;
    y += 67;
    DrawLine(ctx, x, y, x - 95, y + 3);
    DrawLine(ctx, x, y, x - 43, y - 96);

    // add the seat
    DrawLine(ctx, x - 63, y - 96, x - 20, y - 96);

    // draw the wheel for the pedals
    x -= 15;
    y -= 15;
    radius = 15;
    DrawCircle(ctx, x, y, radius);

    // add the pedals
    DrawLine(ctx, x + 5, y + 5, x - 7, y - 7);
    x += 25;
    y += 25;
    DrawLine(ctx, x, y, x + 12, y + 12);
}

function DrawHouse() {
    'use strict';

    var x = houseStartingPoint.x,
        y = houseStartingPoint.y,
        radius,
        ctx = canvas.getContext('2d');

    ctx.fillStyle = '#965c5c';
    ctx.strokeStyle = '#000';
    ctx.lineWidth = 2;
    ctx.lineJoin = 'round';

    // start drawing the base of the house
    ctx.beginPath();
    ctx.moveTo(x, y);
    ctx.lineTo(x, y - 198);
    ctx.stroke();
    y -= 198;

    // draw the roof of the house
   // ctx.moveTo(x, y);
    ctx.lineTo(x + 125, y - 149);
    ctx.stroke();
    x += 125;
    y -= 149;
    ctx.lineTo(x + 125, y + 149);
    ctx.stroke();
    x += 125;
    y += 149;

    // continue drawing the base of the house
    ctx.lineTo(x, y + 198);
    ctx.stroke();
    y += 198;
    ctx.lineTo(x - 250, y);
    x -= 250;
    ctx.stroke();
    ctx.fill();
    ctx.moveTo(x, y - 198);
    ctx.lineTo(x + 250, y - 198);
    ctx.stroke();

    // draw the chimney - first I draw a rectangle at the place where the chimney will be to fill it with color, then add the top and sides of the chimney
    ctx.beginPath();
    x = 660;
    y = 30;
    ctx.fillRect(x, y, 30, 85);
    DrawLine(ctx, x, y, x, y + 85);
    x += 30;
    DrawLine(ctx, x, y, x, y + 85);
    DrawEllipse(ctx, 675, 30, 30, 10);
    ctx.fill();
    ctx.stroke();

    // add the windows
    x = 510;
    y = 175;
    DrawWindow(ctx, x, y);
    x += 120;
    DrawWindow(ctx, x, y);
    y += 82;
    DrawWindow(ctx, x, y);

    // draw the door
    x = 522;
    y = 349;
    DrawLine(ctx, x, y, x, y - 65);
    DrawLine(ctx, x + 33, y, x + 33, y - 83);
    x += 33;
    DrawLine(ctx, x + 33, y, x + 33, y - 65);
    ctx.beginPath();
    ctx.moveTo(522, 284);
    ctx.quadraticCurveTo(555, 251, 588, 284);
    ctx.stroke();

    // draw the door knobs
    x = 540;
    y = 320;
    radius = 4;
    DrawCircle(ctx, x, y, radius);
    x += 22;
    DrawCircle(ctx, x, y, radius);
}

function DrawLine(ctx, startingPointX, startingPoinY, endingPointX, endingPointY) {
    'use strict';

    ctx.beginPath();
    ctx.moveTo(startingPointX, startingPoinY);
    ctx.lineTo(endingPointX, endingPointY);
    ctx.stroke();
}

function DrawEllipse(ctx, centerX, centerY, width, height) {
    'use strict';

    ctx.beginPath();
    ctx.moveTo(centerX - width / 2, centerY); //starting point for the ellipse
    ctx.bezierCurveTo(centerX - width / 2, centerY + height / 2,
                        centerX + width / 2, centerY + height / 2,
                        centerX + width / 2, centerY);
    ctx.bezierCurveTo(centerX + width / 2, centerY - height / 2,
                        centerX - width / 2, centerY - height / 2,
                        centerX - width / 2, centerY);
    ctx.stroke();
}

function DrawWindow(ctx, startingPointX, startingPointY) {
    'use strict';

    ctx.fillStyle = '#000';
    ctx.fillRect(startingPointX, startingPointY, 43, 30);
    ctx.fillRect(startingPointX + 45, startingPointY, 43, 30);
    ctx.fillRect(startingPointX, startingPointY + 32, 43, 30);
    ctx.fillRect(startingPointX + 45, startingPointY + 32, 43, 30);
}

function DrawCircle(ctx, startingPointX, startingPointY, radius) {
    'use strict';

    var centerX = startingPointX + radius,
        centerY = startingPointY + radius;

    ctx.beginPath();
    ctx.arc(centerX, centerY, radius, 0, 2 * Math.PI);
    ctx.stroke();
}

function DrawEye(ctx, x, y) {
    'use strict';

    var widthEye = 20,
        heightEye = 20,
        widthIris = 5,
        heightIris = 15;

    DrawEllipse(ctx, x, y, widthEye, heightEye);
    DrawEllipse(ctx, x - 3, y, widthIris, heightIris);
}

function DrawMouth(ctx, x, y) {
    'use strict';

    ctx.beginPath();
    ctx.rotate(6 * Math.PI / 180);
    DrawEllipse(ctx, x + 37, y - 11, 45, 20);
}