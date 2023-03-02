using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myproject.Loops.HW20Feb
{
    internal class Sumof1to10
    {
        static void Main(string[] args)
        {
            // find out the sum of 1 to 10 numbers

             {
                int sum = 0;

                for (int i = 1; i <= 10; i++)
                {
                    sum += i;

                }
                Console.WriteLine("Sum of 1 to 10 NUMBERS:" + sum); 
             }
        }
        
    }
}
