using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Myproject.OOPS
{
    internal class Product
    {
         string Name;
        double Price;
        int Quantity;
        int Bill;
        public void DisplayProductDetails()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Price: {Price}");
            Console.WriteLine($"Quantity: {Quantity}");
        }


        public void CalculateTotalBill()
        {
           
            {
                if (Quantity > 0)
                {
                    // Calculate the total bill
                    double total = Quantity * Price;
                }
                else
                {
                    // Display an error message
                    Console.WriteLine("Error: Quantity must be greater than zero!");
                }
            }
        }

        static void Main(string[] args)
        {
            Product product = new Product();
            product.Name = "Laptop";
            product.Price = 1000.00;
            product.Quantity = 5;

            Product p = new Product();

            p.Name = "TV";
            p.Price = 20000.00;
            p.Quantity = 2;
           /* p.DisplayProductDetails();
            product.DisplayProductDetails();*/
            p.CalculateTotalBill();
            product.CalculateTotalBill();
        }
    } 
}
    


