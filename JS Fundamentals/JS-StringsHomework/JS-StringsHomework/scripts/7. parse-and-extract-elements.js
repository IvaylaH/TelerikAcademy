console.log('7. Write a script that parses an URL address given in the format and extracts from it the [protocol], [server] and [resource] elements. Return the elements in a JSON object.');
console.log('');

function parseUrlAndExtractElements() {
    'use strict';

    var url, jsonObj, pos, startIndex, protocol, server, resource, substring;

    url = 'http://www.devbg.org/forum/index.php';
    pos = url.indexOf('/');
    startIndex = 0;
    substring = '';

    while (pos !== -1) {
        if (url[pos - 1] === ':' && url[pos + 1] === '/') {
            protocol = url.substring(startIndex, pos - 1).trim();
            startIndex = pos + 2;
        } else if (url[pos - 1] !== '/') {
            substring = url.substring(startIndex, pos);
            server = substring.trim();
            substring = url.substring(pos);
            resource = substring.trim();
            break;
        }

        pos = url.indexOf('/', pos + 1);
    }

    jsonObj = {
        'Protocol': protocol,
        'Server': server,
        'Resource': resource
    };

    console.log('{Protocol: \'' + jsonObj.Protocol + '\', ');
    console.log('Server: \'' + jsonObj.Server + '\', ');
    console.log('Resource: \'' + jsonObj.Resource + '\'}');
}