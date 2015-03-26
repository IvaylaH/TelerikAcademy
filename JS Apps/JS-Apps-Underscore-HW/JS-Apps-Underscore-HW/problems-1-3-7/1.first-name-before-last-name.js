/// <reference path="c:\users\ivayla\documents\visual studio 2013\Projects\JS-Apps-Underscore-HW\JS-Apps-Underscore-HW\libs/require.js" />
/// <reference path="c:\users\ivayla\documents\visual studio 2013\Projects\JS-Apps-Underscore-HW\JS-Apps-Underscore-HW\libs/underscore.js" />

(function () {
    'use strict';

    require.config({
        paths: {
            "underscore": "../libs/underscore",
            "student": "student-class",
            "studentsArray": "generate-array-of-students",
            "domRepresentation": "adding-results-to-the-dom"
        }
    });

    require(['underscore', 'studentsArray', 'domRepresentation'], function (_, studentsArr, domRepresentation) {
        var students = studentsArr.students,
            sortedSelection = _.chain(students)
                .filter(function (student) {
                    return student._firstName < student._lastName;
                })
                .sortBy(function (student) {
                    return student.fullName();
                })
                .each(function (student) {
                    console.log(student);
                }).value();

        // visualizing the result in the browser -> adding the elements to the DOM tree
        domRepresentation(sortedSelection);
    });
}());