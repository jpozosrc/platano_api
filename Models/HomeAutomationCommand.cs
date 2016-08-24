using System;

namespace Julio.Model
{
    public class HomeAutomationCommand
    {
        public DateTime TimeStamp { get; set; }
        public string UserName { get; set; }
        public string Command { get; set; }
    }
}