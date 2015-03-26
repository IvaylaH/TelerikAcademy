/*globals window, document, console*/
window.onload = function () {
    'use strict';

    var container = document.getElementById('container'),
        heading = document.getElementsByTagName('h1')[0];

    // styles for the div element
    container.style.width = '1000px';
    container.style.height = '180px';
    container.style.margin = '25px 120px';
    container.style.border = '1px solid #000';
    container.style.borderRadius = '5px';
    container.style.backgroundColor = '#1b5f82';

    // styles for the heading paragraph
    heading.style.textAlign = 'center';

    DrawLogoTelerik(container);
    DrawYouTubeLogo();

    function DrawLogoTelerik(container) {
        var paper = Raphael(container, 390, 160),
            rect;

        rect = paper.rect(45, 25, 340, 125);
        rect.attr({
            stroke: '#e0ffa3',
            'stroke-width': 4,
            fill: '#fff',
            'rx': 2,
            'ry': 2
        });

        // drawing the logo of Telerik
        paper.path('M 85 60 L 95 50 L 125 82 L 110 98 L 95 82 L 125 50 L 135 60')
            .attr({
                stroke: '#5ce600',
                'stroke-width': 8
            });

        // adding the text
        paper.text(227, 77, 'Telerik')
            .attr({
                stroke: '#000',
                'stroke-width': 2.5,
                'font-size': 58,
                'font-family': 'Segoe UI'
            });

        paper.text(248, 117, 'Develop experiences')
            .attr({
                stroke: '#000',
                'font-size': 22,
                'font-family': 'Segoe UI light'
            });

        // making the trade mark
        paper.circle(320, 75, 5)
            .attr({
                stroke: '#000'
            });

        paper.text(320, 74.2, 'R')
            .attr({
                stroke: '#000',
                'font-size': 7,
                'font-family': 'Segoe UI'
            });
    }

    function DrawYouTubeLogo() {
        var paper = Raphael(515, 85, 390, 160),
            rect;

        rect = paper.rect(45, 25, 340, 125);
        rect.attr({
            stroke: '#daedf2',
            'stroke-width': 4,
            fill: '#fff',
            'rx': 5,
            'ry': 5
        });

        // adding the 'You'
       /* paper.path('M 60 55 L 70 95 V 125 H 77 V 95 L 87 55 H 80 L 74 90 L 67 55 Z')
            .attr({
                fill: '#4b4b4b'
            });

        paper.image('images/O.png', 85, 76, 27, 57);*/
        paper.text(125, 80, 'You')
            .attr({
                stroke: '#4b4b4b',
                'stroke-width': 5,
                'font-size': 82,
                'font-family': 'Segoe UI light'
            });

        // adding the red rectangular
        paper.rect(195, 40, 180, 95)
            .attr({
                stroke: 'none',
                fill: '#f00',
                r: 20,
                rx: 20,
                ry: 20
            });

        // adding 'Tube'
        paper.text(285, 80, 'Tube')
            .attr({
                stroke: '#fff',
                'stroke-width': 5,
                'font-size': 82,
                'font-family': 'Segoe UI light'
            });
    }
};