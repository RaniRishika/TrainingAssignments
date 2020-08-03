using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APIDemo2.Models;
using APIDemo2.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIDemo2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        EmployeeRepository repository = new EmployeeRepository();
        [HttpGet]
        [Route("GetAll")]
        public IActionResult GetAll()
        {
            return Ok(repository.GetAll());
        }
        [HttpGet]
        [Route("GetById/{id}")]
        public IActionResult Get(string eid)
        {
            return Ok(repository.GetById(eid));
        }
        [HttpPost]
        [Route("Add")]
        public IActionResult Add(Employee employee)
        {
            repository.Add(employee);
            return Ok();
        }
        [HttpPatch]
        [Route("Update")]
        public IActionResult Update(Employee employee)
        {
            repository.Update(employee);
            return Ok();
        }
        [HttpDelete]
        [Route("Delete/{id}")]
        public IActionResult Delete(string eid)
        {
            repository.Delete(eid);
            return Ok("Record Deleted");
        }

    }
}