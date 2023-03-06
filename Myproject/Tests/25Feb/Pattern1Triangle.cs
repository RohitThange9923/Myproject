using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myproject.TestFeb._25Feb
{
    internal class Pattern1Triangle
    {
        static void Main(string[] args)
        {

            for (int i = 1; i <= 4; i++)
            {
                for (int j =1; j <= 2*i-1; j++)
                {
                    
                  Console.Write(i);
                }
                Console.WriteLine();
            }
        }
    }
}


/*
             1
            222
            33333
            4444444
 
 
 
 */








