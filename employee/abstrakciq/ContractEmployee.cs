using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstrakciq
{
    public class ContractEmployee:BaseEmployee
    {
        private string employeeTask;

        public string EmployeeTask
        {
            get { return employeeTask; }
            set { employeeTask = value; }
        }
        private string employeeDepartment;

        public string EmployeeDepartment
        {
            get { return employeeDepartment; }
            set { employeeDepartment = value; }
        }

        public ContractEmployee(string id, string name, string adress,string employeeTask,string employeeDepartment) : base(id, name, adress)
        {
            this.EmployeeTask = employeeTask;
            this.EmployeeDepartment = employeeDepartment;
        }
        public override double CalculateSalary(double workingHours)
        {

            return 250 + workingHours * 10.80;
        }

        public override string GetDepartment(string dName)
        {
            return EmployeeDepartment;
        }
        
    }
}
