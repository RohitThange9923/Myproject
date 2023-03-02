using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myproject.Loops.HW21Feb
{
    internal class WhileSumEven1to10
    {
        static void Main(string[] args)
        {
            // Find the Sum of even number between 1 to 10 using while loop

            int i=1;
            int sum=0;
            while(i<=10)
            {
                if(i%2==0)
                {
                    sum = sum + i;
                    
                }
                i++;
            }
            Console.WriteLine(sum);
        }
    }
}
