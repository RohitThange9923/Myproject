using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myproject.TestFeb._25Feb
{
    internal class Trimorphic
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the Number");
            int num = Convert.ToInt32(Console.ReadLine());

            int cube = num*num*num;

            while (num > 0)
            {

                if (num % 10 != cube % 10)
                    Console.WriteLine("Not trimorphic");
                
                    else
                    Console.WriteLine("trimorphic");

                num /= 10;
                cube /= 10;

                
            }


        }
    }
}



