using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myproject.Loops.HW23Feb
{
    internal class DtoArev
    {
        static void Main(string[] args)
        {
            for (char i = 'A'; i <='D'; i++)
            {
                for (char j='D'; j >=i; j--)

                {
                    Console.Write(j);  
                }
                Console.WriteLine();
            }
        }
    }
}
