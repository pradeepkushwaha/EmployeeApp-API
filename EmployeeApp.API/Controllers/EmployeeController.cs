using AutoMapper;
using EmployeeApp.API.Data;
using EmployeeApp.API.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EmployeeApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeRepository _repo;
        private readonly IMapper _mapper;
        public EmployeeController(IEmployeeRepository repo, IMapper mapper)
        {
            _mapper = mapper;
            _repo = repo;
        }
        // GET: api/<EmployeeController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var employees = await _repo.GetEmployees();

            var employeesToReturn = _mapper.Map<IEnumerable<EmployeeForListEntity>>(employees);

            return Ok(employeesToReturn);


        }

        // GET api/<EmployeeController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var employee = await _repo.GetEmployee(id);

            var employeeToReturn = _mapper.Map<EmployeeForDetailedEntity>(employee);

            return Ok(employeeToReturn);
        }
        [HttpGet("search")]
        [Route("Search/{name}")]
        public async Task<IActionResult> GetSearch(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
               return new NoContentResult();

            var employee = await _repo.GetEmployee(name);

            var employeeToReturn = _mapper.Map<IEnumerable<EmployeeForListEntity>>(employee);

            if (employeeToReturn.ToList().Count == 0)
                return NotFound();
            return Ok(employeeToReturn);
        }
        [HttpPost("SearchEmployee")]
        public async Task<IActionResult> SearchEmployee(EmployeeForSearch employeeForSearch)
        {
            var employee = await _repo.GetEmployee(employeeForSearch.FromDate, employeeForSearch.ToDate, employeeForSearch.username);

            var employeeToReturn = _mapper.Map<IEnumerable<EmployeeForListEntity>>(employee);

            if (employeeToReturn.ToList().Count == 0)
                return NotFound();
            return Ok(employeeToReturn);
        }
         
        // POST api/<EmployeeController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<EmployeeController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<EmployeeController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
