using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCore_MVC.Data;
using AspNetCore_MVC.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCore_MVC.Controllers
{
    public class PartialViewSamplesController : Controller
    {
        private readonly BlogDbContext _context;

        public PartialViewSamplesController(BlogDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult RenderPartialSample()
        {
            return View();
        }

        public IActionResult PartialSample()
        {
            return View();
        }

        //public IActionResult OnGetPartial() =>
        //    Partial("_AuthorPartialRP");


        public IActionResult LoadPartialOverGetMethod()
        {
            return View();
        }

        [HttpGet]
        public IActionResult OnGetAddress()
        {
            return new PartialViewResult
            {
                ViewName = "_Address",
                ViewData = ViewData,
            };
        }

        [HttpGet]
        public IActionResult OnGetMyPartial() =>
            new PartialViewResult
            {
                ViewName = "_Address",
                ViewData = ViewData,
            };

        public IActionResult ShowPartialWithViewModel()
        {
            BlogCommentVM vm = new BlogCommentVM();
            vm.Blogs = _context.Blog.ToList();
            vm.Comments = _context.Comment.ToList();

            return View(vm);
        }

        public IActionResult PartialViewWithViewDataDirectory()
        {
            
            return View();
        }
    }
}