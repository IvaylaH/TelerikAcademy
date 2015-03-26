define(['require', 'student'], function (require, student) {
	'use strict';

	var students = [],
		i,
		j,
		numberOfSubjects = 5,
		numberOfStudents = 10,
		currentStudent,
		studentsFirstName,
		studentsLastName,
		studentsAge,
		subjectName,
		mark,
		index,
		subjects = ['Math', 'Music', 'Biology', 'History', 'Chemistry'],
		firstNames = ['Ivan', 'Dragan', 'Peter', 'Tencho', 'Rumen', 'Georgi', 'Vasko', 'Stefcho', 'Nikola', 'Iliya'],
		lastNames = ['Petrov', 'Ivanov', 'Georgiev', 'Stamatov', 'Rumenov', 'Tenev', 'Vasilev', 'Stoyanov', 'Angelov', 'Stefanov'];
	
	
	for (i = 0; i < numberOfStudents; i += 1) {
		index = generateNameIndex();
		studentsFirstName = firstNames[index];
		studentsLastName = lastNames[index];
		studentsAge = 15 + index;

		currentStudent = new student(studentsFirstName, studentsLastName, studentsAge);

		for (j = 0; j < numberOfSubjects; j += 1) {
			index = generateSubjectIndex();
			subjectName = subjects[index];
			mark = generateMark();

			currentStudent.addMark(subjectName, mark);
		}
	
		students.push(currentStudent);
	}
	
	function generateNameIndex() {
		var number = Math.floor((Math.random() * 10));
	
		return number;
	}

	function generateSubjectIndex(){
		var number = Math.floor((Math.random() * 5));

		return number;
	}

	function generateMark() {
		var number = Math.random() * 4 + 2;

		return number;
	}
	
	return {
		students: students
	};
});