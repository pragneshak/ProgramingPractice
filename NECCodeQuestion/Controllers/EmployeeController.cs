using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NECCodeQuestion.Model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace NECCodeQuestion.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        // ✅ Approach 1: Explicitly return 200 OK with Ok(object)
        [HttpGet("GetWithOk/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(EmpDetails))]
        public IActionResult GetEmployee(int id)
        {
            var empDetails = new EmpDetails { Id = id, Name = "John Doe", Position = "Software Engineer" };
            return Ok(empDetails);  // Explicitly returns 200 OK
        }

        // ✅ Approach 2: Implicitly return 200 OK with ActionResult<T>
        [HttpGet("GetWithActionResult/{id}")]
        [ProducesResponseType(typeof(EmpDetails), StatusCodes.Status200OK)]
        public ActionResult<EmpDetails> GetEmployeeDetails(int id)
        {
            var empDetails = new EmpDetails { Id = id, Name = "Jane Doe", Position = "Tech Lead" };
            return empDetails;  // Implicitly returns 200 OK
        }
    }
}

