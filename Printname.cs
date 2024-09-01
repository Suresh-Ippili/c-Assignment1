using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Printname
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter your name");
            string name = Console.ReadLine();   
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("my name is " + name);
            }
        }
    }
}
