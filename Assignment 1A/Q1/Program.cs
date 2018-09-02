using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    public class Program
    {
        private string col;
        private string mk;
        private string gbox;
        public string Colour
        {
            get { return col; }
            set { col = value; }
        }
        public string Make
        {
            get { return mk; }
            set { mk = value; }
        }
        public string Gearbox
        {
            get { return gbox; }
            set { gbox = value; }
        }
        static void Main(string[] args)
        {
            Program Car1 = new Program();
            Console.WriteLine("Enter Colour");
            Car1.Colour = Console.ReadLine();
            Console.WriteLine("Enter Make");
            Car1.Make = Console.ReadLine();
            Console.WriteLine("Enter Transmission");
            Car1.Gearbox = Console.ReadLine();
            Console.WriteLine("Enter new car details below");
            Console.WriteLine($"Colour: {Car1.Colour}");
            Console.WriteLine($"Make: {Car1.Make}");
            Console.WriteLine($"Gearbox type: {Car1.Gearbox}");
            Console.WriteLine("");
            Console.WriteLine($"This car is a {Car1.Colour} {Car1.Make} with a {Car1.Gearbox} transmission");
            Console.ReadLine();
        }
    }
}
