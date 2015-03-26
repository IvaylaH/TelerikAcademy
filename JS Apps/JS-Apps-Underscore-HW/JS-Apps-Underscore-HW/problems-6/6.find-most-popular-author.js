/// <reference path="c:\users\ivayla\documents\visual studio 2013\Projects\JS-Apps-Underscore-HW\JS-Apps-Underscore-HW\libs/require.js" /
/// >
/// <reference path="c:\users\ivayla\documents\visual studio 2013\Projects\JS-Apps-Underscore-HW\JS-Apps-Underscore-HW\libs/underscore.js" />

(function () {
    'use strict';

    require.config({
        paths: {
            "underscore": "../libs/underscore",
            "book": "book-class",
            "booksArray": "generate-array-of-books",
            "domRepresentation": "adding-results-to-the-dom" //?!?
        }
    });

    require(['underscore', 'booksArray', 'domRepresentation'], function (_, booksArr, domRepresentation) {
        var books = booksArr.books,
            mostFamousAuthor = _.chain(books)
                .groupBy('_author')
                .sortBy(function (group) {
                    return -1 * group.length;
                })
                .each(function (book) {
                    console.log(book.toString());
                })
                .first().value()[0]._author;

        console.log('The most famous author amongst in the current array is: ' + mostFamousAuthor);

        domRepresentation(mostFamousAuthor);
    });
}());
