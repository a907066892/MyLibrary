﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Controllers
{
    [Route("identity")]
    [Authorize]
    public class IdentityController : ControllerBase
    {

        public IActionResult Get() 
        {
            return new JsonResult(from c in User.Claims select new { c.Type, c.Value });
        }


    }
}
