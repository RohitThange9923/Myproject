using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myproject.Assignment1.ConditionalAssignments
{
    internal class CalculatorSwitch
    {


        static void Main(string[] args)
        {
            //Addition, subtraction ,Multiplication,Division use in Switch Case

            Console.WriteLine("Enter the 1 st number:");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the 2 nd number:");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("+ Addition \t  -Substraction \t * Multipication \t / Division :");
            Console.WriteLine("Pls Enter Valid Oprator from Above Menu:");
            char op = Convert.ToChar(Console.ReadLine());

            switch (op)
            {
                case '+':
                    Console.WriteLine("Addition = " + (num1 + num2));
                    break;
                case '-':
                    Console.WriteLine("Substraction = " + (num1 - num2));
                    break;
                case '*':
                    Console.WriteLine("Multiplication = " + (num1 * num2));
                    break;
                case '/':
                    Console.WriteLine("Division = " + (num1 / num2));
                    break;
                default:
                    Console.WriteLine("Invalid Oprator:");
                    break;
            }
        }

    }

}
