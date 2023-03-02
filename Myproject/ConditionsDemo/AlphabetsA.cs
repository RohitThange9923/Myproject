using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myproject.ConditionsDemo
{
    internal class AlphabetsA
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Character:");
            char ch = Convert.ToChar(Console.ReadLine());

            if ((ch == 'a' || ch == 'z') || (ch == 'A' || ch == 'Z'))
            {
                Console.WriteLine("Is AN ALphabets");

            }
            else
            {
                Console.WriteLine("Specia; Char:");
            }
        }
    }

}
