using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;

namespace TimeDisplay.Controllers
{
    public class TimeDisplayController : Controller
    {
        [HttpGet]
        [Route ("")]
        public IActionResult Index ()
        {
            return View();
        }
    }
        
}