using System.Collections;
using System.Linq;

using StazOOP_JSON; 

DateTime AndrejBirthday = new DateTime(1954, 9, 2);
DateTime PetrBirthday = new DateTime(1964, 9, 1);
DateTime PetrRegistrationDate = new DateTime(2021, 12, 13);

Teacher AndrejTeacher = new Teacher("Andrej", "Babiš", AndrejBirthday, "Phd", "Ing");
Student PetrStudent = new Student("Petr", "Fiala", PetrBirthday, PetrRegistrationDate);

Console.WriteLine(AndrejTeacher.GetInfo());
Console.WriteLine(PetrStudent.GetInfo());


Dictionary<string, Dictionary<string, List<string>>> studentInfo =
    new Dictionary<string, Dictionary<string, List<string>>>
    {
        {
            "Student",
            new Dictionary<string, List<string>>
            {
                {"FullName", new List<string> {"Vašek Matyáš"}},
                {"BirthdayDate",new List<string> {"5/12/2004"}},
                {"Grade", new List<string> {"4"}},
                {"Subjects", new List<string> 
                    { "math",
                      "biology",
                      "physics",
                      "gender studies"} 
                }
            }
        }      
    };
Console.WriteLine(studentInfo["Student"]["FullName"][0]);
Console.WriteLine("Změna");
studentInfo["Student"]["FullName"][0] = "Karel Čtvrtý";
Console.WriteLine(studentInfo["Student"]["FullName"][0]);

studentInfo["Student"]["Subjects"].Add("descriptive geometry");





