using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Net.Http.Headers;

namespace NewNetCore.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [Authorize]
        public IActionResult Secret()
        {
            return View();
        }

        public IActionResult Login()
        {
            var claims = new List<Claim>()
            {
            new Claim(ClaimTypes.Name,"wzq"),
            new Claim(ClaimTypes.Email,"wzq@163")
            };
            var claimIdentity = new ClaimsIdentity(claims, "wzq claim");
            var claimPrincipal = new ClaimsPrincipal(new[] { claimIdentity });
            HttpContext.SignInAsync(claimPrincipal);
        
            return RedirectToAction("Index");
        }
    }
}