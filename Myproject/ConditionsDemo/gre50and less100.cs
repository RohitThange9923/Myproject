using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myproject.ConditionsDemo
{
    internal class gre50and_less100
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number:");
            int num = Convert.ToInt32(Console.ReadLine());


            if (num > 50)
            {
                Console.WriteLine("Number is greater than 50:");
            }
            else
            {
                Console.WriteLine("Number  is  NOT greater than 50:");

            }

         

            if (num<= 100)
            {
                Console.WriteLine("Number is greater than 100:");
            }
            else
            {
                Console.WriteLine("Number  is  NOT greater than 100:");

            }

        }
    }
}
