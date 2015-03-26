jsConsole.writeLine('1. Write a script that allocates array of 20 integers and initializes each element by its index multiplied by 5. Print the obtained array on the console.');
jsConsole.writeLine('');

var myArr, arrToStr, i, strLength;

myArr = new Array(20);
arrToStr = 'My array: ';
strLength = 0;

for (i = 0; i < 20; i++) {
    myArr[i] = i * 5;
    arrToStr += myArr[i];
    arrToStr += ', ';
}

strLength = arrToStr.length;
arrToStr = arrToStr.substr(0, arrToStr.length - 2);
arrToStr += '.';

jsConsole.writeLine(arrToStr);