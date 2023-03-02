using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myproject.ConditionsDemo
{
    internal class DivisibleBy5orNot
    {
        static void Main(string[] args)
        {
            //check the number is divisible  by 5 or not.

            Console.WriteLine("Enter the Number:");
            int num = Convert.ToInt32(Console.ReadLine());

            if(num%5==0)
            {
                Console.WriteLine("Number is Divisible by 5:");
            }
            else
            {
                Console.WriteLine("Number is Not Divisible by 5:");
            }
        }
    }
}
