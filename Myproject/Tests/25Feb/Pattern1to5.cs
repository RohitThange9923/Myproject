using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myproject.TestFeb._25Feb
{
    internal class Pattern1to5
    {
        static void Main(string[] args)
        {
            for (int i = 5; i >= 0; i--)
            {
                for (int j = 1; j <=i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine(" ");
            }
        }

    }

}

/*
 
            1 2 3 4 5
            1 2 3 4
            1 2 3
            1 2
            1

*/





