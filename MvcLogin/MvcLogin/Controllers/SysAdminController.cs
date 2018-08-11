using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcLogin.Models;

namespace MvcLogin.Controllers
{
    public class SysAdminController : Controller
    {
        //
        // GET: /SysAdmin/
        public ActionResult Index()
        {
            return View("AdminLogin");
        }

        public ActionResult AdminLogin()
        {
            MvcLogin.Models.SysAdmin sysAdmin = new Models.SysAdmin()
            {
                LoginId = Convert.ToInt32(Request.Params["LoginId"]),
                LoginPwd = Request["LoginPwd"]
            };
            sysAdmin = new SysAdminService().AdminLogin(sysAdmin);
            if (sysAdmin != null)
            {
                ViewData["info"] = "欢迎您:" + sysAdmin.AdminName;
            }
            else
            {
                ViewData["info"] = "用户名或密码错误";
            }
            return View();
        }
    }
}