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
           studentWithHighestScore = _.chain(students)
               .map(function (student) {
                   var overallScore = 0;
                   _.each(student._marks, function (mark) {
                       overallScore += mark.mark;
                   });

                   return {
                       name: student.fullName(),
                       score: (overallScore / student._marks.length).toFixed(2)
                   }
               })
               .sortBy('score')
                //.each(function (student) {
                //    console.log('name: ' + student.studentName + ' score: ' + student.score);
                //})
               .last().value();

        console.log(studentWithHighestScore);

        // visualization in the DOM tree
        domRepresentation(studentWithHighestScore);

    });
}());
