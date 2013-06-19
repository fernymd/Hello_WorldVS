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
            // This is a git test program
            string Name = ""; //Name will receive the user input which will hopefully be the users name.

            Console.Write("Please Enter your name : ");
            Name = Console.ReadLine();
            Console.WriteLine(Name + " says hello to the world!");
            Console.ReadKey();
        }
    }
}
