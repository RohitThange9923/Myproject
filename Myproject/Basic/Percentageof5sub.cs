using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myproject.Basic
{
    internal class Percentageof5sub
    {
        static void Main(string[] args)
        {
            int sub1, sub2, sub3, sub4, sub5;
            float total ,perc;

            Console.WriteLine("Enter the marks of subject 1:");
            sub1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the marks of subject 2:");
            sub2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the marks of subject 3:");
            sub3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the marks of subject 4:");
            sub4 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the marks of subject 5:");
            sub5 = Convert.ToInt32(Console.ReadLine());

            total = sub1+ sub2 + sub3 + sub4 + sub5;

            perc = (total / 500) * 100;

            Console.WriteLine("Total marks is:" +total);
            Console.WriteLine("Total percentage is:"+perc);

        }
    }
}
