using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myproject.TestFeb._25Feb
{
    internal class Star
    {
        static void Main(string[] args)
        {
            for(int i=1;i<=5;i++)
            {
                for(int j=i;j<=5;j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
/*
 
*****
****
***
**
*

             */