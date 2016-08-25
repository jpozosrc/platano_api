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
        public void Add()
        {
            //TODO: pass this value
            var cmd = new AutomationCommand();
            cmd.TimeStamp = DateTime.Now;
            cmd.UserName = "jpozo";
            cmd.DeviceId = Guid.NewGuid();
            cmd.CommandText = "GARAGE-DOOR";
            cmd.CommandArgs = "action=open";

            _context.AutomationCommand.Add(cmd);
            _context.SaveChanges();
        }
    }
}