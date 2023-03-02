using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myproject.Loops.Nested
{
    internal class PatternHi
    {
        static void Main(string[] args)
        {
            /*for(int i=1;i<=3;i++)
            {

                for(int j = 1; j <= 2; j++)
                {
                    Console.WriteLine("Hii");
                }*/


            int i = 1;
            int j=i;
            while(i<=3)
            {
                Console.WriteLine(j);
                j++;
            }
            i++;
            
        }
    }
}
