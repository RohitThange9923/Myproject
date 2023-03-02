using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myproject.ConditionsDemo
{
    internal class NumberInWord
    {
        static void Main(string[] args)
        {
            //syntax
            /* if(condition)
             {
                 true stat.
             }
             else if(condition)
             {

             }
             else if (condition)
             {

             }
             else
             {

             }*/

            //Print given number in word between 1 to 5

            Console.WriteLine("Enter the number between 1 to 5");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num ==1)
            {
                Console.WriteLine("One");
            }
            else if(num ==2)
            {
                Console.WriteLine("Two");
            }
            else if (num ==3)
            {
                Console.WriteLine("Three");
            }
            else if (num==4)
            {
                Console.WriteLine("Four");
            }
            else if (num ==5)
            {
                Console.WriteLine("Five");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }

    }
}
