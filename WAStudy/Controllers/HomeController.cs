using System.Linq;
using Microsoft.AspNetCore.Mvc;
using WAStudy.Models.m1;

namespace WAStudy.Controller
{
    public class HomeController : Microsoft.AspNetCore.Mvc.Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.m1 = Request.Host.Port;
            return View("NewIndex");
        }
    
        [HttpGet]
        public ViewResult Form()
        {
            return View();
        }

        [HttpPost]
        public ViewResult Form(GuestResponse gr)
        {
            CollectionGR.AddResponse(gr);
            return View("Fin", gr);
        }

        public ViewResult List() => View(CollectionGR.GuestResponses.Where(w => w.WillAttend == true));


    }
}