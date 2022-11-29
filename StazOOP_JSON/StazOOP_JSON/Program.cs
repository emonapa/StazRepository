using System.Linq;

using StazOOP_JSON; 

DateTime AndrejBirthday = new DateTime(1954, 9, 2);
DateTime PetrBirthday = new DateTime(1964, 9, 1);
DateTime PetrRegistrationDate = new DateTime(2021, 12, 13);

Teacher AndrejTeacher = new Teacher("Andrej", "Babiš", AndrejBirthday, "Phd", "Ing");
Student PetrStudent = new Student("Petr", "Fiala", PetrBirthday, PetrRegistrationDate);

Console.WriteLine(AndrejTeacher.GetInfo());
Console.WriteLine(PetrStudent.GetInfo());


/* Nevím jak to udělat, toto jsem našel na stackoverflow
new
{
    items = new[] {
    new {name = "command" , index = "X", optional = "0"},
    new {name = "command" , index = "X", optional = "0"}
}
}
*/




