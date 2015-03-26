/*globals window, document, console, $*/

window.onload = function () {
    'use strict';

    var $container = $('#container'),
        $button,
        studentsArr;

    $button = $('<button />')
        .addClass('btn-generate-table')
        .html('Generate table')
        .css('margin-bottom', '5px')
        .on('click', generateTable)
        .appendTo($container);

    studentsArr = [{
        firstName: 'Petar',
        secondName: 'Ivanov',
        grade: '3'
    }, {
        firstName: 'Milena',
        secondName: 'Grigorova',
        grade: '6'
    }, {
        firstName: 'Gergana',
        secondName: 'Borisova',
        grade: '12'
    }, {
        firstName: 'Boyko',
        secondName: 'Petrov',
        grade: '7'
    }];

    function generateTable() {
        var $table = $('<table />').appendTo($container).css('border-collapse', 'collapse'),
            $thead = $('<thead />').appendTo($table),
            $tbody,
            $tr,
            $bodyTr,
            $th,
            $td;

        $tr = $('<tr />').appendTo($thead);
        $th = $('<th />')
            .html('First name')
            .css('border', '1px solid #000')
            .appendTo($tr);
        $th = $('<th />')
            .html('Last name')
            .css('border', '1px solid #000')
            .appendTo($tr);
        $th = $('<th />')
            .html('Grade')
            .css('border', '1px solid #000')
            .appendTo($tr);

        $tbody = $('<tbody />').appendTo($table);
        for (var i in studentsArr) {
            $bodyTr = $('<tr />').appendTo($tbody);
            $bodyTr.append($('<td />').html(studentsArr[i].firstName).css('border', '1px solid #000'));
            $bodyTr.append($('<td />').html(studentsArr[i].secondName).css('border', '1px solid #000'));
            $bodyTr.append($('<td />').html(studentsArr[i].grade).css('border', '1px solid #000'));
        }
    }
};