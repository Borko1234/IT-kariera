using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace abstrakciq
{
    public abstract class BaseEmployee
    {
		private string employeeID;

		public string EmployeeID
		{
			get { return employeeID; }
			set { employeeID = value; }
		}
		private string employeeName;

		public string EmployeeName
		{
			get { return employeeName; }
			set { employeeName = value; }
		}
		private string employeeAdress;

		public string EmployeeAdress
		{
			get { return employeeAdress; }
			set { employeeAdress = value; }
		}
		public BaseEmployee(string id,string name,string adress)
		{
			this.employeeID= id;
			this.employeeName = name;
			this.employeeAdress = adress;
		}
        

        public abstract double CalculateSalary(double workingHours);
		public abstract string GetDepartment(string dName);
        public  void Show()
        {
            Console.WriteLine($"Employee ID: {EmployeeID}");
            Console.WriteLine($"Employee Name: {EmployeeName}");
            Console.WriteLine($"Employee Address: {EmployeeAdress}");
        }

    }
}
