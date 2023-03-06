using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myproject.TestFeb._25Feb
{
    internal class FactSumN
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number ");
            int num = Convert.ToInt32(Console.ReadLine());
            int fact = 1, sum = 0;

            Console.WriteLine("Number\t" + "fact\t" + "\tsum");
            for (int i = 1; i <= num; i++)
            {
                fact *= i;
                sum += fact;
                Console.WriteLine(i + "\t" + fact + "\t\t" + sum);
            }
        }
    }
}
/*
 Enter the number
5
Number  fact            sum
1       1               1
2       2               3
3       6               9
4       24              33
5       120             153
 
 
 
 
 
 */