/*globals window, document, console, $*/

$('document').ready(function (){

    $.fn.dropdown = function () {
        var $optionsList = $(this),
            arrOfOptions = [],
            options = $optionsList.children(),
            currentOption,
            len,
            i;

        $optionsList.hide();

        for (i = 0, len = options.length; i < len; i += 1) {
            currentOption = options[i];
            arrOfOptions.push({
                option: options[i].innerHTML,
                dataValue: options[i].value
            })
        }

        var $container = $('<div />').addClass('dropdown-list-container');
        var $ul = $('<ul />').addClass('dropdown-list-options');
        var $mainLiOption = $('<li />')
                .addClass('main-dropdown-list-option')
                .text('Choose your favorite band')
                .attr('data-value', 'not-selected')
                .appendTo($ul);

        for (var j = 0, len2 = arrOfOptions.length; j < len2; j += 1) {
            var currentLi = $('<li />')
                .text(arrOfOptions[j].option)
                .attr('value', arrOfOptions[j].dataValue)
                .on('click', function () {
                    var $target = $(this),
                        data = $target.val(),
                        selector = 'option[value="' + data + '"]';
                    
                    $('.dropdown-list-options li[selected]').removeAttr('selected');
                    $target.attr('selected', 'selected');
                    $mainLiOption.text($target.text());
                    $('.dropdown-list-options li:not(.main-dropdown-list-option)').slideUp('fast');

                    if ($optionsList.find(selector).attr('selected') == 'selected') {
                        $optionsList.find(selector).removeAttr('selected', '');
                    } else{
                        $optionsList.find(selector).attr('selected', 'selected');
                    }
                })
                .appendTo($ul);
        }

        $allLiElements = $mainLiOption.siblings().hide();

        $mainLiOption.on('click', function () {
            $allLiElements.slideToggle();
        });
        $ul.appendTo($container);
        $container.appendTo($('body'));
    };

    $('#dropdown').dropdown();
});