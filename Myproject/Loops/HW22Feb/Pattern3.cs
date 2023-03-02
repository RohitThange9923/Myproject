using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myproject.Loops.HW22Feb
{
    internal class Pattern3
    {
        static void Main(string[] args)
        {
            for (int i = 4; i >=1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }
}

/*
                    1234
                    123
                    12
                    1
 
 */
