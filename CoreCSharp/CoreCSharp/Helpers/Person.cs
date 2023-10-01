using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreCSharp.Strings
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }


        private readonly DateTime _birthDate;


        public Person(string firstName, string lastName, DateTime birthDate)
        {
            FirstName = firstName;
            LastName = lastName;
            _birthDate = birthDate;
        }

        public int GetAge()
        {
            int age = DateTime.Today.Year - (int)_birthDate.Year;

            if (_birthDate > new DateTime(_birthDate.Year, DateTime.Today.Month, DateTime.Today.Day))
            {
                age = age - 1;
            };

            return age;
        }
    }
}
