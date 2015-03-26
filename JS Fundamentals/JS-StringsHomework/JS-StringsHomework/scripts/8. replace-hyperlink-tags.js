console.log('8. Write a JavaScript function that replaces in a HTML document given as string all the tags <a href="…">…</a> with corresponding tags [URL=…]…/URL].');
console.log('');

function replaceAllHyperlinkTags() {
    'use strict';

    var html, newOpeningTag, newClosingTag, pos, startIndex, endIndex, substring, result;

    html = '<p>Please visit <a href="http://academy.telerik. com">our site</a> to choose a training course. Also visit <a href="www.devbg.org">our forum</a> to discuss the courses.</p>';
    newOpeningTag = '[URL=';
    newClosingTag = '[/URL]';
    startIndex = 0;
    pos = html.indexOf('<a');
    result = '';

    // I am not sure if this is the most efficient way, but at least I make sure that all the text is parsed and that the server is not insinde quotation marks

    while (pos !== -1) {
        substring = html.substring(startIndex, pos);
        result += substring;
        result += newOpeningTag;
        startIndex = html.indexOf('"', pos);
        endIndex = html.indexOf('"', startIndex + 1);
        substring = html.substring(startIndex + 1, endIndex);
        result += substring;
        result += ']';
        startIndex = endIndex + 2;
        endIndex = html.indexOf('</a>', startIndex);
        substring = html.substring(startIndex, endIndex);
        result += substring;
        result += newClosingTag;

        startIndex = endIndex + 4;
        pos = html.indexOf('<a', pos + 1);

        if (pos === -1) {
            substring = html.substring(startIndex);
            result += substring;
        }
    }

    console.log('Original html: ' + html + '.');
    console.log('Editted html: ' + result + '.');
}