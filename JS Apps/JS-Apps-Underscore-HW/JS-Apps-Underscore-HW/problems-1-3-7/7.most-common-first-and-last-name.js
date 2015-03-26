/// <reference path="c:\users\ivayla\documents\visual studio 2013\Projects\JS-Apps-Underscore-HW\JS-Apps-Underscore-HW\libs/require.js" /
/// >
/// <reference path="c:\users\ivayla\documents\visual studio 2013\Projects\JS-Apps-Underscore-HW\JS-Apps-Underscore-HW\libs/underscore.js" />

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
            mostCommonFirstName,
            mostCommonLastName;

        mostCommonFirstName = _.chain(students)
            .groupBy('_firstName')
            .each(function (group) {
                console.log(group);
            })
            .sortBy(function (group) {
                return -1 * group.length;
            })
            .first().value()[0]._firstName;

        console.log('The most common first name is: ' + mostCommonFirstName);

        mostCommonLastName = _.chain(students)
            .groupBy('_lastName')
            .each(function (group) {
                console.log(group);
            })
            .sortBy(function (group) {
                return -1 * group.length;
            })
            .first().value()[0]._lastName;

        console.log('The most common last name is: ' + mostCommonLastName);
    });
}());