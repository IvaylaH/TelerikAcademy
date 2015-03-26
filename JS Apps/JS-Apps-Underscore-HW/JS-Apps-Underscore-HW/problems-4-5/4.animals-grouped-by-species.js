/// <reference path="c:\users\ivayla\documents\visual studio 2013\Projects\JS-Apps-Underscore-HW\JS-Apps-Underscore-HW\libs/require.js" /
/// >
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
            collection = _.chain(animals)
                .groupBy('_species')
                .sortBy(function (group) {
                    return group[0]._numberOfLegs;
                })
                .each(function (animal) {
                    console.log(animal.toString());
                }).value();

        // visualization in the DOM tree
        domRepresentation(collection);
    });
}());
