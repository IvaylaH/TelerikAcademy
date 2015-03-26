console.log('3. Write a function that makes a deep copy of an object. The function should work for both primitive and reference types.');
console.log('');

// I am not absolutely sure that this is a deep copy
function makeDeepCopy() {
    'use strict';

    var personObj, numbersArr, copiedObj, copiedArr;

    personObj = {
        firstName: 'Ivan',
        lastName: 'Ivanov',
        age: 21,
        occupation: 'student'
    };

    numbersArr = [3, 15, 6, 8, 11, 21];

    copiedObj = clone(personObj);
    copiedArr = clone(numbersArr);

    console.log('Original object -> firstName: ' + personObj.firstName + '; lastName: ' + personObj.lastName + '; age: ' + personObj.age + '; occupation: ' + personObj.occupation + '.');
    console.log('Copied object -> firstName: ' + copiedObj.firstName + '; lastName: ' + copiedObj.lastName + '; age: ' + copiedObj.age + '; occupation: ' + copiedObj.occupation + '.');
    console.log('');
    console.log('Original array: ' + numbersArr + '.');
    console.log('Copied array: ' + copiedArr.join(' ') + '.');
}

function clone(obj) {
    'use strict';

    if (obj === null || typeof obj !== 'Object') {
        return obj;
    }

    var copy, i, len;

    if (Array.isArray(obj)) {
        copy = [];
        for (i = 0, len = obj.length; i < len; i += 1) {
            copy[i] = clone(obj[i]);
        }

        return copy;
    } else {

        copy = {};

        for (var prop in obj) {
            if (obj.hasOwnProperty(prop)) {
                copy[prop] = clone(obj[prop]);
            }   
        }

        return copy;
    }
}