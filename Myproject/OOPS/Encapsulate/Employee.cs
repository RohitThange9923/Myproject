using Myproject.OOPS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myproject.OOPS.Encapsulate
{
    internal class Employee
    {
        int id;
        string name;
        int salary;


        public int Id
        {
            set
            {
                id = value;

            }
            get
            {
                return id;
            }
        }
          
                        public string Name
                    {
                        set
                        {
                            name = value;

                        }
                        get
                        {
                            return name;

                        }
               }


public int Salary

{
    set
    {
        salary = value;

    }
    get
    {
        return salary;
    }
   }
}
class EncapsulatedDemo
{
    static void Main(string[] args)
    {
        Employee emp = new Employee();
        emp.Id = 101;
        emp.Name = "Rohit";
        emp.Salary = 100000;

        Console.WriteLine(emp.Id);
        string ename = emp.Name;
        Console.WriteLine(ename);
        Console.WriteLine(emp.Salary);
    }
 }
}





 
