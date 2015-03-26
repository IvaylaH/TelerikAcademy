/// <reference path="c:\users\ivayla\documents\visual studio 2013\Projects\JS-Apps-Underscore-HW\JS-Apps-Underscore-HW\libs/require.js" />

define(function () {

    var Animal = (function () {
        function Animal(name, speciesName, numberOfLegs) {
            this._name = setName(name);
            this._species = setName(speciesName);
            this._numberOfLegs = setNumberOfLegs(numberOfLegs);
        }

        function setName(inputName) {
            if (!inputName instanceof String) {
                throw new Error("The name must be of type string!");
            }

            if (3 > inputName.length && inputName.length > 15) {
                throw new Error("The name must be in the range [3, 15]!");
            }

            return inputName;
        }

        function setNumberOfLegs(inputNumberOfLegs) {
            if (!inputNumberOfLegs instanceof Number) {
                throw new Error("The legs of the animal must be of type number");
            }

            if (inputNumberOfLegs < 0) {
                throw new Error("Cannot set the legs of the animal to a negative number!");
            }

            return inputNumberOfLegs;
        }

        Animal.prototype.toString = function () {
            return 'name: ' + this._name + ' -> species: ' + this._species + ' -> number of legs: ' + this._numberOfLegs;
        }

        Animal.prototype.getName = function () {
            return this._name;
        }

        Animal.prototype.getSpecies = function () {
            return this._species;
        }

        Animal.prototype.getNumberOfLegs = function () {
            return this._numberOfLegs;
        }

        return Animal;
    }());

    return Animal;
});