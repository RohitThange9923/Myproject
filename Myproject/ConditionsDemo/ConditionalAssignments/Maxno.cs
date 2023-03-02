using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myproject.ConditionsDemo.ConditionalAssignments
{
    internal class Maxno
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number:");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second number:");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the 3rd number:");
            int num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
            {
                Console.WriteLine("Num1 is greater");
            }
            else if (num2 > num3)
            {
                Console.WriteLine("Num2 is Greater:");
            }

            else
            {
                Console.WriteLine("Num3 is Greater");
            }
        }
    }
    
}
