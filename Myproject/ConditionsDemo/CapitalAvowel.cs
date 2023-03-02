using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myproject.ConditionsDemo
{
    internal class CapitalAvowel
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the Character:");
            char ch = Convert.ToChar(Console.ReadLine());

            if (ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U')

            {
                Console.WriteLine("Vowel");
            }

            else
            {
                Console.WriteLine("Consonent");
            }


        }
    }
}

