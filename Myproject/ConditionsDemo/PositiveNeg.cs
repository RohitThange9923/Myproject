using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myproject.ConditionsDemo
{
    internal class PositiveNeg
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter the number:");
            num = Convert.ToInt32(Console.ReadLine());

            if (num > 0)
            {
                Console.WriteLine("Number is positive:");

            }
            else if (num == 0)
            {
                Console.WriteLine("Number is zero:");

            }
            else
            {
                Console.WriteLine("Number is negative:");

            }

            Console.ReadLine();

        }

    }
}
