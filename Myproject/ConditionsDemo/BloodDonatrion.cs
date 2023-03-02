using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myproject.ConditionsDemo
{
    internal class BloodDonatrion
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Age:");
            int age=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Weight:");
            int wt=Convert.ToInt32(Console.ReadLine());

            if (age > 18)
            {
                if (wt >= 50)
                {
                    Console.WriteLine("Eligible for Blood Donation:");
                }
                else
                {
                    Console.WriteLine("Weight is less try Next Time...");
                }
            }
            else
            {
                Console.WriteLine("Not Eligible:");

            }
            
        }
    }
}
