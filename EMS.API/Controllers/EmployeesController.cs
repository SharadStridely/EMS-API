using EMS.BuisnessService.IService;
using EMS.Model;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EMS.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly IEmployeeService _EmployeeService;     
        public EmployeesController(IEmployeeService EmployeeService)
        {
            this._EmployeeService = EmployeeService;
        }

        // GET: api/<EmployeesController>
        [HttpGet]
        public async Task<IEnumerable<Employee>> Get()
        {
            return _EmployeeService.GetAllEmployee();
        }

        // GET api/<EmployeesController>/5
        [HttpGet("{id}")]
        public Employee Get(int id)
        {
            return _EmployeeService.GetById(id);
        }

        // POST api/<EmployeesController>
        [HttpPost]
        public void Post(Employee employee)
        {
            _EmployeeService.CreateEmployee(employee);
        }

        // PUT api/<EmployeesController>/5
        [HttpPut("{id}")]
        public void Put(int id,Employee employee)
        {
            _EmployeeService.UpdateEmployee(employee);
        }

        // DELETE api/<EmployeesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _EmployeeService.DeleteEmployee(id);
        }
    }
}
