define(function () {
    'use strict';

    var Student = (function () {
        function Student(fName, lName, age, marks) {
            this._age = setAge.call(this, age);
            this._firstName = setName.call(this, fName);
            this._lastName = setName.call(this, lName);
            this._marks = [];
        }

        function setName(inputName) {
            if (!inputName instanceof String) {
                throw new Error("The name of the student must be of type string!");
            }

            if (4 > inputName.length && inputName.length > 15) {
                throw new Error("The name of the student must be in the range [4, 15]!");
            }

            return inputName;
        }

        function setAge(inputAge) {
            if (!inputAge instanceof Number) {
                throw new Error("The age of the student must be of type number");
            }

            if (inputAge < 0) {
                throw new Error("Cannot set the age of the student to a negative number!");
            }

            return inputAge;
        }

        Student.prototype.fullName = function () {
            return this._firstName + ' ' + this._lastName;
        }

        Student.prototype.getFirstName = function () {
            return this._firstName;
        }

        Student.prototype.getLastName = function () {
            return this._lastName;
        }

        Student.prototype.getAge = function () {
            return this._age;
        }

        var markToString = function () {
            return this.subject + ' -> ' + this.mark;
        }

        Student.prototype.addMark = function (subject, mark) {
            this._marks.push({
                subject: subject,
                mark: mark,
                toString: markToString
            });

            return this;
        }

        return Student;
    }());

    return Student;
});