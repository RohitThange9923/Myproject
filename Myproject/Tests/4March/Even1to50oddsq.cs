using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myproject.Tests._4March
{
    internal class Even1to50oddsq
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 50; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine("Even no:"+i);
                }
                else
                {
                    Console.WriteLine("Odd no Square:"+i * i);
                }
            }
        }
    }
}
