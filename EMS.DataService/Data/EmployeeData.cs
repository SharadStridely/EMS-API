using EMS.DataService.IData;
using EMS.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace EMS.DataService.Data
{
    public partial class EmployeeData : IEmployeeData
    {
        public void CreateEmployee(Employee employee)
        {
            DBCreateEmployee(employee);
        }

        public void DeleteEmployee(int id)
        {
            DBDeleteEmployee(id);
        }

        public List<Employee> GetAllEmployee()
        {
            List<Employee> employees = null;
            employees = DBGetAllEmployee();
            return employees;
        }

        public Employee GetById(int id)
        {
            Employee employee = null;
            employee = DBGetById(id);
            return employee;
        }

        public void UpdateEmployee(Employee employee)
        {
            DBUpdateEmployee(employee);
        }
    }
}
