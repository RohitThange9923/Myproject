using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myproject.Loops.HW23Feb
{
    internal class PatternA
    {
        static void Main(string[] args)
        {
            for(char i='A';i<='D';i++)
            {
                for(char j='A';j<=i;j++)

                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
        }
    }
}
