/// <reference path="c:\users\ivayla\documents\visual studio 2013\Projects\JS-Apps-Underscore-HW\JS-Apps-Underscore-HW\libs/require.js" />

define(['book'], function (book) {
    'use strict';

    var books = [],
        i,
        numberOfBooks = 10,
        title,
        author,
        currentBook,
        index,
        titles = ['Love in the  time of cholera', 'Harry Potter and the Philosopher\'s Stone', 'Harry Potter and the Chaimber of Secrets', 'Harry Potter and the Prizoner of Azkaban', 'Lord of the Rings: The Fellowship of the Ring', 'Lord of the Rings: The Two towers', 'Lord of the Rings: The Return of the King', 'Eragon', 'Inheritance', 'The Big Book of Fairytails'],
        authors = ['J.K.Rowling', 'J.R.R.Tolkin', 'Chirstopher Paolini', 'Brothers Grimm', 'Bay Pesho'];


    for (i = 0; i < numberOfBooks; i += 1) {
        index = generateBookIndex();
        title = titles[index];

        index = generateAuthorsIndex();
        author = authors[index];

        currentBook = new book(title, author);
        books.push(currentBook);
    }

    function generateBookIndex() {
        var number = Math.floor(Math.random() * 10);

        return number;
    }

    function generateAuthorsIndex() {
        var number = Math.floor(Math.random() * 5);

        return number;
    }

    return {
        books: books
    };
});