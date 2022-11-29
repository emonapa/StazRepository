using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StazOOP_JSON
{
    internal class Student: Person
    {
        internal DateTime registrationDate;

        public Student(string name, string surname, DateTime birthdayDate, DateTime registrationDate): base(name, surname, birthdayDate)
        {
            this.registrationDate = registrationDate;
        }

        internal override string GetInfo()
        {
            return ($"{name} {surname}, datum narození: {birthdayDate.ToString("dd/MM/yyyy")}, datum zápisu: {registrationDate.ToString("dd/MM/yyyy")}");
        }
    }
}
