using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myproject.Basic
{
    internal class Cube
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the cube of number");
            double num = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(num);

            /*double n = 3;*/
            double cube= Math.Pow(num,3);
            Console.WriteLine("cube of number"+cube);
            Console.ReadLine();
        }
    }
}
