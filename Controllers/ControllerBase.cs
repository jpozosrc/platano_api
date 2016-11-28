using Microsoft.AspNetCore.Mvc;
using PlatanoApi.Model;

namespace PlatanoApi
{
    public class ControllerBase : Controller
    {
        public PlatanoDbContext DAL { get; set; }
        public string CurrentOperationInfo 
        { 
            get
            {
                return $"{Request.Method} {Request.Path}";
            } 
        }
    }
}