jsConsole.writeLine('4. Write a script that finds the lexicographically smallest and largest property in document, window and navigator objects');
jsConsole.writeLine('');
/*jslint browser: true*/

function findSmallestBiggestProp(obj) {
    'use strict';

    var objArr = [];
    for (var property in obj) {
        objArr.push(property);
    }

    objArr.sort();

    jsConsole.writeLine('The lexicographically smallest property in ' + obj + ' is: <br />' + obj + '[' + objArr[0] + ']');
    jsConsole.writeLine('The lexicographically biggest property in ' + obj + ' is: <br />' + obj + '[' + objArr[objArr.length - 1] + ']');
    jsConsole.writeLine('');
}

function printDocSmallestBiggestProps() {
    'use strict';

    findSmallestBiggestProp(document);
}

function printWindowSmallestBiggestProps() {
    'use strict';

    findSmallestBiggestProp(window);
}

function printNavSmallestBiggestProps() {
    'use strict';

    findSmallestBiggestProp(navigator);
}