/// <reference path="c:\users\ivayla\documents\visual studio 2013\Projects\JS-Apps-Underscore-HW\JS-Apps-Underscore-HW\libs/underscore.js" />


(function () {
    'use strict';

    require.config({
        paths: {
            "underscore": "../libs/underscore",
            "animal": "animal-class",
            "animalsArray": "generate-array-of-animals",
            "domRepresentation": "../problems-4-5/adding-results-to-the-dom" //?!?
        }
    });

    require(['underscore', 'animalsArray', 'domRepresentation'], function (_, animalsArr, domRepresentation) {
        var animals = animalsArr.animals,
            totalNumberOfLegs = _.chain(animals)
                .each(function (animal) {
                console.log(animal.toString());
                })
                .reduce(function (memo, animal) { return memo + animal._numberOfLegs }, 0).value();

        console.log('The total number of legs of the animals in our array is: ' + totalNumberOfLegs);
            
        domRepresentation(totalNumberOfLegs);
    });
}());