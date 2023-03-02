using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myproject.ConditionsDemo
{
    internal class EvenOdd
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter the first number:");
            num = Convert.ToInt32(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine("Number is Even");
            }
            else
            {
                Console.WriteLine("Number is Odd");
            }


        }
    }
}
