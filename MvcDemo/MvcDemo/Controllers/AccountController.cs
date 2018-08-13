using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcDemo.Controllers
{
    public class AccountController : Controller
    {
        //
        // GET: /Account/
        public ActionResult Index()
        {
            return View("Login");
        }

        public ActionResult Login()
        {
            ViewBag.LoginState = "登录前";
            return View();
        }

        [HttpPost]
        public ActionResult Login(FormCollection fc)
        {
            String email = fc["inputEmail3"];
            String password = fc["inputPassword3"];
            ViewBag.LoginState = email + "登录完成";
            return View();
        }

        public ActionResult Register()
        {
            return View();
        }
        
	}
}