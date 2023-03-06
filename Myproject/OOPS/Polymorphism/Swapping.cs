using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myproject.OOPS.Polymorphism
{
    internal class Swapping
    { 
        public static void Swap(ref int n1,ref int n2)
        {
            int temp = n1;
            n1 = n2;
            n2 = temp;
            Console.WriteLine("in Method=="+n1+""+n2);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the 1st number");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the 2nd number");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Before swap = "+num1+""+num2);

            Swapping.Swap(ref num1,ref num2);

            Console.WriteLine("After Swapping=" + num1 + "" + num2);


        }
    }
}
