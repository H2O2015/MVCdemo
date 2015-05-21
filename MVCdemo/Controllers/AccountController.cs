using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCdemo.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {
            ViewBag.LoginState = "登录前...";
            return View();
        }

        [HttpPost]
        public ActionResult Login(FormCollection fc)
        {
            // 获取表单数据
            string email = fc["inputEmail3"];
            string password = fc["inputPassword3"];

            // 进行下一步处理
            ViewBag.LoginState = "登录后...";

            return View();
        }

        public ActionResult Register()
        {
            return View();
        }
    }
}