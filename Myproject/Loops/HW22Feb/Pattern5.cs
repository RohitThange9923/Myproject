using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myproject.Loops.HW22Feb
{
    internal class Pattern5
    {
        static void Main(string[] args)
        {

            int num = 5;
            int i, j;

            for ( i = 1; i <= num; i++)
            {
                for ( j = 1; j <= i; j++)
                {
                    if (j % 2 == 0)
                    {
                        Console.Write("0");
                    }
                    else
                    {
                        Console.Write("X");
                    }
                    
                }
                Console.WriteLine();
            }
        }

    }
}

/*      X
        X0
        X0X
        X0X0
        X0X0X
 
 */




