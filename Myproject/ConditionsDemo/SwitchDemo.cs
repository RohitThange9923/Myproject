using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myproject.ConditionsDemo
{
    internal class SwitchDemo
    {
        static void Main(string[] args)
        {
            /*//switch(express)//int,char,string,boolean,Enum
            {
                case: 
                break;
                case: 
                break;
                case: 
                break;
                default:
                break;
            }*/

            //Take Day number between 1 to 87 from user are display

            /*  Console.WriteLine("Enter the day number between 1 to 7:");
              int num =Convert.ToInt32(Console.ReadLine());

              switch(num)
              {
                  case 1: Console.WriteLine("Mon");
                      break;
                      case 7: Console.WriteLine("Sun");
                      break;
                      case 4: Console.WriteLine("Thru");
                      break;
                      case 3: Console.WriteLine("Wed");
                      break;
                      case 2: Console.WriteLine("Tues");
                      break;
                  case 5: Console.WriteLine("Fri");
                      break;
                      case 6: Console.WriteLine("Sat");
                      break;
                  default: Console.WriteLine("Invalid Day Number:");
                      break;
              } */


            /*//Addition, subtraction ,Multiplication,Division use in Switch Case

            Console.WriteLine("Enter the 1 st number:");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the 2 nd number:");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("+ Addition \t  -Substraction \t * Multipication \t / Division :");
            Console.WriteLine("Pls Enter Valid Oprator from Above Menu:");
            char op =Convert.ToChar(Console.ReadLine());

            switch(op)
            {
                case '+': Console.WriteLine("Addition = "+(num1+num2));
                    break;
                case '-':
                    Console.WriteLine("Substraction = " + (num1 - num2));
                    break;
                case '*':
                    Console.WriteLine("Multiplication = " + (num1 * num2));
                    break;
                case '/':
                    Console.WriteLine("Division = " + (num1 / num2));
                    break;
                default: Console.WriteLine("Invalid Oprator:");
                    break;*/
            /*
                        //Employee city name using swich case

                        Console.WriteLine("Enter the city Name:");
                        string city = Console.ReadLine();   

                        switch(city)
                        {
                            case "Pune": Console.WriteLine("Employee is working at pune location");
                                break;
                            case "Mumbai":Console.WriteLine("Employee is working at Mumbai location");
                                break;
                                default: Console.WriteLine("Employee is working all over the India");
                                break;
                        }*/


            //Check number is divisible by 5 or not

            Console.WriteLine("Enter the number:");
            int num =Convert.ToInt32(Console.ReadLine());

            switch(num%5==0) 
            {
                case true: Console.WriteLine("Divisible by 5");
                    break;

                    case false: Console.WriteLine("Not Divisible by 5");
                    break;

                    
            }
        }

    }
}
