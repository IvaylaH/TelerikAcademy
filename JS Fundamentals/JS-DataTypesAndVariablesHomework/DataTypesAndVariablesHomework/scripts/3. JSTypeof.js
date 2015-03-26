var intLit = 15;
var floatingLit = 15.34;
var strLit = 'yet another string literal';
var boolLitFalse = false;
var boolLitTrue = true;
var arrLit = [10, 20, , 'text', 30];
var objLit = {name: 'Gosho', age: 28 };

jsConsole.writeLine('');
jsConsole.writeLine('--> 3. Try typeof on all variables you created.');
jsConsole.writeLine('');
jsConsole.writeLine('integer variables - ' + intLit + '; variable type: ' + typeof intLit);
jsConsole.writeLine('floating-point variable - ' + floatingLit + '; variable type: ' + typeof floatingLit);
jsConsole.writeLine('string variable - \'' + strLit + '\'; variable type: ' + typeof strLit);
jsConsole.writeLine('boolean variable - True: ' + boolLitTrue + '; variable type: ' + typeof boolLitTrue + '; False: ' + boolLitFalse + '; variable type: ' + typeof boolLitFalse);
jsConsole.writeLine('array variable - ' + arrLit.toString() + '; variable type: ' + typeof arrLit);
jsConsole.writeLine('object variable - name: ' + objLit.name + '; age: ' + objLit.age + '; variable type: ' + typeof objLit);
jsConsole.writeLine('<---------------------------------------------------------------------------->');