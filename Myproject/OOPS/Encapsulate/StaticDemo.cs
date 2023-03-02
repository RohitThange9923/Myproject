using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myproject.OOPS.Encapsulate
{
    internal class StaticDemo
    {
        static int x = 0;
        int num = 20;
        public StaticDemo()
        {
            x++;
            Console.WriteLine(x);
        }

        public static void Calculate()
        {
            Console.WriteLine("ans="+(4*5));
            StaticDemo s = new StaticDemo();
            Console.WriteLine(s.num);
        }
        static void Main(string[] args)
        {
            StaticDemo s1 = new StaticDemo();
            /*StaticDemo s2 = new StaticDemo();
            StaticDemo s3 = new StaticDemo();*/

            // Console.WriteLine(s1,x);

            Console.WriteLine(StaticDemo.x);
            StaticDemo.Calculate();
        }
    } 
}
