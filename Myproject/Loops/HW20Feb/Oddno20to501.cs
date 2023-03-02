using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myproject.Loops.HW20Feb
{
    internal class Oddno20to501
    {
        static void Main(string[] args)
        {
            // COUNT ODD NO BETWEEN 20 TO 50
            {
                int count = 0;
                for (int i = 20; i <= 50; i++)
                {
                    if (i % 2 != 0)
                    {
                        count++;
                        Console.WriteLine(i);
                    }
                }

            }
        }
    }
}
