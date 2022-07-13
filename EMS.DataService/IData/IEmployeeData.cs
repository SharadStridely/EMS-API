﻿using EMS.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace EMS.DataService.IData
{
    public interface IEmployeeData
    {
        List<Employee> GetAllEmployee();
        Employee GetById(int id);
        void CreateEmployee(Employee employee);
        void UpdateEmployee(Employee employee);
        void DeleteEmployee(int id);
    }
}
