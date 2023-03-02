using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myproject.Loops
{
    internal class Factorialfor
    {
        //find the Factorial

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number:");
            int num=int.Parse(Console.ReadLine());

            int fact = 1;
            for(int i=1; i<=num; i++)
            {
                fact = fact*i;

            }
            Console.WriteLine(fact);
        }
    }
}
