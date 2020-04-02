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
using MyNetCore.Controllers;
using NetCoreData;

namespace NewNetCore.Controllers
{
    public class HomeController : BaseController
    {
        public HomeController(NetCoreDbContext content) : base(content) { }
        public IActionResult Index()
        {
            return View();
        }
      
        public IActionResult Secret()
        {
            return View();
        }

        public IActionResult Header() 
        {

            return PartialView();
        }

        public IActionResult Menu()
        {

            return PartialView();
        }
    }
}