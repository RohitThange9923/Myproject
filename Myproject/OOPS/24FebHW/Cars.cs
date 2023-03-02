using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myproject.OOPS
{
    internal class Cars
    {
        int CarModelNo;
        string CarModelName;
        string CarColor;
        int CarPrice;
        static void Main(string[] args)
        {

            Console.WriteLine("CarModelNo  \t CarModelName \t CarColor \t  CarPrice ");
            Cars cars= new Cars();

            cars.CarModelNo=20;
            cars.CarModelName = "BMW";
            cars.CarColor = "White";
            cars.CarPrice = 250000;
            Console.WriteLine("\t"+cars.CarModelNo + " \t " + cars.CarModelName + "\t \t  " + cars.CarColor + "\t  \t"+ cars.CarPrice);
            

            cars.CarModelNo = 121;
            cars.CarModelName = "THAR";
            cars.CarColor = "PINK";
            cars.CarPrice = 150000;
            Console.WriteLine("\t" + cars.CarModelNo + " \t " + cars.CarModelName + "\t \t  " + cars.CarColor + "\t  \t" + cars.CarPrice);
            


            cars.CarModelNo = 25;
            cars.CarModelName = "Ferrari";
            cars.CarColor = "Red";
            cars.CarPrice = 300000;
            Console.WriteLine("\t" + cars.CarModelNo + " \t " + cars.CarModelName + "\t " + cars.CarColor + "\t  \t" + cars.CarPrice);
           

        }
    }
}
