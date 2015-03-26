/// <reference path="c:\users\ivayla\documents\visual studio 2013\Projects\JS-Apps-Underscore-HW\JS-Apps-Underscore-HW\libs/require.js" />

define(['animal'], function (animal) {
    'use strict';

    var animals = [],
    i,
    numberOfAnimals = 10,
    currentAnimal,
    animalName,
    animalSpecies,
    animalNumberOfLegs,
    nameIndex,
    speciesIndex,
    currentSpecies,
    names = ['Vaska', 'Pesho', 'Valeri', 'Anitsa', 'Strahil', 'Pena', 'Vancho'],
    species = {
        donkey: 4,
        monkey : 2,
        snake: 0,
        turtle: 4, 
        parrot: 2,
        rabbit: 4,
        eagle: 2 }


    for (i = 0; i < numberOfAnimals; i += 1) {
        nameIndex = generateNameIndex();
        animalName = names[nameIndex];

        speciesIndex = generateNameIndex();
        currentSpecies = Object.keys(species);
        animalSpecies = currentSpecies[speciesIndex];
        animalNumberOfLegs = species[animalSpecies];

        currentAnimal = new animal(animalName, animalSpecies, animalNumberOfLegs);

        animals.push(currentAnimal);
    }

    function generateNameIndex() {
        var number = Math.floor(Math.random() * 6);

        return number;
    }

    return {
        animals: animals
    }
});