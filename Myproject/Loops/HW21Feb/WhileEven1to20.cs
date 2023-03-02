using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myproject.Loops.HW21Feb
{
    internal class WhileEven1to20
    {
        static void Main(string[] args)
        {

            //Find the Even number between 1 to 20 in While loop use

            int i = 1;
            while(i<=20)
            {
                if (i % 2 == 0) 
                {
                    Console.WriteLine(i);
                }
                
                i++;
                
            }

        }
    }
}
