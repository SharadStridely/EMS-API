using EMS.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace EMS.DataService.IData
{
    public interface IDesignationData
    {
        List<Designation> GetAllDesignation();
    }
}
