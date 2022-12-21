using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("welcome");

            Console.WriteLine("Enter the start ");

            int start = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the end");
            

            int limit = int.Parse(Console.ReadLine());
            Console.WriteLine("The Prime Numbers is :");

            for (int i = start; i < limit; i++)
            {
                if (i == 0) continue;
                if (i == 1) continue;

                bool isPrimeNum = true;
                for (int j = 2; j <= i / 2; j++)
                {
                    if (i % j == 0)
                    {
                        isPrimeNum = false; break;
                    }
                }
                if (isPrimeNum)
                {
                    Console.WriteLine(i);


                }
                Console.WriteLine();      

            }




        }
    }
}
