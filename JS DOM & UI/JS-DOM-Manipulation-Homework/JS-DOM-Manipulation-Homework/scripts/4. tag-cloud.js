/*globals window, document, console*/

window.onload = function () {
    'use strict';

    var container = document.getElementById('container'),
        minFontSize = 17,
        maxFontSize = 42,
        maxOccurances = 0,
        tags = ["cms", "javascript", "js", "ASP.NET MVC", ".net", ".net", "css", "wordpress", "xaml", "js", "http", "web", "asp.net", "asp.net MVC", "ASP.NET MVC", "wp", "javascript", "js", "cms", "html", "javascript", "http", "http", "CMS"],
        tagCloud = generateTagCloud(tags, minFontSize, maxFontSize);

        container.style.width = 400 + 'px';
        container.style.height = 270 + 'px';
        container.style.margin = '25px 45px';
        container.style.border = '1px solid #000';
        container.style.borderRadius = '5px';
        container.style.backgroundColor = 'cornflowerblue';
        container.style.color = '#fff';
        container.appendChild(tagCloud);


    function generateTagCloud(tags, minFontSize, maxFontSize) {
        var tagsWithOccurances = countTheOccurancesOfEachTag(tags),
            differenceBetweenMinAndMaxFont = maxFontSize - minFontSize,
            step = Math.floor(differenceBetweenMinAndMaxFont / maxOccurances),
            fragmentList = document.createDocumentFragment(),
            currentTag,
            span,
            i,
            len;

        for (i = 0, len = tagsWithOccurances.length; i < len; i += 1) {
            if (i !== 0 && i % 3 === 0) {

                fragmentList.appendChild(document.createElement('br'));
            }

            currentTag = tagsWithOccurances[i];
            span = document.createElement('span');
            span.innerText = currentTag.name + ' ';
            span.style.fontSize = generateFontSizeNumber(currentTag.occurances, minFontSize, maxFontSize, step) + 'px';

            fragmentList.appendChild(span);
        }

        return fragmentList;
    }

    function generateFontSizeNumber(occurances, minFontSize, maxFontSize, step) {
        var fontSizeNumber,
            min,
            max;

        switch (occurances) {
        case 1:
            max = minFontSize + (occurances * step);
            fontSizeNumber = generateRandomIntInRange(minFontSize, max);
            return fontSizeNumber;
        case 2:
            max = minFontSize + (occurances * step);
            min = max - step;
            fontSizeNumber = generateRandomIntInRange(min, max);
            return fontSizeNumber;
        case 3:
            min = maxFontSize - step;
            fontSizeNumber = generateRandomIntInRange(min, maxFontSize);
            return fontSizeNumber;
        }
    }

    function countTheOccurancesOfEachTag(tags) {
        var currentTag,
            currentTagsOccurances = 0,
            countedSymbol = '*',
            tagWithOccurances = {},
            countedTags = [],
            i,
            j,
            len;

        for (i = 0, len = tags.length; i < len; i += 1) {
            currentTag = tags[i];

            if (currentTag !== countedSymbol) {
                for (j = i, len = tags.length; j < len; j += 1) {
                    if (currentTag.toLowerCase() === tags[j].toLowerCase()) {
                        currentTagsOccurances += 1;

                        if (j !== i) {
                            tags[j] = countedSymbol;
                        }
                    }
                }

                if (maxOccurances < currentTagsOccurances) {
                    maxOccurances = currentTagsOccurances;
                }

                tagWithOccurances = {
                    name: currentTag,
                    occurances: currentTagsOccurances
                };

                countedTags.push(tagWithOccurances);
                currentTagsOccurances = 0;
            }
        }

        return countedTags;
    }

    function generateRandomIntInRange(min, max) {
        var number = Math.floor(Math.random() * (max - min + 1)) + min;

        return number;
    }
};