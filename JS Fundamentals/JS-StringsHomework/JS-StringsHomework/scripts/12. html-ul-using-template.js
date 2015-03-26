console.log('12. Write a function that creates a HTML UL using a template for every HTML LI. The source of the list should an array of elements. Replace all placeholders marked with –{…}–   with the value of the corresponding property of the object.');
console.log('');

// I had some trouble with this problem I looked at the forum for some directions; I found this solution - it's simple and easy to uderstand therefore decided to use it but with some changes 

function createHtmlUlUsingTemplate() {
    'use strict';

    var templ, peopleArr, resultedList;

    templ = '<strong>-{name}-</strong> <span>-{age}-</span>';
    peopleArr = [
        { name: 'Ivanch0', age: 5 },
        { name: 'Simeon', age: 30 },
        { name: 'Maria', age: 3 },
        { name: 'Vasko', age: 25 }
    ];

   // templ = templ.replace(namePlaceholder, peopleArr.name).replace(agePlaceholder, peopleArr.age);

    resultedList = generateList(peopleArr, templ);

    console.log('The final result is: ' + resultedList + '.');
}

function generateList(array, template) {
    'use strict';

    var i, len, result, row, replaced, currentPerson, namePlaceholder, agePlaceholder;

    replaced = [];
    namePlaceholder = '-{name}-';
    agePlaceholder = '-{age}-';

    for (i = 0, len = array.length; i < len; i += 1) {
        currentPerson = array[i];
        row = template;

        for (var property in currentPerson) {
            if (property === 'name') {
                row = row.replace(namePlaceholder, currentPerson.name);
            } else {
                row = row.replace(agePlaceholder, currentPerson.age);
            }
        }

        replaced.push(row);
    }

    result = '<ul><li>';
    result += replaced.join('</li><li>');
    result += '</li></ul>';

    return result;
}