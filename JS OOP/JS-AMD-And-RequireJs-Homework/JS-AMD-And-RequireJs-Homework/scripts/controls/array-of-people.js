/*globals window, document, console*/

define(function () {
    console.log('inside array-of-people.js');

    var people = [{
        id: 1,
        name: 'Vasil Georgiev',
        age: 34,
        avatarUrl: '../../images/vasko-pic.jpg'
    }, {
        id: 2,
        name: 'Peter Petrov',
        age: 18,
        avatarUrl: '../../images/pesho-pic.jpg'
    }, {
        id: 3,
        name: 'Ivan Ivanov',
        age: 24,
        avatarUrl: '../../images/vankata-pic.jpg'
    }, {
        id: 4,
        name: 'Nikola Petkov',
        age: 20,
        avatarUrl: '../../images/nikola-pic.jpg'
    }];

    return {
        people: people
    };
});