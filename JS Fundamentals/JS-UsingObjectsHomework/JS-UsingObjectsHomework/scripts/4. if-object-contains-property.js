console.log('4. Write a function that checks if a given object contains a given property');
console.log('');

function hasProperty(obj, prop) {
    'use strict';

    for (var property in obj) {
        if (property === prop) {
            return true;
        }
    }

    return false;
}

function checkIfObjectContainsProperty() {
    'use strict';

    var person = {
        firstName: 'Dragan',
        lastName: 'Ivanov',
        occupation: 'student',
        uni: 'SU',
        specialty: 'Computer Graphics',
        age: 25
    };

    var hasProp = hasProperty(person, 'age');

    console.log('The object contains this property: ' + hasProp + '.');
}