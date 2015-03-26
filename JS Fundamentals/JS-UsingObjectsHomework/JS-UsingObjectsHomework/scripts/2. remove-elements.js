console.log('2. Write a function that removes all elements with a given value');
console.log('');

(function () {
    'use strict';

    var newNumsArr, i, len;

    newNumsArr = [];

    if (!Array.prototype.removeElement) {
        Array.prototype.removeElement = function (element) {
            if (this === null) {
                throw new TypeError();
            }

            for (i = 0, len = this.length; i < len; i += 1) {
                if (this[i] !== element) {
                    newNumsArr.push(this[i]);
                }
            }

            return newNumsArr;
        };
    }
})();

function removeAllElementsWithGivenValue() {
    'use strict';

    var numsArr, valueToRemove, originalArrToStr, returnedArrToStr;

    numsArr = [1, 2, 1, 4, 1, 3, 4, 1, 111, 3, 2, 1, '1'];
    originalArrToStr = numsArr.join(' ');
    valueToRemove = 1;

    numsArr = numsArr.removeElement(valueToRemove);
    returnedArrToStr = numsArr.join(' ');
    printResult(originalArrToStr, returnedArrToStr);
}

function printResult(originalArrStr, newArrStr) {
    'use strict';

    console.log('Original array: ' + originalArrStr + '.');
    console.log('Array after removing the element: ' + newArrStr + '.');
}