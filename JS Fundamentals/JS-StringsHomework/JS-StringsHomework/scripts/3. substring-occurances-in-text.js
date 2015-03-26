console.log('3. Write a JavaScript function that finds how many times a substring is contained in a given text (perform case insensitive search).');
console.log('');

function countOccurancesOfSubstringIntext() {
    'use strict';

    var text, countOccurances, searchedSubstr, pos;

    text = 'We are living in an yellow submarine. We don\'t have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.';
    countOccurances = 0;
    searchedSubstr = 'in';
    pos = 1;

    while (pos !== -1) {
        countOccurances += 1;
        pos = text.indexOf(searchedSubstr, pos + 1);
    }

    console.log('The substring \'' + searchedSubstr + '\' can be found ' + countOccurances + ' times inside the text.');
}