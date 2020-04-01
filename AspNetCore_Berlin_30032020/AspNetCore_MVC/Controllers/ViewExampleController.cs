using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCore_MVC.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace AspNetCore_MVC.Controllers
{
    public class ViewExampleController : Controller
    {
        private readonly BlogDbContext _context;
        public ViewExampleController(BlogDbContext context)
        {
            _context = context;
        }

        public IActionResult Index ()
        {
            return View();
        }

        public IActionResult DynamicModelView()
        {
            ViewBag.Message = "Hello World";
            dynamic myDynamicModel = new ExpandoObject();
            myDynamicModel.Blogs = _context.Blog.ToList();
            myDynamicModel.Comments = _context.Comment.ToList();

            return View(myDynamicModel);
        }
    }
}