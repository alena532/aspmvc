using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Party.Models;

namespace Party.Controllers
{
    public class HomeController : Controller
    {
        IRepository rep;
        public HomeController(IRepository rep)
        {
            this.rep = rep;
        }
        public ViewResult Invitation()
        {
            return View();
        }
        [HttpGet]
        public ViewResult RsvpForm()
        {
            return View();
        }
        [HttpPost]
        public ViewResult RsvpForm(GetResponse response)
        {
            if (ModelState.IsValid)
            {
                rep.AddResponse(response);
                return View("Thanks", response);
            }
            return View();
        }
        public ViewResult ListResponses()
        {
            return View(rep.Responses.Where(r => r.WillAttend == true)); 
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
