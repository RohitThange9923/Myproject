using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myproject.Loops.HW21Feb
{
    internal class Aramstrong
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int num = Convert.ToInt32(Console.ReadLine());

            int r, temp, sum = 0;
            temp = num;
        
        while (num > 0)
            {
                r = num % 10;
                sum = sum+(r*r*r);
                num = num / 10;

            }
            if (temp == sum)
            {
                Console.WriteLine("Number is Aramstrong");

            }
             else
            {

                Console.WriteLine("Number is not Aramstrong");
            }
        }
    }
}
