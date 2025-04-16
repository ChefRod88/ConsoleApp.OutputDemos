using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.ClassesDemo.Classes.PersonDemo
{
    public partial class Person
    {
        public Person(string firstname, string lastname, string taxNumber)
        {
            FirstName = firstname;
            LastName = lastname;
            _taxNumber = taxNumber;
        }

        public int GetAge()
        {
            var age = DateTime.Now.Year - DateOfBirth.Year;
            return age;

        }

        public int GetAge(int year)
        {
            var age = year - DateOfBirth.Year;
            return age;

        }
    }
}
