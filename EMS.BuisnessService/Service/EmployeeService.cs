using EMS.BuisnessService.IService;
using EMS.DataService.IData;
using EMS.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace EMS.BuisnessService.Service
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeData _EmployeeData;
        public EmployeeService(IEmployeeData employeeData)
        {
            _EmployeeData = employeeData;
        }
        public void CreateEmployee(Employee employee)
        {
            _EmployeeData.CreateEmployee(employee);
        }

        public void DeleteEmployee(int id)
        {
            _EmployeeData.DeleteEmployee(id);
        }

        public List<Employee> GetAllEmployee()
        {
            List<Employee> employees = null;
            employees = _EmployeeData.GetAllEmployee();
            return employees;
        }

        public Employee GetById(int id)
        {
            Employee employee = null;
            employee = _EmployeeData.GetById(id);
            return employee;
        }

        public void UpdateEmployee(Employee employee)
        {
            _EmployeeData.UpdateEmployee(employee);
        }
    }
}
