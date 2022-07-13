using EMS.BuisnessService.IService;
using EMS.Model;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EMS.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DesignationsController : ControllerBase
    {
        private readonly IDesignationService _DesignationService;
        public DesignationsController(IDesignationService designationService)
        {
            _DesignationService = designationService;
        }

        // GET: api/<DesignationsController>
        [HttpGet]
        public IEnumerable<Designation> Get()
        {
            return _DesignationService.GetAllDesignation();
        }

        // GET api/<DesignationsController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<DesignationsController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<DesignationsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<DesignationsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
