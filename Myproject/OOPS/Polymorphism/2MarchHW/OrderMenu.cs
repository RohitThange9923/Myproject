using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myproject.OOPS.Polymorphism._2MarchHW
{
    internal class OrderMenu
    {
        int Oid;
        int Oquantity;
         Menue m;

        public  OrderMenu(int Oid,int Oquantity,Menue m)
        {
            this.Oid = Oid;
            this.Oquantity = Oquantity;
            this.m = m;
        }

        public void Show()
        {
            Console.WriteLine(Oid+""+Oquantity);
            Menue m = new Menue(100,"Idli",25);
            m.ShowMenue();


        }
    }


    class Menue
    {
        int Mid;
        string item;
        int price;

        public Menue(int Mid, string Mitem, int price)
        {
            this.Mid = Mid;
            this.item = Mitem;
            this.price = price;
        }


        public void ShowMenue()
        {
            Console.WriteLine(Mid + " " + item + " " + price + "RS");
        }

        public static void Main(string[] args)
        {
            Menue m = new Menue(101, "dosa", 20);
            OrderMenu oo = new OrderMenu(40,10,m);
            oo.Show();

        }
    }
}
