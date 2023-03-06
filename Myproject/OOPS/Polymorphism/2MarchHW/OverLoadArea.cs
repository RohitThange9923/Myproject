using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myproject.OOPS.Polymorphism
{
    internal class OverLoadArea
    {
        public void Area(int length,int breadth)
        {
            Console.WriteLine("Area of Rectangle="+(length*breadth));
        }
         
        public void Area(float pi,int radius)
        {
            Console.WriteLine("AreaofCircle=" + (pi * radius * radius));
        }

        public void Area(int s)
        {
            Console.WriteLine("Area of Square="+(s*s));

        }

        public void Area(int b1,float h)
        {
            Console.WriteLine("Areaof Triangle="+ ( b1 * h));
        }
       public static void Main(string[] args)
        {
            OverLoadArea oa = new OverLoadArea();
            oa.Area(2,3);
            oa.Area(3.14f,3);
            oa.Area(5);
            oa.Area(11,2.4f);
            


        }
    }
}
