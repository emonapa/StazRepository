
namespace UniModel
{
    public class Person
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public DateTime birthdayDate { get; set; }

        public Person(string firstName, string lastName, DateTime birthdayDate)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.birthdayDate = birthdayDate;
        }
    }
}

/*
namespace UniModel
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthdayDate { get; set; }

        public Person(string firstName, string lastName, DateTime birthdayDate)
        {
            FirstName = firstName;
            LastName = lastName;
            BirthdayDate = birthdayDate;
        }
    }
}
*/
