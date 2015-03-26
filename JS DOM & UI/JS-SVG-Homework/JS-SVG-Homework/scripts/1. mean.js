/*globals window, document, console*/

window.onload = function () {
    'use strict';

    var firstCircle,
        secondCircle,
        thirdCircle,
        forthCircle,
        firstCirclePath1,
        secondCirclePath2,
        thirdCirclePath1,
        thirdCirclePath2,
        thirdCirclePath3,
        thirdCirclePath4,
        thirdCirclePath5,
        thirdCirclePath6,
        thirdCirclePath7,
        express,
        letterM,
        letterE,
        letterA,
        letterN,
        image,
        svg = document.getElementById('svg-js'),
        svgNameSpace = 'http://www.w3.org/2000/svg';

    function CreateCircle(cx, cy, radius, fillColor) {
        var circle;

        circle = document.createElementNS(svgNameSpace, 'circle');
        circle.setAttribute('cx', cx);
        circle.setAttribute('cy', cy);
        circle.setAttribute('r', radius);
        circle.setAttribute('fill', fillColor);

        return circle;
    }

    function CreatePath(points, fillColor) {
        var path;

        path = document.createElementNS(svgNameSpace, 'path');
        path.setAttribute('d', points);
        path.setAttribute('fill', fillColor);

        return path;
    }

    function CreateText(x, y, fillColor) {
        var text;

        text = document.createElementNS(svgNameSpace, 'text');
        text.setAttribute('x', x);
        text.setAttribute('y', y);
        text.setAttribute('fill', fillColor);

        return text;
    }

    function CreateImage(source, x, y, width, height) {
        var img;

        img = document.createElementNS(svgNameSpace, 'image');
        img.setAttribute('xlink:href', source);
        img.setAttribute('x', x);
        img.setAttribute('y', y);
        img.setAttribute('width', width);
        img.setAttribute('height', height);

        return img;
    }

    // creating and adding the first circle and its elements
    firstCircle = new CreateCircle(270, 130, 50, '#3c3d36');
    svg.appendChild(firstCircle);
    firstCirclePath1 = new CreatePath('M 270 95 Q240 117 270 170', '#5eb04a');
    svg.appendChild(firstCirclePath1);
    secondCirclePath2 = new CreatePath('M 270 95 Q300 117 270 170', '#449444');
    svg.appendChild(secondCirclePath2);

    // creating and adding the second circle
    secondCircle = new CreateCircle(270, 170, 50, '#262625');
    svg.appendChild(secondCircle);

    // creating and adding the third circle and its elements
    thirdCircle = new CreateCircle(270, 225, 50, '#e03436');
    svg.appendChild(thirdCircle);
    thirdCirclePath1 = new CreatePath('M 250 250 L 245 205', 'none');
    thirdCirclePath2 = new CreatePath('M 245 205 L 270 195', 'none');
    thirdCirclePath1.setAttribute('stroke', '#b3b3b3');
    thirdCirclePath2.setAttribute('stroke', '#b3b3b3');
    thirdCirclePath1.setAttribute('stroke-width', '2');
    thirdCirclePath2.setAttribute('stroke-width', '2');
    svg.appendChild(thirdCirclePath1);
    svg.appendChild(thirdCirclePath2);
    thirdCirclePath3 = new CreatePath('M 270 195 L 295 205', '#b53131');
    thirdCirclePath4 = new CreatePath('M 295 205 L 290 250', 'none');
    thirdCirclePath3.setAttribute('stroke', '#b3b3b3');
    thirdCirclePath4.setAttribute('stroke', '#b3b3b3');
    thirdCirclePath3.setAttribute('stroke-width', '2');
    thirdCirclePath4.setAttribute('stroke-width', '2');
    svg.appendChild(thirdCirclePath3);
    svg.appendChild(thirdCirclePath4);
    thirdCirclePath5 = new CreatePath('M 270 197 V 250 H 289 L 294 206 L 270 197', '#b53131');
    thirdCirclePath6 = new CreatePath('M 248 250 L 270 197 V 209 L 253 250', '#f0f4f5');
    thirdCirclePath7 = new CreatePath('M 295 250 L 270 197 V 209 L 290 250', '#b3b3b3');
    svg.appendChild(thirdCirclePath5);
    svg.appendChild(thirdCirclePath6);
    svg.appendChild(thirdCirclePath7);

    // creating and adding the forth circle
    forthCircle = new CreateCircle(270, 272, 50, '#8fc750');
    svg.appendChild(forthCircle);

    // creating and adding the image for Node's logo
    image = new CreateImage('imgs/node_logo.png', 233, 240, 80, 60); // for some reason it does not display the image for the Node logo even though it is added to the svg
    svg.appendChild(image);

    // creating and adding the 'express' text
    express = new CreateText(228, 175, '#fafafa');
    express.textContent = 'express';
    express.setAttribute('id', 'express');
    svg.appendChild(express);

    // creating and adding the MEAN text
    letterM = new CreateText(170, 135, '#3c3d36');
    letterM.setAttribute('class', 'letters');
    letterM.textContent = 'M';
    svg.appendChild(letterM);
    letterE = new CreateText(170, 180, '#262625');
    letterE.setAttribute('class', 'letters');
    letterE.textContent = 'E';
    svg.appendChild(letterE);
    letterA = new CreateText(170, 230, '#e03436');
    letterA.setAttribute('class', 'letters');
    letterA.textContent = 'A';
    svg.appendChild(letterA);
    letterN = new CreateText(170, 280, '#8fc750');
    letterN.setAttribute('class', 'letters');
    letterN.textContent = 'N';
    svg.appendChild(letterN);
};