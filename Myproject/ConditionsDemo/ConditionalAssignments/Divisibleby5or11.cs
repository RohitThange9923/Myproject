using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myproject.ConditionsDemo.ConditionalAssignments
{
    internal class Divisibleby5or11
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the Number:");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num % 5 == 0 && num % 11 == 0)
            {
                Console.WriteLine("Number is Divisible by 5 and 11:");
            }
            else
            {
                Console.WriteLine("Number is Not Divisible by 5 and 11:");
            }
        }
    }
}
    
