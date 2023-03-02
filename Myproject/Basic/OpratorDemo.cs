using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myproject.Basic
{
    internal class OpratorDemo
    {
        static void Main(string[] args)
        {
           /* int a=2; int b=2;

             int x = a++ - ++b;//Unary Oprator
             Console.WriteLine(x+""+a+""+b);//-1,3,3

             x = --a - --b - a;
             Console.WriteLine(x + "" + a + "" + b);//-2,2,2

             x= a++ - --b + --a;
             Console.WriteLine(x + "" + a + "" + b);//3,2,1

             x = ++b - ++a + a;
             Console.WriteLine(x + "" + a + "" + b);//2,3,2

             x = --a - b-- -b;
             Console.WriteLine(x + "" + a + "" + b);//-1,2,1*/

           
            /*Console.WriteLine(8 + 4 * 2 - 5 / 2);//14//Binary Oprator //Arithmatic +,-,/,*,%

            Console.WriteLine(51%9-(3+4/2));//1

            Console.WriteLine(8*2/4*2+4);//12
            
            Console.WriteLine(6+3*4/2*2);//18*/


           /* //Logical Oprator &&,||,!
            int a = 10;
            int b = 50;
            int c = 89;
            Console.WriteLine((a<b) && (a>c));

            Console.WriteLine((a<b) || (a>c));
*/
            //Assignments

            int x = 10;
            x += 2;
            x -= 3;
            x *=2;
            x /= 4;
            x %=5;
            x %= 6;     
            Console.WriteLine(x);
            Console.ReadLine();
        }
    }
}
