using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TestApi.database;

namespace TestApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class moviController : ControllerBase
    {
        /*private readonly AppTestDbContext _context;
        public moviController(AppTestDbContext context);
        {
        _context = context;
        }*/
        // GET: api/movi
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/movi/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }


        // POST: api/movi
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/movi/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/movi/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
