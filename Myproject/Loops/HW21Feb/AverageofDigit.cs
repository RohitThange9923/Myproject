using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myproject.Loops.HW21Feb
{
    internal class AverageofDigit
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number:");
            int num=Convert.ToInt32(Console.ReadLine());

            int count = 0;
            int sum = 0;
            int Avg;

            while(num>0)
            {
                int digit =num%10;
                sum = sum + digit;
                num= num/10;
                count++;
            }

            Avg= sum/count;
            Console.WriteLine("Avg is ="+Avg);
        }
    }
}
