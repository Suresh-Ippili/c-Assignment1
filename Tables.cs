using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Tables
    {
        static void Main(string[] args)
        {
            int number = 5;
            Console.WriteLine($"Multiplication table of {number} is :");

            for (int i = 1; i <=10;i++)
            {
             Console.WriteLine($"{number}*{i}={number*i}");
            }

            int number2 = 6;
            int j=1;
            Console.WriteLine($"Multiplication table of {number2} is :");

           while(j<=10)
            {
                Console.WriteLine($"{number2}*{j}={number2 * j}");
                j++;
            }

            int number3 = 7;
            int k = 1;
            Console.WriteLine($"Multiplication table of {number3} is :");
            do
            {
                Console.WriteLine($"{number3}*{k}={number3 * k}");
                k++;
            }
            while (k <= 10);



        }

    }

}