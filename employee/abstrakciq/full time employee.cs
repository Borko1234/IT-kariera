using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstrakciq
{
    internal class FullTimeEmployee : BaseEmployee
    {
        private string employeePosition;

        public string EmployeePosition
        {
            get { return employeePosition; }
            set { employeePosition = value; }
        }
        private string employeeDepartment;

        public  string EmployeeDepartment
        {
            get { return employeeDepartment; }
            set { employeeDepartment = value; }
        }


        public FullTimeEmployee(string id, string name, string adress,string employeePosition,string employeeDepartment) : base(id, name, adress)
        {
            this.EmployeePosition = employeePosition;
            this.EmployeeDepartment = employeeDepartment;
        }
        
        public override double CalculateSalary(double workingHours)
        {

            return 250 + workingHours * 10.80;
        }

        public override void Show()
        {
            base.Show();
            Console.WriteLine($"Employee Position: {EmployeePosition}");
            Console.WriteLine($"Employee Department: {EmployeeDepartment}");
        }

        public override string GetDepartment(string dName)
        {
            Console.WriteLine(EmployeeDepartment);
        }
    }
}
