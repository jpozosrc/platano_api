using System;
using Microsoft.AspNetCore.Mvc;
using PlatanoApi.Model;
using System.Linq;

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
        public AutomationCommand GetNextCommand()
        {
            var result = _context.AutomationCommand.First();
            return result;
        }

        [HttpPost]
        public void Add([FromBody] AutomationCommand cmd)
        {
            _context.AutomationCommand.Add(cmd);
            _context.SaveChanges();
        }
    }
}