using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myproject.ConditionsDemo
{
    internal class UppercaseLowercase
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the character:");
            char ch=Convert.ToChar(Console.ReadLine());

            int x = ch;//Asci value print
            Console.WriteLine(x);

            if (ch >='A' && ch <='Z')
            {
                Console.WriteLine("UpperCase Letter");
            }
            else if(ch>='a' && ch <='z')
            {
                Console.WriteLine("LowerCase Letter");
            }
            else
            {
                Console.WriteLine("Invalid char");
            }
        }
    }
}
