using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myproject.OOPS.Inheritance
{
    internal class Bike
    {

        //Single Inheritance
        public string model;
        public string color;
        public int price;


        public void PrintCarInformation()
        {
            Console.WriteLine("Model:" + model);
            Console.WriteLine("Color:" + color);
            Console.WriteLine("Price:" + price);

        }


    }

        class Shine:Bike
        {
            int Mileage;

            public void PrintMileage()
            {
                Console.WriteLine("Mileage:" + Mileage);
            }
             static void Main(string[] args)
            {
                Shine s = new Shine();
                s.model = "Honda";
                s.color = "White";
                s.price = 90000;
                s.Mileage = 20;
                s.PrintCarInformation();
                s.PrintMileage();
                Console.ReadLine();
            }
        }
 }

