using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myproject.Loops
{
    internal class SumEven1to10
    {
        static void Main(string[] args)
        {

            // Find the Sum of even number between 1 to 10

            int sum = 0;
            for(int i=1;i<=10;i++)
            {
                if(i%2==0)
                {
                    sum = sum + i;
                }
                
            }
            Console.WriteLine(sum);
        }
    }
}
