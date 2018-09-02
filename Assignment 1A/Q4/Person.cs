using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int YearOfBirth { get; set; }
        public Person(string _firstName, string _lastName, int _yearOfBirth)
        {
            FirstName = _firstName;
            LastName = _lastName;
            YearOfBirth = _yearOfBirth;
        }
        public string GetFullName()
        {
            return $"{FirstName} {LastName}";
        }
        public int GetAge()
        {
            return 2018 - YearOfBirth;
        }
    }
}