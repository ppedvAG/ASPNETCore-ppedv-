using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCore_MVC.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using System.Text.Json;
using System.Text.Json.Serialization;
namespace AspNetCore_MVC.Controllers
{
    public class StateManagementController : Controller
    {
        #region Temp - Data Beispiel
        public IActionResult First()
        {
            TempData["UserId"] = 101;
            return View();
        }

        public IActionResult Second()
        {
            var userId = TempData["UserId"] ?? null;
            return View();
        }

        public IActionResult Third()
        {
            var userId = TempData["UserId"] ?? null;
            return View();
        }
        #endregion


        #region Cookie Beispiel

        public IActionResult AnlegenVonCookies()
        {
            string username = "Tester";
            CookieOptions options = new CookieOptions();
            //Anlegen von Cookies
            Response.Cookies.Append("UserName", username, options);

            return View();
        }

        //Weiteres Beispiel, wie ein Cookie initialisiert wird und mit 
        [HttpPost]
        public IActionResult AnlegenVonCookiesInitialwertAusFormular(IFormCollection form)
        {
            string username = form["userName"].ToString();
            
            CookieOptions options = new CookieOptions();
            //Anlegen von Cookies
            Response.Cookies.Append("UserName2", username, options);
            return View();
        }

        public IActionResult IndexMitLogin()
        {
            string username = Request.Cookies["UserName"];
            return View();
        }

        public IActionResult DeleteCookie()
        {
            Response.Cookies.Delete("Username");
            Response.Cookies.Delete("Username2");

            return View();
        }
        #endregion


        #region Session Management

        public ActionResult SessionInit()
        {

            HttpContext.Session.SetString("Name", "John");
            HttpContext.Session.SetInt32("Age", 32);


            Blog blog = new Blog();
            blog.Title = "Microsoft Developer Magazin wurde eingestellt";
            blog.Content = "Seit November 2019 bringt Microsoft sein Entwicklermagazin nicht mehr heraus";
            blog.CreatedAt = DateTime.Now;
            blog.CreatedBy = "Bill Gates";
            blog.Id = 111;
            //Einlesen  eines komplexen Types aus der Session mithilfe von JSON
            string jsonString = JsonSerializer.Serialize(blog);
            HttpContext.Session.SetString("neuerBlog", jsonString);

            return View();
        }

        public ActionResult SessionRead()
        {
            string Name = HttpContext.Session.GetString("Name");
            int Age = HttpContext.Session.GetInt32("Age").Value;

            //Auslesen eines komplexen Types aus der Session mithilfe von JSON
            string jsonString = HttpContext.Session.GetString("neuerBlog");
            Blog blog = JsonSerializer.Deserialize<Blog>(jsonString);
            return View();
        }

        #endregion

    }
}