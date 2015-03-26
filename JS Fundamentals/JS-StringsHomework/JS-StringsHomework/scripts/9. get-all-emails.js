console.log('9. Write a function for extracting all email addresses from given text. All substrings that match the format <identifier>@<host>…<domain> should be recognized as emails. Return the emails as array of strings.');
console.log('');

function extractEmails() {
    'use strict';

    var text, pos, startIndex, emailArr, identifier, host, domain, email, endIndex;

    text = 'Here we have some text with emails - email@mail.bg. Extract those emails - dragan.petkov@yahoo.de, ivanch0@abv.bg; and print then on the console - sir_smurf@gmail.com, blUe_fan@gbg.bg. Good luck!';
    // text = 'some_name@abv.bg. ';
    emailArr = [];
    pos = text.indexOf('@');

    while (pos != -1) {
        startIndex = text.lastIndexOf(' ', pos);
        identifier = text.substring(startIndex + 1, pos).trim();
        startIndex = pos;
        endIndex = text.indexOf('.', pos);
        host = text.substring(startIndex, endIndex).trim();
        startIndex = endIndex;
        endIndex = text.indexOf(' ', pos);
        domain = text.substring(startIndex, endIndex).trim();
        domain = domain.slice(0, domain.length - 1);

        email = identifier + host + domain;
        emailArr.push(email);

        pos = text.indexOf('@', pos + 1);
    }

    console.log('Original text: ' + text + '.');
    console.log('List of the extracted emails: ' + emailArr.join('; '));
}