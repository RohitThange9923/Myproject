using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myproject.Loops.HW20Feb
{
    internal class SwitchEvenorODD
    {
        static void Main(string[] args)
        {
            //switch case in even or odd

            int num;
            Console.WriteLine("Enter the first number:");
            num = Convert.ToInt32(Console.ReadLine());

            switch (num % 2 == 0)
            {
                case true:
                    Console.WriteLine("Number is Even");
                    break;

                case false:
                    Console.WriteLine("Number is Odd");
                    break;

            }
         }

    }
}
