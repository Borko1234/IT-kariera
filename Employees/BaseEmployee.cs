namespace Employees
{
    public abstract class BaseEmployee
    {
        private string employeeID;
        private string employeeName;
        private string employeeAddress;

        public BaseEmployee
        (
            string employeeID, 
            string employeeName, 
            string employeeAddress
        )
        {
            this.employeeID = employeeID;
            this.employeeName = employeeName;
            this.employeeAddress = employeeAddress;
        }

        public void Show()
        {
            Console.WriteLine("EmployeeID: " + employeeID);
            Console.WriteLine("EmployeeName: " + employeeName);
            Console.WriteLine("EmployeeAddress: " + employeeAddress);
        }

        public abstract double CalculateSalary(int workingHours);
        public abstract string GetDepartment();

    }
}
