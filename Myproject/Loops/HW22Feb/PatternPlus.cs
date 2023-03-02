using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myproject.Loops.HW22Feb
{
    internal class PatternPlus
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the rows:");
            int rows = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    if (i == 3 || j == 3)

                        Console.Write("*");

                    else

                        Console.Write(" ");
                }
                    Console.WriteLine("");
                
               
            }
        }
    }
}
