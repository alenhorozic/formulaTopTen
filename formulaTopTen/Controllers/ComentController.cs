using formulaTopTen.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace formulaTopTen.Controllers
{
    [Route("api/[controller]")]
    [EnableCors("MyPolicy")]
    [ApiController]
    public class ComentController : ControllerBase
    {
        private readonly ApplikationDbContext _dbContext;
        private readonly IMemoryCache _memoryCache;

        public ComentController(ApplikationDbContext dbContext, IMemoryCache memoryCache)
        {
            _dbContext = dbContext;                     // dependecy injection  
            _memoryCache = memoryCache;                 // dependecy injection
        }

        // GET: api/<ComentController>
        [HttpGet("{id}")]
        public IEnumerable<Coment> Get(int id)
        {
            var cacheKey = $"Get_All_Drivers-";                                    // memoryCache

            if (_memoryCache.TryGetValue(cacheKey, out string cachedValue))
                return (IEnumerable<Coment>)Ok(cachedValue);

            try                                                                      // exception
            {
                var coments = _dbContext.coment.Where(x => x.driverId == id).ToArray();

                _memoryCache.Set(cacheKey, coments);

                return coments;
            }

            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }

        // GET api/<ComentController>/5
        //[HttpGet("{id}")]
        //public Coment Get(int id)
        //{
        //    using (var context = new ApplikationDbContext())
        //    {
        //        var coment = context.coment.Find(id);

        //        return coment;
        //    }
        //}

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
