using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCore_MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCore_MVC.Controllers
{
    public class StammdatenController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Welcome()
        {
            return View();
        }

        public IActionResult Blogs()
        {
            IList<Blog> blogList = new List<Blog>();
            blogList.Add(new Blog
            {
                Id = 1,
                Title = "MVC Einstieg",
                Content = "Irgendeine Infomation",
                CreatedAt = DateTime.Now,
                CreatedBy = "Kevin"
            });

            blogList.Add(new Blog
            {
                Id = 1,
                Title = "Razor View",
                Content = "Razor Einführung mit vielen Seiten",
                CreatedAt = DateTime.Now,
                CreatedBy = "Max"
            });

            return View();
        }
    }
}