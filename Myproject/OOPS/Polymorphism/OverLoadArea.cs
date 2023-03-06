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
         
        public void Area(int radius)
        {
            Console.WriteLine("AreaofCircle=" + (3.14) * radius * radius);
        }

        public void Area(double side)
        {
            Console.WriteLine("Area of Square="+(side*side));

        }

        public void Area(int b1,double h)
        {
            Console.WriteLine("Areaof Triangle="+ ((1 / 2)* h * b1));
        }
       public static void Main(string[] args)
        {
            OverLoadArea oa = new OverLoadArea();
            oa.Area(2,3);
            oa.Area(3);
            oa.Area(2);
            oa.Area(4,8);
            


        }
    }
}
