using Microsoft.AspNetCore.Mvc;
using WAStudy.Models.m2;

namespace WAStudy.Controller
{
    public class ConciergeController : Microsoft.AspNetCore.Mvc.Controller
    {
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(SignIn signIn)
        {
            string val;
            if (HttpContext.Request.Cookies.TryGetValue("Concierge", out val))
            {
                
            }
            return Ok();
        }
    }
}