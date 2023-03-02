using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myproject.ConditionsDemo
{
    internal class ConditionalGreaterNo
    {
        static void Main(string[] args)
        {
            //syntax
            /* //if (condition)
             {
                 true statment;
             }
             else
             {
                 false statment;

             }*/

            //find the largest number between 2 numbers;

            Console.WriteLine("Enter the first number:");
            int num1=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second number:");
            int num2=Convert.ToInt32(Console.ReadLine());

            if(num1>num2)
            {
                Console.WriteLine("The Number is Greater:");
            }
            else
            {
                Console.WriteLine("The Number is not Greater:");

            }
        }
    }
}
