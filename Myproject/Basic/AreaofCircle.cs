using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myproject.Basic
{
    internal class AreaofCircle
    {
        static void Main(string[] args)
        {
            int r;
            double A;
            Console.WriteLine("Enter the Radius:");
            r =Convert.ToInt32(Console.ReadLine());
            A = (3.14) * r * r;

            Console.WriteLine("Area of circle of given Radius is ="+A);
            Console.WriteLine();

        }
    }
}
