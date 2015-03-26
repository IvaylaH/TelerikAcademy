/// <reference path="c:\users\ivayla\documents\visual studio 2013\Projects\JS-AMD-And-RequireJs-Homework\JS-AMD-And-RequireJs-Homework\libs/jquery-2.1.1.js" />
/// <reference path="c:\users\ivayla\documents\visual studio 2013\Projects\JS-AMD-And-RequireJs-Homework\JS-AMD-And-RequireJs-Homework\libs/require.js" />
/*globals window, document, console*/

require.config({
    paths: {
        jQuery: '../libs/jquery-2.1.1',
        handlebars: '../libs/handlebars',
        controls: 'controls/comboBox',
        arrOfPeople: 'controls/array-of-people'
    }
});

require(['jQuery', 'controls', 'arrOfPeople'], function (_jQ, controls, arrOfPeople) {
    $(function () {
        var comboBox, templateContent, comboBoxHtml, people, $parent;

        people = arrOfPeople.people;
        templateContent = $('#people-template').html();
        comboBox = controls.ComboBox(people);
        comboBoxHtml = comboBox.render(templateContent);
        $parent = $('#container');
        $parent.html(comboBoxHtml);
    });
});