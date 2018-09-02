using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4
{
    class Program
    {
        static void Main(string[] args)
        {
            string newperson;
            Person one1 = new Person("", "", 0);
            Console.WriteLine("Enter name of new person below");
            Console.Write("Enter First Name:");
            one1.FirstName = Console.ReadLine();
            Console.Write("Enter Last Name:");
            one1.LastName = Console.ReadLine();
            Console.WriteLine("\nCreating new person record ...\n");
            Console.Write("Enter year of birth:");
            one1.YearOfBirth = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine($"Person: {one1.GetFullName()} is {one1.GetAge()} years old\n");
            do
            {
                Console.Write("Do you want to enter another person? <y/n>");
                newperson = Console.ReadLine();
                Console.WriteLine();
                if (newperson == "y")
                {
                    Person two2 = new Person("", "", 0);
                    Console.WriteLine("Enter name of new person below");
                    Console.Write("Enter First Name:");
                    two2.FirstName = Console.ReadLine();
                    Console.Write("Enter Last Name:");
                    two2.LastName = Console.ReadLine();
                    Console.WriteLine("\nCreating new person record ...\n");
                    Console.Write("Enter year of birth:");
                    two2.YearOfBirth = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                    Console.WriteLine($"Person: {two2.GetFullName()} is {two2.GetAge()} years old");
                }
                Console.ReadLine();
                if (newperson == "n")
                {
                    Console.WriteLine("Press any key to exit the program");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Error: invalid entry");
                }
            } while (newperson == "y");
        }
    }
}
