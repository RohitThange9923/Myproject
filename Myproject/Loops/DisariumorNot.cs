using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myproject.Loops
{
    internal class DisariumorNot
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int num = int.Parse(Console.ReadLine());
            int temp = num;
            int count = 0;

            while (num > 0)
            {
                count++;
                num = num / 10;
            }
            Console.WriteLine(count);

            num = temp ;
            int sum = 0;
            while (num > 0)
            {
                int digit = num % 10;
                int power = 1;

                for(int i=1;i<=count;i++)
                {
                    power = power * digit;
                   
                }
                sum = sum + power;
                count--;
                num = num / 10;
            }
            Console.WriteLine(sum);

            if(temp == sum)
            {
                Console.WriteLine("Disarium");
            }
            else
            {
                Console.WriteLine("not");
            }
        }
    }
}
