using System;

namespace PlatanoApi.Model
{
    public class HomeAutomationCommand
    {
        public DateTime TimeStamp { get; set; }
        public string UserName { get; set; }
        public Guid DeviceId { get; set; }
        public AutomationCommandEnum Command { get; set; }

        public string CommandArgs { get; set; }
    }
}