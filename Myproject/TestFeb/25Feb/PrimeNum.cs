using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myproject.TestFeb._25Feb
{
    internal class PrimeNum
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two numbers to check for twin primes:");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            if (IsPrime(num1) && IsPrime(num2) && Math.Abs(num1 - num2) == 2)
                Console.WriteLine("The two numbers are twin primes!");
            else
                Console.WriteLine("The two numbers are not twin primes.");
        }
        
        static bool IsPrime(int n)
        {
            
            if (n <= 1)
                return false;

            
            for (int i = 2; i < n; i++)
                if (n % i == 0)
                    return false;

            return true;
        }
    }
    
}
