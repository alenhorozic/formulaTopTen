using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace formulaTopTen.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ComentController : ControllerBase
    {
        // GET: api/<ComentController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<ComentController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ComentController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ComentController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ComentController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
