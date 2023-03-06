using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myproject.TestFeb._25Feb
{
    internal class SPYnumber
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int num = Convert.ToInt32(Console.ReadLine());

            int digit, sum = 0;
            int prod = 1;
            int orgNum = num;

            while (num > 0)
            {
                digit = num % 10;

                sum += digit;
                prod *= digit;
                num /= 10;
            }

            if (sum == prod)
                Console.WriteLine(orgNum + " is Spy Number"); 
        else
                Console.WriteLine(orgNum + " is not Spy Number");
        }
    }

}
    