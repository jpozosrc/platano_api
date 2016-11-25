using Microsoft.AspNetCore.Mvc;
using PlatanoApi.Model;
using System.Linq;
using System;

namespace PlatanoApi.WebApi.Controllers
{
    [Route("api/[controller]")]
    public class AutomationCommandController : Controller
    {
        private PlatanoDbContext _context;
        public AutomationCommandController(PlatanoDbContext context)
        {
            // TODO: abstract this with a repository pattern
            _context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_context.AutomationCommand.ToArray());
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        [HttpPost]
        public IActionResult Add([FromBody] AutomationCommand cmd)
        {
            _context.AutomationCommand.Add(cmd);
            _context.SaveChanges();
            return Ok();
        }

        [HttpDelete]
        [Route("{id}")]
        public IActionResult Delete([FromRoute] int id)
        {
            var cmd = _context.AutomationCommand.Where(i => i.Id == id).Single();
            _context.AutomationCommand.Remove(cmd);
            _context.SaveChanges();
            return Ok();
        }
    }
}