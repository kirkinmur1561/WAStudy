using System;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WAN5CP.Models.Common;
using WAN5CP.Services;

namespace WAN5CP.Controllers.Apis.V1
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class InfoController : Controller
    {
        private LoggerS _logger;
        public InfoController(LoggerS log)
        {
            _logger = log;
        }

        [HttpGet]
        public async Task<ActionResult> GetInfo()
        {
            _logger.Write(HttpContext);
            return Json(new Info(HttpContext.Connection));
        }
            







    }
}