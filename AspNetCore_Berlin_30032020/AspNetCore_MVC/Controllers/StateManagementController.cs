using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

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
            return View();
        }

        public ActionResult SessionRead()
        {
            //var user = new User()
            //{
            //};

            string Name = HttpContext.Session.GetString("Name");
            int Age = HttpContext.Session.GetInt32("Age").Value;
            return View();
        }

        #endregion

    }
}