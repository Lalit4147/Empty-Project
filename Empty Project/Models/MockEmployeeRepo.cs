using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks; 




namespace Empty_Project.Models
{
    public class MockEmployeeRepo : EmployeeRepo
    {
        private List<Employee> _employeeslist;

        public MockEmployeeRepo()
        {
            _employeeslist = new List<Employee>();
            {
                new Employee() { id = 1, name = "lalit", Email = "lalit@123", Department = "CS" };
                new Employee() { id = 2, name = "Rajesh", Email = "rajesh@123", Department = "Civil" }; 
                new Employee() { id = 3, name = "Pradeep", Email = "pradeep@123", Department = "Electrical" };
                new Employee() { id = 4, name = "Mastan", Email = "mastan@123", Department = "CS'" };
            };
        }
        public Employee GetEmployee(int id)
        {
            return _employeeslist.FirstOrDefault(e => e.id == id);
        }
    }
}
