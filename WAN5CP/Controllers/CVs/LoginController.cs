using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WAN5CP.Models.Views.Login;
using WAN5CP.Services;

namespace WAN5CP.Controllers.CVs
{
    public class LoginController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Enter(LoginPerson lp)
        {           
            if (People.Content(lp)) return RedirectToAction("Index");           
            return BadRequest("LOL!");
        }
    }
}