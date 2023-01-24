
namespace UniModel
{
    internal class Student: Person
    {
        public DateTime enrolmentDate { get; set; }
        public byte studentCredit { get; set; }
        public List<Subject> subjects { get; set; }

        public Student(string firstName, string lastName, DateTime birthdayDate, DateTime enrolmentDate)
                : base(firstName, lastName, birthdayDate)
        {
            this.enrolmentDate = enrolmentDate;
            studentCredit = 0;
            subjects = new List<Subject>();
        }

        public void AddSubject(Subject subject)
        {
            subjects.Add(subject);
        }
    }
}
