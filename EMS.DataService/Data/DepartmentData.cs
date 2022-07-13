using EMS.DataService.IData;
using EMS.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace EMS.DataService.Data
{
    public partial class DepartmentData : IDepartmentData
    {
        public List<Department> GetAllDepartment()
        {
            List<Department> departments = new List<Department>();
            departments = DBGetAllDepartment();
            return departments;
        }
    }
}
