using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myproject.Loops.HW21Feb
{
    internal class WhileFact
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number:");
            int num = int.Parse(Console.ReadLine());

            int fact = 1;
             

            int i = 1;

            while(i <= num)
            {
                
                
              fact = fact * i;
                i++;
            }
            
            Console.WriteLine(fact);
        }
         
     }
}
