
namespace UniModel
{
    public class UniClass
    { 
        internal class Teacher: Person
        {
            public string firstDegree { get; set; }
            public string lastDegree { get; set; }
            public List<Subject> subjects { get; set; }

            public Teacher(string firstDegree, string lastDegree, string firstName, string lastName, DateTime birthdayDate)
                    : base(firstName, lastName, birthdayDate)
            {
                this.firstDegree = firstDegree;
                this.lastDegree = lastDegree;
                subjects = new List<Subject>();
            }

            public void AddSubject(Subject subject)
            {
                subjects.Add(subject);
            }
        }
    }
}
