using Microsoft.AspNetCore.Mvc;
using PlatanoApi.Model;
using System.Linq;
using System;
using Microsoft.Extensions.Logging;

namespace PlatanoApi.WebApi.Controllers
{
    /// CRUD operations on the AutomationCommand database entity
    [Route("api/[controller]")]
    public class AutomationCommandController : ControllerBase
    {
        private ILogger<AutomationCommandController> _logger;
       
        public AutomationCommandController(PlatanoDbContext dal, ILogger<AutomationCommandController> logger)
        {
            this.DAL = dal;
            _logger = logger;
        }

        [HttpGet("{id?}")]
        public IActionResult Get([FromRoute] int? id)
        {
            IActionResult result = NotFound();
            
            if(id == null)
            {
                var items = this.DAL.AutomationCommand.ToArray();
                
                if(items.Length > 0)
                    result = Ok(items);
                else
                    _logger.LogInformation($"Id '{id}' was not found.");
            }
            else
            {
                var item = this.DAL.AutomationCommand.SingleOrDefault(i => i.Id == id);
                
                if(item != null)
                    result = Ok(item);
            }

            return result;
        }

        [HttpPost]
        public IActionResult Add([FromBody] AutomationCommand item)
        {
            this.DAL.AutomationCommand.Add(item);
            this.DAL.SaveChanges();
            return Ok();
        }

        [HttpDelete]
        [Route("{id}")]
        public IActionResult Delete([FromRoute] int id)
        {
            var item = this.DAL.AutomationCommand.SingleOrDefault(i => i.Id == id);

            if(item == null)
            {
                _logger.LogInformation($"Item with Id = '{id}' was not found.");
                return NotFound();
            }
            
            this.DAL.AutomationCommand.Remove(item);
            this.DAL.SaveChanges();
            return Ok();
        }
    }
}