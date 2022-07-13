using EMS.BuisnessService.IService;
using EMS.DataService.IData;
using EMS.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace EMS.BuisnessService.Service
{
    public class DepartmentService : IDepartmentService
    {
        private readonly IDepartmentData _departmentData;
        public DepartmentService(IDepartmentData departmentData)
        {
            _departmentData = departmentData;
        }
        public List<Department> GetAllDepartment()
        {
            List<Department> departments = new List<Department>();
            departments = _departmentData.GetAllDepartment();
            return departments;
        }
    }
}
