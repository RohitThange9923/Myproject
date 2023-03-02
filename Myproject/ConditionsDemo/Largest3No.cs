using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myproject.ConditionsDemo
{
    internal class Largest3No
    {
        static void Main(string[] args)
        {
            //Find the Largest 3 Numbers.

            Console.WriteLine("Enter the 1st Number:");
            int num1 =Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the 2nd Number:");
            int num2=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the 3rd Number:");
            int num3=Convert.ToInt32(Console.ReadLine());

            /*if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.WriteLine("Num1 is Greater");
                }
                else
                {
                    Console.WriteLine("Num3 is Greater");
                }
            }
            else if (num2 > num3)
            {
                Console.WriteLine("Num2 is Greater");
            }
            else
            {
                Console.WriteLine("Num3 is greater");
            }*/
            

            if(num1>num2 && num1>num3)
            {
                Console.WriteLine("Num1 is graeter");
            }
            else if (num2> num1 && num2> num3) 
            {
                Console.WriteLine("Num2 is graeter");

            }
            else
            {
                Console.WriteLine("Num3 is greater");
            }
        }
    }
}
