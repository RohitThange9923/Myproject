using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myproject.Loops
{
    internal class GuessNumber
    {
        static void Main(string[] args)
        {
            int magicNumber = 45;

            while(true)
            {
                Console.WriteLine("Enter the number for gussing:");
                int num = Convert.ToInt32(Console.ReadLine());
                if(num>magicNumber)
                {
                    Console.WriteLine("Number is greater plz try again...");
                    continue;

                }
                else if(num<magicNumber)
                {
                    Console.WriteLine("Number is less plz try again...");
                    continue;
                }
                else
                {
                    Console.WriteLine("You guess Correct Number....!!!!");
                    break;
                }
            }
        }
    }
}
