using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myproject.Loops.HW20Feb
{
    internal class SwitchVowels
    {
        static void Main(string[] args)
        {
            //switch Vowels

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

                /* switch (ch)
                 {
                     case 'A':
                         Console.WriteLine("Vowel");
                         break;
                     case 'E':
                         Console.WriteLine("Vowel");
                         break;
                     case 'I':
                         Console.WriteLine("Vowel");
                         break;
                     case 'O':
                         Console.WriteLine("Vowel");
                         break;
                     case 'U':
                         Console.WriteLine("Vowel");
                         break;
                     default:
                         Console.WriteLine("Consonent");
                         break;
                 }*/


            }
        }
    }
}

