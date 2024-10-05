namespace Employees
{
    class ContractEmployee : BaseEmployee
    {
        private string employeeTask;
        private string employeeDepartment;

        public ContractEmployee
        (
            string employeeID, 
            string employeeName, 
            string employeeAddress, 
            string employeeTask,
            string employeeDepartment
        ) : base(employeeID, employeeName, employeeAddress)
        {
            this.employeeTask = employeeTask;
            this.employeeDepartment = employeeDepartment;
        }

        public void Show()
        {
            base.Show();
            Console.WriteLine("Employee task: " + this.employeeTask);
            Console.WriteLine("Employee department: " + this.employeeDepartment);
        }

        public override double CalculateSalary(int workingHours)
        {
            return 250 + workingHours * 20;
        }

        public override string GetDepartment()
        {
            return this.employeeDepartment;
        }
    }
}
