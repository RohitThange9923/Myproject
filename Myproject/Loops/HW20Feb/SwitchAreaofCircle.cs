using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myproject.Loops.HW20Feb
{
    internal class SwitchAreaofCircle
    {
        static void Main(string[] args)
        {
             // Area of Circle,rectangle,square as per user choice switch case
  
              int l, b, s, h, b1;
              float r;
              int num;

              Console.WriteLine("Area:");
              Console.WriteLine("1.Area of circle \n 2. Area of Rectangle \n 3.Area of Square \n 4.Area of Triangle : ");
              Console.WriteLine("Enter the number to perform oprations:");
              num = Convert.ToInt32(Console.ReadLine());

            switch (num)
            {
                case 1:
                    Console.WriteLine("Enter the radius:");
                    r = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Area of Circle:" + (3.14 * r * r));
                    break;

                case 2:
                    Console.WriteLine("Enter the value of l and b:");
                    l = Convert.ToInt32(Console.ReadLine());
                    b = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Area of Rectangle:" + (l * b));
                    break;

                case 3:
                    Console.WriteLine("Enter the value if side:");
                    s = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Area of square:" + (s * s));
                    break;

                case 4:
                    Console.WriteLine("Enter the value of h and b1:");
                    h = Convert.ToInt32(Console.ReadLine());
                    b1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Area of rectangle:" + (1 / 2 * h * b1));
                    break;
                default:
                    Console.WriteLine();
                    break;
            }
                   
        }
    }
}
