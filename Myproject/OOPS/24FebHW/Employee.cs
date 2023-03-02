using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myproject.OOPS
{
    internal class Employee
    {
        int id;
            string name;
        int salary;

        

        static void Main(string[] args)
        {

            Console.WriteLine("Employee id \t Employee name \t Employee salary \t");
            Employee Emp;
            Emp = new Employee();
            Emp.id = 1;
            Emp.name = "Rahul";
            Emp.salary = 15000 ;
            Console.WriteLine(" \t "+Emp.id + " \t  "+Emp.name + " \t  "+Emp.salary );
            Emp.id = 2;
            Emp.name = "Akshay";
            Emp.salary = 25000;
            Console.WriteLine(" \t " + Emp.id + " \t  " + Emp.name + " \t  " + Emp.salary);
            Emp.id = 3;
            Emp.name = "Sanket";
            Emp.salary = 35000;
            Console.WriteLine(" \t " + Emp.id + " \t  " + Emp.name + " \t  " + Emp.salary);
            Emp.name = "Aniket";
            Emp.salary = 25000;

            Console.WriteLine(" \t " + Emp.id + " \t  " + Emp.name + " \t  " + Emp.salary);
            Console.ReadLine();
        }
    }
}
