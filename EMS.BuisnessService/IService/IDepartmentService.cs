using EMS.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace EMS.BuisnessService.IService
{
    public interface IDepartmentService
    {
        List<Department> GetAllDepartment();
    }
}
