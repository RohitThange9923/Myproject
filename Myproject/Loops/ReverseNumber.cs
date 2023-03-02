using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myproject.Loops
{
    internal class ReverseNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number");
            int num =Convert.ToInt32(Console.ReadLine());

            int numCopy = num;
            int revers = 0;

            while(num > 0)
            {
                int digit=num%10;
                revers=revers*10+digit;
                num = num / 10;

            }
            Console.WriteLine(revers);
        }
    }
}
