using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myproject.ConditionsDemo
{
    internal class Vowel
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Character:");
           char ch=Convert.ToChar(Console.ReadLine());
            
            if(ch =='a' || ch =='e' || ch =='i' || ch =='o' || ch =='u')
            {
                Console.WriteLine("Vowel");
            }
            else
            {
                Console.WriteLine("Consonent");
            }


          /*  if(ch=='a')
            {
                Console.WriteLine("Vowel");
            }
            else if(ch=='e')
            {
                Console.WriteLine("Vowel");
            }
            else if (ch == 'i')
            {
                Console.WriteLine("Vowel");
            }
            else if (ch == 'o')
            {
                Console.WriteLine("Vowel");
            }
            else if (ch == 'u')
            {
                Console.WriteLine("Vowel");
            }
            else
            {
                Console.WriteLine("Consonent");
            }*/
        }
    }
}
