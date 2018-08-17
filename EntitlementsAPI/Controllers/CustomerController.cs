using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
//using entitlements.domain;
using EntitlementsAPI.Models;

namespace EntitlementsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : Controller
    {

        [HttpGet("all")]
        public IActionResult GetAll()
        {
            var data = MockDataStore.Current;
            return new JsonResult(data); 
        }

        [HttpGet("{id}")]
        public IActionResult GetCustomer(int id)
        {
            return new JsonResult(
                MockDataStore.Current.CustomerDtos.FirstOrDefault(c => c.Id == id)
                );
        }

        [HttpPost]
        public IActionResult CreateCustomer([FromBody] CustomerForCreationDto customer)
        {
            if (customer == null)
            {
                return BadRequest();
            }

            return Ok();

        }
    }
}