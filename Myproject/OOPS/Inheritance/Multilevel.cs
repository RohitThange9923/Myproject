using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myproject.OOPS.Inheritance
{
    internal class Car
    { 
            protected string model;
            protected string color;
            protected int price;

            protected void PrintCarInformation()
            {
                Console.WriteLine("Model:" + model);
                Console.WriteLine("Color:" + color);
                Console.WriteLine("Price:" + price);
            }
        }
        class Ferrari : Car
        {
            public int speed;
            public void PrintSpeed()
            {
                Console.WriteLine("Speed:" + speed);
            }

        }
        class Maruti : Ferrari
        {
            float mileage;
            void PrintMileage()
            {
                Console.WriteLine("Mileage" + mileage);

            }

            public static void Main(string[] args)
            {
                Maruti myCar = new Maruti();
                myCar.model = "Alto";
                myCar.color = "red";
                myCar.price = 200000;
                myCar.mileage = 22.5f;
                myCar.speed = 100;
                myCar.PrintCarInformation();
                myCar.PrintMileage();
                myCar.PrintSpeed();
                Console.ReadLine();

            }
        }
}
  

