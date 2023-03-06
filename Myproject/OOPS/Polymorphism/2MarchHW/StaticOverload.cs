using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myproject.OOPS.Polymorphism._2MarchHW
{
    internal class StaticOverload
    { 
        static void Calculate(int num1,int num2)
        {
            Console.WriteLine("Addition ="+(num1+num2));
        }

 
         static void Calculate (int num3,int num4,int num5)
        {
            Console.WriteLine("Multiplication="+(num3*num4*num5));
        }

        static void Main(string[] args)
        {
           
            Calculate(10, 5);
             Calculate(2,6,2);

        }
    }

}