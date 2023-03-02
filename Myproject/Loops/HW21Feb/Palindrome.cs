using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myproject.Loops.HW21Feb
{
    internal class Palindrome
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
                sum = (sum * 10) + r;
                num = num / 10;

            }
            if (temp == sum)
            {
                Console.WriteLine("Number is Palindome");

            }
            else
            {

                Console.WriteLine("Number is not Palindrome");
            }
        }
    }
}




        