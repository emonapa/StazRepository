using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StazOOP_JSON
{

    internal class Person
    {
        internal string name;
        internal string surname;
        internal DateTime birthdayDate;

        public Person(string name, string surname, DateTime birthdayDate)
        {
            this.name = name;
            this.surname = surname;
            this.birthdayDate = birthdayDate;
        }   

        internal virtual string GetInfo()
        {
            return ($"{name} {surname}, datum narození: {birthdayDate.ToString("dd/MM/yyyy")}");
        }

    }
}
