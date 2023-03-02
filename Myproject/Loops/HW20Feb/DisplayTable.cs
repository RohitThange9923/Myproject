using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myproject.Loops.HW20Feb
{
    internal class DisplayTable
    {
        static void Main(string[] args)
        {
            // enter the number from user & table display


            {
                Console.WriteLine("Enter the number for Table:");

                int num = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine(num * i);
                }
            }
        }
    }
}
