using Microsoft.AspNetCore.Mvc;
using WAN5CP.Models.Common;

namespace WAN5CP.Controllers.CVs
{
    public class InfoController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {            
            return View(new Info(Request.HttpContext.Connection));
        }
    }
}