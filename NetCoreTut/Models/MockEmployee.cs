using System;
using System.Collections.Generic;

namespace NetCoreTut.Models
{
    public class MockEmployee : IEmployeeRepository
    {
        private List<Employee> _employeeList;

        public MockEmployee()
        {
            _employeeList = new List<Employee>()
            {
                new Employee(){Id=1, Name="Ken", Email="ken@gmail.com", Department="BA"},
                new Employee() { Id = 2, Name = "Jake", Email = "Jake@gmail.com", Department = "E-Banking" },
                new Employee() { Id = 3, Name = "Samuel", Email = "Sam@gmail.com", Department = "Digital Lab" }
            };
        }

        public Employee GetEmployee(int Id)
        {
            return _employeeList.Find(e => e.Id == Id);
        }
    }
}
