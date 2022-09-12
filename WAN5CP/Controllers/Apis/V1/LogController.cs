using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WAN5CP.Models.Services;
using WAN5CP.Services;

namespace WAN5CP.Controllers.Apis.V1
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class LogController : Controller
    {
        [HttpGet]
        public async Task<ActionResult<IEnumerable<LoggerS>>> Get() =>
            RAM_LoggerS.GetLogs().ToList();

    }
}