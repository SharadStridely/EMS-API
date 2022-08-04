using EMS.BuisnessService.IService;
using EMS.Model;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EMS.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentsController : ControllerBase
    {
        private readonly IDepartmentService _DepartmentService;
        public DepartmentsController(IDepartmentService departmentService)
        {
            _DepartmentService = departmentService;
        }

        // GET: api/<DepartmentsController>
        [HttpGet]
        public IEnumerable<Department> Get()
        {
            return _DepartmentService.GetAllDepartment();
        }

    }
}
