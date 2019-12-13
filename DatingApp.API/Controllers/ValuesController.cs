using System.Collections.Generic;
using System.Linq;
using DatingApp.API.Data;
using Microsoft.AspNetCore.Mvc;

namespace DatingApp.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ValuesController : ControllerBase
    {

        private readonly DataContext _context;

        public ValuesController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetValues()
        {
            var values = _context.Values.ToList();
            return Ok(values);
        }

        [HttpGet("{id}")]
        public IActionResult GetValue(int id)
        {
            var value = _context.Values.FirstOrDefault(x => x.Id == id);
            return Ok(value);
        }
    }
}