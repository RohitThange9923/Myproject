using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myproject.Loops.HW23Feb
{
    internal class SumPrime
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int i = 2;
            int num = 10;


            while (i <= num)
            {
                if (num % i == 0)
                {

                    sum = sum + i;

                }
                i++;

            }
            Console.WriteLine("1 to 10 prime numbers sum :"+sum);
            
        }
    }
        
}
