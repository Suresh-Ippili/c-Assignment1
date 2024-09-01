using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Evennumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The even numbers below 40 are ");

            for(int i=0;i<=40;i+=2)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("The even numbers from 40 to 80 are ");

            int j = 40;
            while (j <= 80)
            {
                Console.WriteLine(j);
                j+=2;
            }

            Console.WriteLine("the even numbers between 80 and 120 are");

            int k = 80;
            do
            {
                Console.WriteLine(k);
                k += 2;
            }
            while (k <= 120);

            
        }
    }
}