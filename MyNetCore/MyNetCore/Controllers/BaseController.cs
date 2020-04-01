using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NetCoreData;

namespace MyNetCore.Controllers
{
    [Authorize]
    public class BaseController : Controller
    {
        protected NetCoreDbContext _content;
        protected BaseController(NetCoreDbContext content)
        {
            _content = content;
        }
        public IActionResult ErrorView(string ErrorMes, int StatusCode = 500)
        {
            ContentResult result = new ContentResult();
            result.Content=ErrorMes;
            result.ContentType = "application/json";
            result.StatusCode = StatusCode;
            return result;
        }
    }
}