using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myproject.OOPS
{
    internal class Factor
    {
        public void PrintFactor(int number)
        {
            int i = 0;
            Console.WriteLine(number);

            for (i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    Console.WriteLine(i + " ");
                }

            }
        }

        static void Main(string[] args)
        {
            Factor fact = new Factor();

            int number = 0;

            Console.WriteLine("Enter an integer number:");
            number = int.Parse(Console.ReadLine());

            fact.PrintFactor(number);
            Console.WriteLine();

        }

    }
}








