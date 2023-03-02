using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myproject.Loops
{
    internal class WhilePower
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the base number");
            int baseNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Exponent");
            int expo=Convert.ToInt32(Console.ReadLine());

            int power = 1;
            int i = 1;
            while (i <= expo)
            {
                power = power * baseNumber; 
                i++;
            }
            Console.WriteLine(power);
        }
    }
}
