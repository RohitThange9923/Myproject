using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myproject.Loops
{
    internal class BreakContinue
    {
        static void Main(string[] args)
        {
            /*for(int i =1;i<10;i++) 
            {
            if(i==4)
                {
                    break;
                }
                Console.WriteLine(i);
            }*/


            for(int i=1;i<=5;i++) 
            {
            if(i==3)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
        }
    }
}
