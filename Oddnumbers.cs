using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Oddnumbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("odd numbers between 0 to 20 are");

            for (int i = 1; i <= 20; i+=2) 
            {
                Console.WriteLine(i);
            }

            int k = 21;
            Console.WriteLine("odd numbers between 20 to 60 are");
            while(k<60)
            {
                Console.WriteLine(k);
                k += 2;
            }

            int j = 61;
            Console.WriteLine("odd numbers between 60 to 100 are");
            do
            {
                Console.WriteLine(j);
                j += 2;
            }
            while (j < 100);

    {

            } 



        }



    }

}