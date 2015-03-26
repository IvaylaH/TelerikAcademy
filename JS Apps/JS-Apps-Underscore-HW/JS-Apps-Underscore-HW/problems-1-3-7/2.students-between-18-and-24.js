/// <reference path="c:\users\ivayla\documents\visual studio 2013\Projects\JS-Apps-Underscore-HW\JS-Apps-Underscore-HW\libs/require.js" /
/// >
/// <reference path="c:\users\ivayla\documents\visual studio 2013\Projects\JS-Apps-Underscore-HW\JS-Apps-Underscore-HW\libs/underscore.js" />
/*globals window, document, console, require*/

(function () {
    'use strict';

    require.config({
        paths: {
            'underscore': '../libs/underscore',
            'student': 'student-class',
            'studentsArray': 'generate-array-of-students',
            'domRepresentation': 'adding-results-to-the-dom'
        }
    });

    require(['underscore', 'studentsArray', 'domRepresentation'], function (_, studentsArr, domRepresentation) {
        var students = studentsArr.students,
            collection = _.chain(students)
                .filter(function (student) {
                    return student._age >= 18 && student._age <= 24;
                })
                .each(function (student) {
                    console.log('First name: ' + student._firstName + '; Last name: ' + student._lastName + '; Age: ' + student._age + '.');
                }).value();

        // visualizing the result in the browser -> adding the elements to the DOM tree
        domRepresentation(collection);
    });

}());