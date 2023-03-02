using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myproject.Loops.HW22Feb
{
    internal class Pattern4
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 4; j >=i; j--)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }
}

                 /* 4321
                    432
                    43
                    4    */