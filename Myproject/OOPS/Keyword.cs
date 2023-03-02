/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myproject.OOPS
{
    internal class Keyword
    {
        
        
            private int id;
            private string name;

            public Keyword(int id, string name)
            {
                // using this to refer to the instance variables
                this.id = id;
                this.name = name;
            }

            public void Display()
            {
                // using this to invoke current class method
                this.Print();
            }

            private void Print()
            {
                Console.WriteLine("Id = {0}, Name = {1}", this.id, this.name);
            }

        static void Main(string[] args)
        {
            Keyword k = new Keyword ();
            k.Display();
            k.Keyword();
        }
        }

    }

*/