using Myproject.Tests._4March;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myproject.Tests._4March
{
    internal class Hotel
    {
        private    int Hid;
        private string HName;
        private string HLocation;
        private double HRating;
        private bool isOnlineorderAvailable;
        private string SeatingCapacity;
        private string PaymentType;

        public int hid
        {
            set
            {
                Hid = value;
            }
            get
            {
                return Hid;
            }
        }

        public string hName
        {
            set
            {
                HName = value;
            }
            get
            {
                return HName;
            }
        }

        public string hLocation
        {
            set
            {
                HLocation = value;
            }
            get
            {
                return HLocation;
            }
        }

        public double hRating
        {
            set
            {
                HRating = value;
            }
            get
            {
                return HRating;
            }
        }

        public bool IsOnlineorderAvailable
        {
            set
            {
                isOnlineorderAvailable = value;
            }
            get
            {
                return isOnlineorderAvailable;
            }
        }

        public string seatingCapacity
        {
            set
            {
                SeatingCapacity = value;
            }
            get
            {
                return SeatingCapacity;
            }

        }


        public string paymentType
        {
            set
            {
                PaymentType = value;
            }
            get
            {
                return PaymentType;
            }
        }
    }
    class TestHotel
    {
       public static void Main(string[] args)
        {
            Hotel h = new Hotel();
            h.hid = 123;
            h.hName = "5star";
            h.hLocation = "Pune";
            h.hRating = 4.5;
            h.IsOnlineorderAvailable =true;
            h.seatingCapacity = "200";
            h.paymentType = "Online";

            Console.WriteLine(h.hid + " "+h.hName+" " + h.hLocation+" " + +h.hRating + h.IsOnlineorderAvailable + h.seatingCapacity +h.paymentType);
        }
    }

}








