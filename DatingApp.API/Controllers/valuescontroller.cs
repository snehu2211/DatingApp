using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DatingApp.API.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.API.Controllers
{
    // http:localhost:5000/api/values
    [Route("api/[controller]")]
    [ApiController]
    //0 reference
    public class ValuesController : ControllerBase
    {
        private readonly DataContext _context;
        public ValuesController(DataContext context)
        {
            _context = context;

        }
        //GET api/values
        [HttpGet]
        
        public async Task<IActionResult> GetValues()
        {

            var values = await _context.Values.ToListAsync();
            return Ok(values);
        }
        //GET api/values/5
        [HttpGet("{id}")]
        // 0 reference
        public async Task<IActionResult> GetValues(int id)
        {
            var value = await _context.Values.FirstOrDefaultAsync(x => x.Id == id);
            return Ok(value);
        }

        //POST api/values
        [HttpPost]
        //0 reference
        public void Post([FromBody] string value)
        {

        }
        //put api/values/5
        [HttpPut("{id}")]

        public void Put(int id, [FromBody] string value)
        {

        }
        //DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {

        }

    }

}