console.log('1. Write functions for working with shapes in  standard Planar coordinate system');
console.log('');

function getPoint(x, y) {
    'use strict';

    var point = {
        x: x,
        y: y
    };

    return point;
}

function getLine(point1, point2) {
    'use strict';

    var line = {
        A: point1,
        B: point2
    };

    return line;
}

function calculateDistance(p1, p2) {
    'use strict';

    var distance, xCoordsSquared, yCoordsSquared;

    xCoordsSquared = (p2.x - p1.x) * (p2.x - p1.x);
    yCoordsSquared = (p2.y - p1.y) * (p2.y - p1.y);
    distance = Math.sqrt(xCoordsSquared + yCoordsSquared);

    return distance;
}

function checkIfCanFormATriangle(line1, line2, line3) {
    'use strict';

    var a, b, c;

    a = calculateDistance(line1.A, line1.B);
    b = calculateDistance(line2.A, line2.B);
    c = calculateDistance(line3.A, line3.B);

    return a + b > c && b + c > a && a + c > b;
}

function checkRandomThreePoints() {
    'use strict';

    var p1, p2, p3, line1, line2, line3, distance;

    p1 = getPoint(-1, 3);
    p2 = getPoint(4, 5);
    p3 = getPoint(1, 4);

    line1 = getLine(p1, p2);
    line2 = getLine(p2, p3);
    line3 = getLine(p1, p3);

    distance = calculateDistance(p1, p2);
    printDistance(p1, p2, distance);
    distance = calculateDistance(p2, p3);
    printDistance(p2, p3, distance);
    distance = calculateDistance(p1, p3);
    printDistance(p1, p3, distance);

    if (checkIfCanFormATriangle(line1, line2, line3)) {
        console.log('Triangle can be formed!');
    } else {
        console.log('Triangle CANNOT be formed!');
    }
}

function printDistance(point1, point2, distance) {
    'use strict';

    console.log('The distance between p1{' + point1.x + ', ' + point1.y + '}' + 'and p2{' + point2.x + ', ' + point2.y + '} is: ' + distance + '.');
}
