using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perfect_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, i, sum;
            int n1, n2;

            Console.WriteLine();
            Console.WriteLine(" insert numbers from n1,n2 to get perfect numbers :");
            Console.WriteLine();

            Console.Write("n1 : ");
            n1 = int.Parse(Console.ReadLine());
            Console.Write("n2 : ");
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("The Perfect numbers : ");
            for (x = n1; x <= n2; x++)
            {
                i = 1;
                sum = 0;
                while (i < x)
                {
                    if (x % i == 0)
                        sum += i;
                    i++;
                }
                if (sum == x)
                    Console.WriteLine(x);
            }
            Console.WriteLine();








        }
    }
}
