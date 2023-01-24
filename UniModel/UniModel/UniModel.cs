using UniModel;
using static UniModel.UniClass;


DateTime vaclavBirthday = new DateTime(2000, 12, 1);
DateTime vaclavEnrolment = new DateTime(2011, 8, 12);
Student vaclavStudent = new Student("Václav", "Matyáš", vaclavBirthday, vaclavEnrolment);


DateTime petrBirthday = new DateTime(1985, 10, 9);
Teacher petrTeacher = new Teacher("Hgr", "Tjr", "Petr", "Fiala", petrBirthday);

Subject math = new Subject("Math", false, true, 5);
Subject history = new Subject("History", true, false, 3);

vaclavStudent.AddSubject(history);
petrTeacher.AddSubject(math);

Console.WriteLine($"{vaclavStudent.firstName} {vaclavStudent.lastName} studuje {vaclavStudent.subjects.Last().name}");
Console.WriteLine($"{petrTeacher.firstName} {petrTeacher.lastName} učí {petrTeacher.subjects.Last().name}");



