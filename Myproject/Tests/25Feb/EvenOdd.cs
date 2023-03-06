using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myproject.TestFeb._25Feb
{
    internal class EvenOdd
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Printing Numbers 1 to 50:");
            for (int i = 1; i <= 50; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
                else
                {
                    Console.WriteLine(-i + " (" + (i * i) + ")");
                }
            }
            Console.ReadLine();
        }
    }
}
