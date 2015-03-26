console.log('5. Write a function that finds the youngest person in a given array of persons and prints his/hers full name');
console.log('');

function findYoungestInArrayOfPeople() {
    'use strict';

    var peopleArr, i, len, youngest, indexYoungest;

    youngest = Number.MAX_VALUE;
    indexYoungest = 0;
    peopleArr = [
        {
            firstName: 'Ivan',
            lastName: 'Petrov',
            age: 15
        },
        {
            firstName: 'Dragan',
            lastName: 'Ivanov',
            age: 35
        },
        {
            firstName: 'Petar',
            lastName: 'Draganov',
            age: 61
        },
        {
            firstName: 'Maria',
            lastName: 'Petrova',
            age: 8
        },
        {
            firstName: 'Ana',
            lastName: 'Qneva',
            age: 40
        }
    ];

    for (i = 0, len = peopleArr.length; i < len; i += 1) {
        if (youngest > peopleArr[i].age) {
            youngest = peopleArr[i].age;
            indexYoungest = i;
        }
    }

    console.log('The youngest person is: ' + peopleArr[indexYoungest].firstName + ' ' + peopleArr[indexYoungest].lastName + '. He/She is: ' + peopleArr[indexYoungest].age + ' years old.');
}