using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter new car details below");
            Console.WriteLine("Colour:");
            Console.WriteLine("Make:");
            Console.WriteLine("Gearbox type:");
            Car newCar = new Car(Console.ReadLine(), Console.ReadLine(), Console.ReadLine());
        }
    }
    class Car
    {
        public string Colour { get; set; }
        public string Make { get; set; }
        public string Gearbox { get; set; }
        public Car(string _col, string _mk, string _gbox)
        {
            Colour = _col;
            Make = _mk;
            Gearbox = _gbox;
            Console.WriteLine($"Enter new car details below");
            Console.WriteLine($"Colour:{Colour}");
            Console.WriteLine($"Make:{Make}");
            Console.WriteLine($"Gearbox type:{Gearbox}");
            Console.WriteLine("");
            Console.WriteLine($"This car is a {Colour} {Make} with a {Gearbox} transmission");
            Console.ReadLine();
        }
    }
}
