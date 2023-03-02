using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myproject.ConditionsDemo
{
    internal class Div3or9
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the Number:");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num % 3 == 0  && num % 9 == 0)
            {
                Console.WriteLine("Number is Divisible by 3 and 9:");
            }
            else
            {
                Console.WriteLine("Number is Not Divisible by 3 and 9:");
            }
        }
    }
}
        