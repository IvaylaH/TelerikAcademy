var integerLit = 25;
var floatingPointLit = 30.56;
var boolLitTrue = true;
var boolLitFalse = false;
var stringLit = 'This is a string literal';

/*I have read the article on JS variables published in MDN and there it was mentioned that you can have an extra comma which would indicate that there is an element that is currently not defined (undefined); I decided to try it out but JSLint sees it as a mistake*/
var arrayLit = ['this', 'array',, 'has',, 7, 'literals'];
var objectLit = { name: 'Smurky', breed: 'Beagle', age: 3 };

jsConsole.writeLine('--> 1. Assign all the possible JavaScript literals to different variables.');
jsConsole.writeLine('');
jsConsole.writeLine(integerLit);
jsConsole.writeLine(floatingPointLit);
jsConsole.writeLine('Here we have an integer: ' + integerLit + ' and a floating-point number: ' + floatingPointLit);
jsConsole.writeLine('floating-point number: ' + floatingPointLit + '; integer part of that same number: ' + (floatingPointLit | 0));
jsConsole.writeLine('Here are the boolean literals - true: ' + boolLitTrue + 'and false: ' + boolLitFalse);
jsConsole.writeLine('It\'s time for some strings: ' + stringLit);
jsConsole.writeLine('Our string literal has: ' + stringLit.length + ' symbols');
jsConsole.writeLine('arrayLit[0] = ' + arrayLit[0]);
jsConsole.writeLine('arrayLit[2] = ' + arrayLit[2]);
jsConsole.writeLine('arrayLit[5] = ' + arrayLit[5]);
jsConsole.writeLine('arrayLit has ' + arrayLit.length + ' elements');
jsConsole.writeLine('Here we have a dog object with name: ' + objectLit.name + '; breed: ' + objectLit.breed + '; age: ' + objectLit.age);
jsConsole.writeLine('<---------------------------------------------------------------------------->');