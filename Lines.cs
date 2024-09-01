using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Lines
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 2;
            int c = 3;
            int d = 4;

            Console.WriteLine($"value of a ={a},value of b={b}, value of c={c}, value of d={d}");


            int e = 5;
            int f = 6;
            int g = 7;
            int h = 8;

            Console.WriteLine($"value of e ={e}");
            Console.WriteLine($"value of f ={f}");
            Console.WriteLine($"value of g ={g}");
            Console.WriteLine($"value of h ={h}");



            int number = 20;
                if (number % 2 == 0) {
                Console.WriteLine("even number");
            }
                else
            {
                Console.WriteLine("odd number");
            }


        }

    }

}