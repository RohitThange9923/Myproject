using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myproject.Loops
{
    internal class Even1to20
    {
        static void Main(string[] args)
        {
            //Find the Even number between 1 to 20

            for(int i=1;i<=20;i++)
            {
                if(i%2==0) 
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
