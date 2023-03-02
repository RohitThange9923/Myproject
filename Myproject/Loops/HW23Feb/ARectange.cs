using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myproject.Loops.HW23Feb
{
    internal class ARectange
    {
        static void Main(string[] args)
        {
            for (char i = 'D'; i >= 'A'; i--)
            {
                for (char j = 'A'; j <= 'D'; j++)

                {
                    if (i == 'A' || j == 'D' || (i!=j  && i!='C' || j !='B'))
                    
                        Console.Write(j);
                    else
                            Console.Write(" ");
                    
                }
                Console.Write(" ");
                Console.WriteLine();
            }
        }
    }
}
