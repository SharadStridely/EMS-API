using EMS.DataService.IData;
using EMS.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace EMS.DataService.Data
{
    public partial class DesignationData : IDesignationData
    {
        public List<Designation> GetAllDesignation()
        {
            List<Designation> designations = new List<Designation>();
            designations = DBGetAllDesignation();
            return designations;
        }
    }
}
