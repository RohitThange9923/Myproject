using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myproject.TestFeb._25Feb
{
    internal class Divisible5or10
    {
        static void Main(string[] args)
        {
            //1.Write a program to print all numbers between 1 and 100 except
            //the numbers which are divisible by 5or 10

            /* for (int i =1;i<=100;i++)
              {


                if (i % 5 == 0 && i % 10 == 0)
                  {

                      Console.WriteLine(i);
                  }
                  */
            /*10
20
30
40
50
60
70
80
90
100

 */

            /* 2) Predict behaviour of the following code: 
  class Loop
         {
             static void main(String[] args)
             {
                 int b = 0;
                 do
                 {
                     int a = 2;
                     b++;
                     Console.WriteLine(a++);
                 }
                 while (b != 3);
             }*/



            /* int b = 0;
             do
             {
                 int a = 2;
                 b++;
                 Console.WriteLine(a++);
             }
             while (b != 3);
         }
     }


     }*/

            /*  2
                2
                2
            */


           /* 3)Predict the output of following: 
            int i = 1; k = 1;
            while (i++ <= 5)
            {
                k *= i;
            }
            Console.WriteLine(“k =”+k +”i =”+i);*/

            int i = 1;int k = 1;
            while (i++ <= 5)
            {
                k *= i;
            }
            Console.WriteLine("k ="+ k + "i=" + i);


          //o/p:  //k =720i=7

        }
    }
}







