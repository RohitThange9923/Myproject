using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myproject.Loops.HW23Feb
{
    internal class Factsum1to5
    {
        static void Main(string[] args)
        {
            // Factorial bet sum 1 to 5

            int fact = 1, sum = 0;

            Console.WriteLine("Number\t"+"fact\t"+"\tsum");
            for (int i=1; i<=5;i++)
            {
                fact *=  i;
                sum += fact;
                Console.WriteLine(i+"\t"+fact+"\t\t"+sum);
            }

        }
    }
}

/*
Number  fact            sum
1       1               1
2       2               3
3       6               9
4       24              33
5       120             153
 
 */