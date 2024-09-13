using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstrakciq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContractEmployee emp = new ContractEmployee("123","georgi","dunav 13","sekretar","smetki");
            Console.WriteLine(emp.Show());
            double salary = emp.CalculateSalary(40);
            Console.WriteLine($" Salary is: {salary}");
            Console.WriteLine(" "+emp.EmployeeDepartment);
        }
    }
}
