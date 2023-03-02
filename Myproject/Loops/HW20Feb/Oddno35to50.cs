using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myproject.Loops.HW20Feb
{
    internal class Oddno35to50
    {
        static void Main(string[] args)
        {
            //odd number between 35 to 50

            Console.WriteLine("Odd number 35 to 50 :");
            int i;
            for (i = 35; i <= 50; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}

