using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Julio.Model;

namespace Julio.WebApi.Controllers
{
    [Route("api/[controller]")]
    public class FetchCommandController : Controller
    {
        [HttpGet]
        public HomeAutomationCommand Get()
        {
            var cmd = new HomeAutomationCommand();
            cmd.TimeStamp = DateTime.Now;
            cmd.UserName = "jpozo";
            cmd.Command = "TOGGLE-GARAGE-DOOR";
            return cmd;
        }
    }
}