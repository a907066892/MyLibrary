using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NetCoreData;
using NetCoreData.Model;

namespace MyNetCore.Controllers
{
    [AllowAnonymous]
    public class AuthController : BaseController
    {
        public AuthController(NetCoreDbContext content) : base(content)
        {
        }
        #region View


        public IActionResult Index()
        {
            ViewData["Title"] = "Index";
            return View();
        }
        public ActionResult Users()
        {
            var users = new User();
            return Json(users.GetUsers());
        }

        public ActionResult UserList()
        {
            var users = new User();
            return View(users.GetUsers());
        }



        /// <summary>
        /// 登录
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }


        /// <summary>
        /// 注册页面
        /// </summary>
        /// <param name="_user"></param>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        #endregion




        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="_user"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Login([FromForm]User _user)
        {
            if (_content.User.Any(user => user.UserName == _user.UserName && user.PasswordHash == user.PasswordHash))
            {
                var userclaims = new List<Claim>
                {
                new Claim(ClaimTypes.Name,"wzq"),
                new Claim(ClaimTypes.Email,"9999@qq.com")
                };
                var grandmaIdentity = new ClaimsIdentity(userclaims, "userIdentity");
                var userPrincipal = new ClaimsPrincipal(new[] { grandmaIdentity });
                HttpContext.SignInAsync(userPrincipal);

                return RedirectToAction("Index", "Home");
            }
            return ErrorView("账户密码错误");
        }


        /// <summary>
        /// 注册
        /// </summary>
        /// <param name="_user"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Register([FromForm]User _user)
        {
            //验证是否存在
            User user = _content.User.ToList().Find(s => s.UserName == _user.UserName);
            if (user != null)
            {
                // 已存在
                return ErrorView("已存在");
            }

            _content.Add(_user);
            _content.SaveChanges();
            return View();
        }

        /// <summary>
        /// 退出
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult SignOut(User user)
        {
            HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return View();
        }

    }
}