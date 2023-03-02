using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myproject.OOPS
{
    internal class Student
    {
        int id;
        string name;
        int m1, m2,m3;
        int per;

        public void Accept(int sid,string sname,int mk1,int mk2,int mk3)
        {
            id= sid;
            name = sname;
            m1= mk1;
            m2= mk2;
            m3= mk3;

        }

        public void CalculatePercentage()
        {
            per = ((m1 + m2 + m3 ) * 100) / 300;
        }

        public void Display()
        {
            Console.WriteLine("id\t Name\t m1\t m2\t m3\t Percentage");
            Console.WriteLine(id + " \t" + name + "\t " + m1 + "\t" + m2 + " \t" + m3 + " \t" + per);

        
        }
        static void Main(string[] args)
        {
                Student s = new Student();
            s.Accept(1, "Raj", 56, 78, 89);
            s.CalculatePercentage();
            s.Display();
        }
    }
}
