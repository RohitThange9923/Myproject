using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myproject.OOPS.Encapsulate
{
    internal class StaticDemo1
 
    {
        static int x = 0;
            int num = 20;
            static StaticDemo1()
            {
                
                Console.WriteLine("HELLO");
            }
        public StaticDemo1()
        {
            x++;
            Console.WriteLine("default"+x);
        }

            public static void Calculate()
            {
                Console.WriteLine("ans=" + (4 * 5));
                StaticDemo1 s = new StaticDemo1();
                Console.WriteLine(s.num);
            }
            static void Main(string[] args)
            {
                StaticDemo1 s1 = new StaticDemo1();
                /*StaticDemo s2 = new StaticDemo();
                StaticDemo s3 = new StaticDemo();*/

                // Console.WriteLine(s1,x);

                Console.WriteLine(StaticDemo1.x);
                StaticDemo1.Calculate();
            }
        }
    }

