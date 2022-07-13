using EMS.BuisnessService.IService;
using EMS.DataService.IData;
using EMS.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace EMS.BuisnessService.Service
{
    public class DesignationService : IDesignationService
    {
        private readonly IDesignationData _designationData;
        public DesignationService(IDesignationData designationData)
        {
            _designationData = designationData;
        }

        public List<Designation> GetAllDesignation()
        {
            List<Designation> designations= new List<Designation>();
            designations = _designationData.GetAllDesignation();
            return designations;
        }
    }
}
