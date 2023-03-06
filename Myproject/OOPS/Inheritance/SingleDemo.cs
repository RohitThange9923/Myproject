using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myproject.OOPS.Inheritance
{
    class Cars
        {
            public int wheels = 0;

       } 

        class Audi:Cars
        { 
                public void ShowAudi()
            {
                Console.WriteLine("Audi"+"wheels="+wheels);
            }
        
        }

        class Santro:Cars
        {
            public void showSantro()
            {
                Console.WriteLine("Santro Wheels=" + wheels);

            }
        }

        class HirachicalDemo
        {
           public static void Main(string[] args)
            {
                Audi a = new Audi();
                a.ShowAudi();
                Santro s = new Santro();
                s.showSantro();
            }
        }

    }

