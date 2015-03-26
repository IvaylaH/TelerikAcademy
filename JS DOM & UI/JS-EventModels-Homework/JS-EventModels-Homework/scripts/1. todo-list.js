/*globals window, document, console*/

window.onload = function () {
    'use strict';

    var container = document.getElementById('container'),
        textInput,
        addBtn,
        deleteBtn,
        showBtn,
        hideBtn,
        fragmentList = document.createDocumentFragment(),
        inputList = document.createElement('ul');

    // basic styles for the container 
    container.style.width = 300 + 'px';
    container.style.height = 450 + 'px';
    container.style.border = '1px solid #000';
    container.style.borderRadius = 10 + 'px';
    container.style.margin = '20px';

    inputList.style.margin = '10px 60px';
    inputList.style.listStyle = 'none';

    // creating the input element
    textInput = document.createElement('input'); // there's no need to specificly set the type of the input element to 'text' since 'text' is the default input type
    textInput.placeholder = 'Here you can enter the new item...';
    textInput.style.width = 210 + 'px';
    textInput.style.margin = '5px 35px';
    fragmentList.appendChild(textInput);
    fragmentList.appendChild(document.createElement('br'));

    // creating the buttons

    // add button
    addBtn = document.createElement('button');
    addBtn.id = 'btn-add';
    addBtn.innerText = 'Add';
    addBtn.style.margin = '0 15px 0 88px';

    // adding new element to the list 
    addBtn.addEventListener("click", addLiElement);

    fragmentList.appendChild(addBtn);

    // delete button
    deleteBtn = document.createElement('button');
    deleteBtn.id = 'btn-delete';
    deleteBtn.innerText = 'Delete';

    // deleting the selected element
    deleteBtn.addEventListener("click", deleteLiElement);

    fragmentList.appendChild(deleteBtn);
    fragmentList.appendChild(document.createElement('br'));

    // show button
    showBtn = document.createElement('button');
    showBtn.id = 'btn-show';
    showBtn.innerText = 'Show All';
    showBtn.style.margin = '0 15px 0 60px';
    showBtn.addEventListener("click", showLiElement);
    fragmentList.appendChild(showBtn);

    // hide button
    hideBtn = document.createElement('button');
    hideBtn.id = 'btn-hide';
    hideBtn.innerHTML = 'Hide item';
    hideBtn.addEventListener("click", hideLiElement);
    fragmentList.appendChild(hideBtn);
    fragmentList.appendChild(document.createElement('br'));

    // selects a 'li' element from the 'ul' list
    inputList.addEventListener("click", selectLiElement);

    function addLiElement() {
        var newLi = document.createElement('li');
        newLi.innerText = textInput.value;
        newLi.style.padding = '0 25px';
        inputList.appendChild(newLi);
    }

    function selectLiElement(ev) {
        var selectedLi = ev.target;

        if (ev.preventDefault()) {
            ev.preventDefault();
        }

        selectedLi.classList.add('.selected');
        selectedLi.style.backgroundColor = 'cornflowerblue';
        selectedLi.style.color = '#fff';
    }

    function deleteLiElement() {
        var selectedLi = document.getElementsByClassName('.selected')[0];
        selectedLi.parentNode.removeChild(selectedLi);
    }

    function hideLiElement() {
        var selectedLi = document.getElementsByClassName('.selected')[0];
        selectedLi.classList.add('.hidden');
        selectedLi.classList.remove('.selected');
        selectedLi.style.display = 'none';
    }

    function showLiElement() {
        var hiddentElements = document.getElementsByClassName('.hidden'),
            i,
            len;

        for (i = 0, len = hiddentElements.length; i < len; i += 1) {
            hiddentElements[0].style.display = '';
            hiddentElements[0].classList.remove('.hidden');
        }
    }

    fragmentList.appendChild(inputList);
    container.appendChild(fragmentList);
};