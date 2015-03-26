/// <reference path="c:\users\ivayla\documents\visual studio 2013\Projects\JS-Apps-Underscore-HW\JS-Apps-Underscore-HW\libs/require.js" />

define(function () {
    var Book = (function () {

        function Book(title, author) {
            this._title = setName.call(this, title);
            this._author = setName.call(this, author);
        }

        function setName(inputName) {
            if (!inputName instanceof String) {
                throw new Error("The name must be of type string!");
            }

            if (5 > inputName.length && inputName.length > 25) {
                throw new Error("The name must be in the range [5, 25]!");
            }

            return inputName;
        }

        Book.prototype.toString = function () {
            return 'title: ' + this._title + ' -> author: ' + this._author;
        }

        Book.prototype.getTitle = function () {
            return this._title;
        }

        Book.prototype.getAuthor = function () {
            return this._author;
        }

        return Book;
    }());

    return Book;
});