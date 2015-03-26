/*globals window, document, console*/

define(function () {
    'use strict';

    var domElements = function addElememtsToDom(sortedSelection) {
	var ulList, paragraph;
        ulList = document.createElement('ul');
        ulList.classList.add('problem-ul');
        ulList.style.listStyle = 'none';

        paragraph = document.createElement('p');
        paragraph.innerText = 'The most famous book author is: ' + sortedSelection;
        ulList.appendChild(paragraph);

        document.body.appendChild(ulList);
    }

    return domElements;
});