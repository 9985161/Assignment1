using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q5
{
    public class Program
    {
        static void Main(string[] args)
        {
            Student three3 = new Student("", "", "");
            Console.WriteLine("Enter name of new student below");
            Console.Write("Enter first name:");
            three3.FirstName = Console.ReadLine();
            Console.Write("Enter last name:");
            three3.LastName = Console.ReadLine();
            Console.Write("Enter campus:");
            three3.Campus = Console.ReadLine();
            Console.WriteLine("\nCreating new student record ...\n");
            Console.WriteLine($"Adding new student record to {three3.Campus} campus ...");
            Console.WriteLine($"{three3.GetFullName()} of {three3.Campus} has a student ID of {three3.EnrollStudent()}");
            Console.ReadLine();
        }
    }
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Person(string _firstName, string _lastName)
        {
            FirstName = _firstName;
            LastName = _lastName;
        }
        public string GetFullName()
        {
            return $"{FirstName} {LastName}";
        }
    }
    class Student : Person
    {

        public string Campus { get; set; }

        public Student(string _firstName, string _lastName, string _campus) : base(_firstName, _lastName)
        {
            Campus = _campus;
        }
        public int EnrollStudent()
        {
            int _min = 0000;
            int _max = 9999;
            Random _rdm = new Random();
            return _rdm.Next(_min, _max);
        }
    }
}