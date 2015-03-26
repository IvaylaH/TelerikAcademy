console.log('6. Write a function that extracts the content of a html page given as text. The function should return anything that is in a tag, without the tags.');
console.log('');

function extractTextFromHtml() {
    'use strict';

    var html, startIndex, pos, substring, result, openingIndex;

    html = '<html><head><title>Sample site</title></head><body><div>text<div>more text</div>and more...</div>in body</body></html>';
    startIndex = 0;
    pos = html.indexOf('>');
    substring = '';
    result = '';

    while (pos !== -1) {
        if (html[pos + 1] !== '<') {
            startIndex = pos + 1;
            openingIndex = html.indexOf('<', startIndex);
            if (openingIndex !== -1) {
                substring = html.substring(startIndex, openingIndex);
                result += substring.trim();
            }
        }

        pos = html.indexOf('>', pos + 1);
    }

    console.log(html);
    console.log('');
    console.log(result);
}