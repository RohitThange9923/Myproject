using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Myproject.Tests._4March
{
    internal class Order
    {
        private int OrderId;
        private string City;
        private string CustName;
        private string IsDelivered;

        public int orderId
        {
            set
            {
                OrderId = value;
            }
            get
            {
                return OrderId;
            }
        }

        public string city
        {
            set
            {
                City = value;
            }
            get
            {
                return City;
            }
        }

        public string custName
        {
            set
            {
                CustName = value;
            }
            get
            {
                return CustName;
            }
        }

        public string isDelivered
        {
            set
            {
                IsDelivered = value;
            }
            get
            {
                return IsDelivered;
            }
        }
    }

        class TestOrder
        {
            static void Main(string[] args)
            {
                Order o = new Order();
                o.orderId = 101;
                o.city = "Pune";
                o.custName = "Raj";
                o.isDelivered = "Yes";
                Console.WriteLine(o.orderId + " " + o.city + " " + o.custName + " " + o.isDelivered);

            }
        }

    
}

