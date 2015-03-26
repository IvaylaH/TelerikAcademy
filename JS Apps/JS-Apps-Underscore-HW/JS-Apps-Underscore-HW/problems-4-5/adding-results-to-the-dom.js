/*globals window, document, console*/

define(function () {
    'use strict';

    var domElements = function addElememtsToDom(sortedSelection) {
        ulList = document.createElement('ul');
        ulList.classList.add('problem-ul');
        ulList.style.listStyle = 'none';

        if (sortedSelection.length > 1) {
            var i, len, liElement, fragList, ulList;

            liElement = document.createElement('li');
            fragList = document.createDocumentFragment();

            for (i = 0, len = sortedSelection.length; i < len; i += 1) {
                var newLi = liElement.cloneNode(true),
                    currentElement = sortedSelection[i];

                newLi.innerText = sortedSelection[i].toString();
                fragList.appendChild(newLi);
            }

            ulList.appendChild(fragList);
        } else {
            if (sortedSelection.length === 0) {
                var message = document.createElement('h4');
                message.innerText = 'There is no element that fulfills the specific requirements!';
                ulList.appendChild(message);
            } else {
                var paragraph = document.createElement('p');
                paragraph.innerText = 'The total number of legs of the animals is: ' + sortedSelection;
                ulList.appendChild(paragraph);
            }
        }

        document.body.appendChild(ulList);
    }

    return domElements;
});