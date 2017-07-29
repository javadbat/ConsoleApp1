using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        class Employee
        {
            public string Name { get; set; }
        }
        static void Main(string[] args)
        {

            Employee emp = new Employee();
            emp.Name = "Alireza";
            Change(emp);
            Console.WriteLine(emp.Name);

            Console.ReadKey();

        }

        static void Change(Employee employe) {
            employe = new Employee();
            employe.Name = "Javad";
        }
    }
}
