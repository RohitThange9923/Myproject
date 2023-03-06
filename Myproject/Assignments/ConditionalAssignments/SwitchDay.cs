using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myproject.Assignment1.ConditionalAssignments
{
    internal class SwitchDay
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the day number between 1 to 7:");
            int num = Convert.ToInt32(Console.ReadLine());

            switch (num)
            {
                case 1:
                    Console.WriteLine("Mon");
                    break;
                case 7:
                    Console.WriteLine("Sun");
                    break;
                case 4:
                    Console.WriteLine("Thru");
                    break;
                case 3:
                    Console.WriteLine("Wed");
                    break;
                case 2:
                    Console.WriteLine("Tues");
                    break;
                case 5:
                    Console.WriteLine("Fri");
                    break;
                case 6:
                    Console.WriteLine("Sat");
                    break;
                default:
                    Console.WriteLine("Invalid Day Number:");
                    break;

            }
        }

    }



}

