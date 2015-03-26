/*globals window, document, console, $*/

window.onload = function () {
    'use strict';

    var $container = $('#container'),
        indexOfCurrentSlide = 1,
        maxNumberOfSlides = 5,
        slideChanger;

    $container.css({
        border: '1px solid #000',
        margin: '20px 200px',
        width: '900px',
        height: '500px'
    })

    $('<button />')
        .addClass('btn-prev')
        .html('Previous')
        .css('margin-left', '400px')
        .on('click', loadPreviousSlide)
        .appendTo($container);

    $('<button />')
        .addClass('btn-next')
        .html('Next')
        .on('click', loadNextSlide)
        .appendTo($container);

   // changeSlidesAutomatically();
    slideChanger = setInterval(changeSlidesAutomatically, 5000);

    // automatically changing the slides
    function changeSlidesAutomatically() {
        if (indexOfCurrentSlide > maxNumberOfSlides) {
            indexOfCurrentSlide %= maxNumberOfSlides;
        }

        removeCurrentClass();

        switch (indexOfCurrentSlide) {
        case 1:
            createFirstSlide();
            break;
        case 2:
            createSecondSlide();
            break;
        case 3:
            createThirdSlide();
            break;
        case 4:
            createForthSlide();
            break;
        case 5:
            createFifthSlide();
            break;
        default:
            break;
        }

        setCurrentClass();
        indexOfCurrentSlide += 1;
     //   resetTimer();
    }

    function setCurrentClass() {
        var currentSlide = document.getElementsByClassName('innerDiv')[indexOfCurrentSlide - 1],
            $slide = $(currentSlide);

        $slide.addClass('current')
            .css({
                display: '',
                border: '1px solid #000',
                width: '700px',
                height: '400px',
                'text-align': 'center',
                margin: '10px 100px',
                'padding-top': '10px'
            });
    }

    function removeCurrentClass() {
        $('.innerDiv.current').removeClass('current')
            .css('display', 'none');
    }

    // function for button events -> the functions for the buttons are working properly, but for some reason I clearInterval does not stop the time and you have to wait for 5 seconds before the result from the button event function would display
    function loadPreviousSlide() {
        indexOfCurrentSlide -= 2;

        if (indexOfCurrentSlide <= 0) {
            indexOfCurrentSlide = maxNumberOfSlides;
        }

        resetTimer();
    }

    function loadNextSlide() {
        resetTimer();
    }

    function resetTimer() {
        clearInterval(slideChanger);
        slideChanger = setInterval(changeSlidesAutomatically, 5000);
    }

    // functions for creating the separate slides of our slider
    function createFirstSlide() {
        var $slide = $('<div><img src="imgs/Purple-Flowers3.jpg" width="500" height="350" /></div>');
        $slide.addClass('innerDiv')
            .css('display', 'none')
            .appendTo($container);
    }

    function createSecondSlide() {
        var $slide = $('<div><div>Inner div #1</div><div>Inner div #2</div><div>Inner div #3</div></div>');
        $slide.addClass('innerDiv')
            .css('display', 'none')
            .appendTo($container);
    }

    function createThirdSlide() {
        var tableContent = generateTable(),
            $form = $('<div><form action="#" name="results-form">' + tableContent + '</form></div>');
        $form.addClass('innerDiv')
            .css('display', 'none')
            .appendTo($container);
    }

    function createForthSlide() {
        var $slide = $('<div><a href="#">Link # 1</a><br/><a href="#">Link # 2</a><br/><a href="#">Link # 3</a></div>');
        $slide.addClass('innerDiv')
            .css('display', 'none')
            .appendTo($container);
    }

    function createFifthSlide() {
        var $slide = $('<div><img src="imgs/nosy-koala-bear.jpg" width="400" height="350" /><p>I am a nosy koala bear :P</p></div>');
        $slide.addClass('innerDiv')
            .css('display', 'none')
            .appendTo($container);
    }

    // creating the table for the third slide and filling its content
    function createHeaderCells(headerCellsContent) {
        var currentCell = '<thead>',
            currentCellContent,
            i,
            len;

        for (i = 0, len = headerCellsContent.length; i < len; i += 1) {
            currentCellContent = headerCellsContent[i];
            currentCell += '<th>' + currentCellContent + '</th>';
        }

        currentCell += '</thead>';

        return currentCell;
    }

    function createBodyCells(bodyCellsContent) {
        var currentCell = '<tbody>',
            currentCellContent,
            numberOfCellsPerRow = 3,
            i,
            j,
            len;

        for (i = 0, len = bodyCellsContent.length; i < len; i += 3) {
            currentCell += '<tr>';
            for (j = 0; j < numberOfCellsPerRow; j += 1) {
                currentCellContent = bodyCellsContent[i + j];
                currentCell += '<td>' + currentCellContent + '</td>';
            }
            currentCell += '</tr>';
        }

        currentCell += '</tbody>';

        return currentCell;
    }

    function generateTable() {
        var tableRows = '<table>',
            headerCellsContent = ['First name', 'Last name', 'Exam result'],
            bodyCellsContent = ['Ivan', 'Petrov', '89 points', 'Penka', 'Ivanova', '100 points', 'Petar', 'Stamatov', '28 points'],
            headerCells = createHeaderCells(headerCellsContent),
            bodyCells = createBodyCells(bodyCellsContent);

        tableRows += headerCells;
        tableRows += bodyCells;
        tableRows += '</table>';

        return tableRows;
    }
};