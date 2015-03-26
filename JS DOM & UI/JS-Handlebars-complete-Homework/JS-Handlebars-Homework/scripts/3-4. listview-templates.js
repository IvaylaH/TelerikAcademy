/// <reference path="C:\Users\ivayla\Desktop\JS-Handlebars-Homework\JS-Handlebars-Homework\libs/jquery-2.1.1.min.js" />
/// <reference path="C:\Users\ivayla\Desktop\JS-Handlebars-Homework\JS-Handlebars-Homework\libs/handlebars.js" />

/*globals document, window, console*/

window.onload = function () {
    'use strict';

    var books = {
        books: [{
            id: 1,
            title: 'JavaScript: The Good parts'
        }, {
            id: 2,
            title: 'Secrets of the JavaScript Ninka'
        }, {
            id: 3,
            title: 'Core HTML5 Canvas'
        }, {
            id: 4,
            title: 'JavaScript Patterns'
        }]
    };

    var students = {
        students: [{
            number: 1,
            name: 'Petar Petrov',
            mark: 5.5
        }, {
            number: 2,
            name: 'Stamat Georgiev',
            mark: 4.7
        }, {
            number: 3,
            name: 'Maria Todorova',
            mark: 6
        }, {
            number: 4,
            name: 'Georgi Geshov',
            mark: 3.7
        }]
    };

    $.fn.listView = function (collection) {
        var $this = $(this);

        var templateId = $this.data('template');
        var templateContent;

        if (templateId) {
            templateContent = $('#' + templateId).html();
        } else {
            templateContent = $('#students-table-template').html();
        }

        var currentTemplate = Handlebars.compile(templateContent);
        var generatedHtml = currentTemplate(collection);
        console.log(generatedHtml);

        $this.append(generatedHtml);

        return $this;
    }

    // problem 3
    $('#books-list').listView(books);
    $('#students-table').listView(students);
    // problem 4
    $('#students-table-dinamically-generated').listView(students);
}