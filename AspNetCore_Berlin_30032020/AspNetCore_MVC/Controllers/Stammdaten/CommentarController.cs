using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCore_MVC.Controllers.Stammdaten
{
    [Route("Commentar")]
    [Route("Commentar/Index")]
    public class CommentarController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}