using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HelloWorldTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string Name = "";

            Console.Write("Please Enter your name : ");
            Name = Console.ReadLine();
            Console.WriteLine("Hello " + Name + "!");
            Console.ReadKey();
        }
    }
}
