using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp43
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mary");
            string name;
            name = Console.ReadLine();
            if (name == "")
                Console.WriteLine("Здравствуй, мир!");
            else
                Console.WriteLine("Здравствуй, " + name + "!");
        }
    }
}