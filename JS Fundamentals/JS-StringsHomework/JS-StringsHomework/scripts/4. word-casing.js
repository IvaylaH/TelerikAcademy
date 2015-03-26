console.log('4. You are given a text. Write a function that changes the text in all regions: <upcase>text</upcase> to uppercase. <lowcase>text</lowcase> to lowercase <mixcase>text</mixcase> to mix casing(random)');
console.log('');

function changeWordCasing() {
    'use strict';

    var text, casingArr, tempArr, pos, startIndex, casing, index, textSubstring, returnedSubstr, poppedStr;

    //text = 'We are <mixcase>living</mixcase> in a <upcase>yellow submarine</upcase>. We <mixcase>don\'t</mixcase> have <lowcase>anything</lowcase> else.';
    text = 'We have some text <upcase> followed by even more <mixcase>text and</mixcase> now <lowcase>YOU HAVE TO</lowcase> change its casing.</upcase>';
    startIndex = 0;
    casingArr = [];
    tempArr = [];
    index = 0;

    pos = text.indexOf('<');
    while (pos !== -1) {

        if (text[pos + 1] === '/') {
            poppedStr = casingArr.pop();

            if (poppedStr[0] === '<') {
                textSubstring = text.substring(startIndex, pos);
                index = text.indexOf('>', pos);
                casing = text.substring(pos, index + 1).trim();
                returnedSubstr = changeCasing(casing, textSubstring).trim();
                casingArr.push(returnedSubstr);
            } else {
                textSubstring = '';

                while (poppedStr[0] !== '<') {
                    tempArr.push(poppedStr);
                    poppedStr = casingArr.pop();
                }

                while (tempArr.length !== 0) {
                    textSubstring += tempArr.pop();
                    textSubstring += ' ';
                }

                textSubstring += text.substring(startIndex, pos);
                index = text.indexOf('>', pos);
                casing = text.substring(pos, index + 1).trim();
                returnedSubstr = changeCasing(casing, textSubstring).trim();
                casingArr.push(returnedSubstr);
            }

            startIndex = index + 1;
        } else if (text[pos + 1] !== '/') {
            textSubstring = text.substring(startIndex, pos);
            casingArr.push(textSubstring.trim());
            index = text.indexOf('>', pos);
            casing = text.substring(pos, index + 1);
            casingArr.push(casing);
            startIndex = index + 1;
        }

        pos = text.indexOf('<', pos + 1);
    }

    console.log(casingArr.join(' '));
}

function changeCasing(currentCasing, substring) {
    'use strict';

    var i, len, returnSubstr;

    returnSubstr = '';

    switch (currentCasing) {
    case '</upcase>':
        return substring.toUpperCase();
    case '</lowcase>':
        return substring.toLowerCase();
    case '</mixcase>':
        for (i = 0, len = substring.length; i < len; i += 1) {
            if (i % 2 === 0) {
                returnSubstr += substring[i].toUpperCase();
            } else {
                returnSubstr += substring[i];
            }
        }

        return returnSubstr;
    }
}

