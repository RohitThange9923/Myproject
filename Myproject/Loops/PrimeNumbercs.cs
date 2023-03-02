using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myproject.Loops
{
    internal class PrimeNumbercs
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int num =int.Parse(Console.ReadLine());

            int i = 2;
            bool isprime =true;

            while (1<num)
            {
                if(num%i==0)
                {
                    isprime =false; 
                    break;
                }
                i++;

            }

            if(isprime=true)
            {
                Console.WriteLine("Prime");

            }
            else 
            { 
                Console.WriteLine("Not Prime");
            }

        }
    }
}
