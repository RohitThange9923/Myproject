using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myproject.ConditionsDemo
{
    internal class SwitchVowel
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("Enter the Character:");
                char ch = Convert.ToChar(Console.ReadLine());

                switch (ch)
                {
                    case 'a':
                        Console.WriteLine("Vowel");
                        break;
                    case 'e':
                        Console.WriteLine("Vowel");
                        break;
                    case 'i':
                        Console.WriteLine("Vowel");
                        break;
                    case 'o':
                        Console.WriteLine("Vowel");
                        break;
                    case 'u':
                        Console.WriteLine("Vowel");
                        break;
                    default:
                        Console.WriteLine("Consonent");
                        break;

                }
            }
        } 
            
                   
    }
}
