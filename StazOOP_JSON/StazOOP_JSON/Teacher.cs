using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace StazOOP_JSON
{
    internal class Teacher : Person
    {
        internal string firstTitle;
        internal string lastTitle;

        public Teacher(string name, string surname, DateTime birthdayDate, string firstTitle, string lastTitle) : base(name, surname, birthdayDate)
        {
            this.firstTitle = firstTitle;
            this.lastTitle = lastTitle;
        }

        internal override string GetInfo()
        {
            return ($"{firstTitle} {name} {surname} {lastTitle}, datum narození: {birthdayDate.ToString("dd/MM/yyyy")}");
        }
    }
}
