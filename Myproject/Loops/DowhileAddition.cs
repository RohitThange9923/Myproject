using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myproject.Loops
{
    internal class DowhileAddition
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number1:");
            int num1 =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number2:");
            int num2 =Convert.ToInt32(Console.ReadLine());

            char ch;
            do
            {
                Console.WriteLine("1. Addition \n  2.Substraction \n 3. Multipication \n 4.Division :");
                Console.WriteLine("Enter your choice:");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Addition=" + (num1 + num2));
                        break;
                    case 2:
                        Console.WriteLine("Subtraction=" + (num1 - num2));
                        break;
                    case 3:
                        Console.WriteLine("Multiplication=" + (num1 * num2));
                        break;
                    case 4:
                        Console.WriteLine("Division=" + (num1 / num2));
                        break;
                    default:
                        Console.WriteLine("Invalid Input");
                        break;
                }
                Console.WriteLine("Do you want to continue...");
                ch = Convert.ToChar(Console.ReadLine());
            } while (ch == 'y' || ch == 'Y');

        }
    }
}
