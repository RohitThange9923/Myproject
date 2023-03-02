using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myproject.Loops.HW23Feb
{
    internal class StarN
    {
        static void Main(string[] args)
        {
            for (int row = 1; row <=4; row++)

            {
                for( int column =0;column <=4;column++)
                {
                    if (column == 1 || column ==4 ||(row==column && column !=0 && column !=4))
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.Write("\n");
            }
        }
    }
}
