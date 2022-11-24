namespace EmployeeManagement.Models
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        private List<Employee> _employeeList;
        public MockEmployeeRepository()
        {
            _employeeList = new List<Employee>()
            {
                new Employee() { Id = 1, Name = "Lalit", Department = "CS", email = "Lal@techxotica.com"}, 
                new Employee() { Id = 2, Name = "Rajesh", Department = "Electrical", email = "Raj@techxotica.com" },
                new Employee() { Id = 3, Name = "Pradeep", Department = "Civil", email = "Pra@techxotica.com" },
                new Employee() { Id = 4, Name = "Mastan", Department = "IT", email = "Mas@techxotica.com" }
             };
        }
        public Employee GetEmployee(int Id)
        {
            return _employeeList.FirstOrDefault(e => e.Id == Id);
        }
    }
}