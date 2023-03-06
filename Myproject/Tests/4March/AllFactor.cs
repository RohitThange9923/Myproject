using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myproject.Tests._4March
{
    internal class AllFactor
    {
        static void Main(string[] args)
        {
            int n;

            Console.Write("Enter a number: ");
            n = int.Parse(Console.ReadLine());

            Console.Write("All factors of {0} are: ", n);
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    Console.Write("{0} ", i);
                }
            }
            Console.WriteLine();
        }
    }
}
