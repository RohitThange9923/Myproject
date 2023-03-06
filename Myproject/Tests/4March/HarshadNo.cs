using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myproject.Tests._4March
{
    internal class HarshadNo
    {
    static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number:");
            int num=int.Parse(Console.ReadLine());
            int sum = 0;
            int temp = num;
            while(num> 0)
            {
                int digit = num % 10;
                sum = sum + digit;
                num = num / 10;
            }

            if(temp % sum ==0)
            {
                Console.WriteLine("Given number is Harshad");

            }
            else
            {
                Console.WriteLine("Not Harshad");

            }

        }
    }
}
