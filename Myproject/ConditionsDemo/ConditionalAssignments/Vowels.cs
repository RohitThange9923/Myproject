using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myproject.ConditionsDemo.ConditionalAssignments
{
    internal class Vowels
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Character:");
            char ch = Convert.ToChar(Console.ReadLine());

            if (ch == 'A' || ch == 'a' || ch == 'E' || ch == 'e' || ch == 'I' || ch == 'A' || ch == 'O' || ch == 'U')

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
  