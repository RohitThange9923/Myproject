using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myproject.Loops.HW20Feb
{
    internal class Switch1to5noinWord
    {
        static void Main(string[] args)
        {

            // Write a 1 to 5 number in word. 

            Console.WriteLine("Enter the number 1 to 5");
            int num = Convert.ToInt32(Console.ReadLine());

            switch (num)
            {
                case 1:
                    Console.WriteLine("One");
                    break;
                case 2:
                    Console.WriteLine("Two");
                    break;
                case 3:
                    Console.WriteLine("Three");
                    break;
                case 4:
                    Console.WriteLine("Four");
                    break;
                case 5:
                    Console.WriteLine("Five");
                    break;
                default:
                    Console.WriteLine("Invalid Number");
                    break;
            }
        }
    }
}
