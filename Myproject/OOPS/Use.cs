using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myproject.OOPS
{
    internal class Use
    {
        public Use() : this(20)
        {
            Console.WriteLine("Default.....");

        }

        public Use(int x)
        {
            Console.WriteLine("x=" + x);
        }

    }
    class Keyword
    {
        static void Main(string[] args)
        {
            //Use u = new Use();
            /*Use2 u2 = new Use2();
            u2.Read();
            u2.Show();*/

            Use1 u1 = new Use1();
            u1.Input(245);



        }
    }


    class Use1
    {
        int num;
        public void Input(int num)
        {
            this.num = num;
        }

        public void Display()
        {
            Console.WriteLine(num);
        }
    }


    class Use2
    {
        public void Read()
        {
            //Show();
            Console.WriteLine("What i can read");
            //this.Show();

        }

        public void Show()
        {
            Read();
            Console.WriteLine("pls read DotNet");

        }
    }
}


        
    


