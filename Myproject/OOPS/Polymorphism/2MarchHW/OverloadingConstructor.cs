using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myproject.OOPS.Polymorphism._2MarchHW
{
    internal class OverloadingConstructor
    {
         OverloadingConstructor(int x, float y)
        {
            Console.WriteLine("sub=" + (x - y));
        }

         OverloadingConstructor(int a, int y)
        {
            Console.WriteLine("Addition=" + (a + y));
        }

          OverloadingConstructor(float x, int y)
        {
            Console.WriteLine("Multiplication="+ (x*y));

        }

        OverloadingConstructor(double x, double y)
        {
            Console.WriteLine("Division="+(x/y));
        }

         OverloadingConstructor(int p,string s)
        {
            Console.WriteLine(p+": "+s);
        }
        static void Main(string[] args)
        {
            OverloadingConstructor o = new OverloadingConstructor(3,4);
            OverloadingConstructor o1 = new OverloadingConstructor(5, 5);
            OverloadingConstructor o2 = new OverloadingConstructor(20.2f, 4);
            OverloadingConstructor o3 = new OverloadingConstructor(10.5, 20.5);
            OverloadingConstructor o4 = new OverloadingConstructor(3, "raj");
        }   
    }
}
  