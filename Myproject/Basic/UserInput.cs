using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myproject.Basic
{
    internal class UserInput
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the cityname");
            string str=Console.ReadLine();
            
            Console.WriteLine(str);

            Console.WriteLine("Enter the number");
            /*int num=int.Parse(Console.ReadLine());
            Console.WriteLine(num + "" + num * 4);*/

            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(num);


            Console.WriteLine("Enter the Grade");
            char ch = Convert.ToChar(Console.ReadLine());   
            Console.WriteLine(" Grade"+ch);

        }
    }
}
