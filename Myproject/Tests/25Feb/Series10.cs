using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myproject.TestFeb._25Feb
{
    internal class Series10
    {
        static void Main(string[] args)
        {
            for (int i = 2, j = 1; j <= 10; i += j * 10, j++)
            {
                Console.Write(i + " ");
            }


        }
    }
}
