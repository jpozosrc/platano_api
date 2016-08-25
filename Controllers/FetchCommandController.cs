using System;
using Microsoft.AspNetCore.Mvc;
using PlatanoApi.Model;

namespace PlatanoApi.WebApi.Controllers
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
            cmd.DeviceId = Guid.NewGuid();
            cmd.Command = AutomationCommandEnum.GarageDoor;
            cmd.CommandArgs = "action=open";
            return cmd;
        }
    }
}