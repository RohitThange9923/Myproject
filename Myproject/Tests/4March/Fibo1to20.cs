using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myproject.Tests._4March
{
    internal class Fibo1to20
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 1;
            int c;
            Console.WriteLine(a);
            Console.WriteLine(b);

            for(int i=1; i<=20; i++)
            {
                c = a + b;
                Console.WriteLine(c);
                a = b;
                b = c;

            }
            Console.ReadLine();
        }
       
    }
}
