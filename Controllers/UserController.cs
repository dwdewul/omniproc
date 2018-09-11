using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace omniproc.Controllers
{
    [Route("users")]
    public class UserController: Controller
    {
        [HttpGet("all")]
        public ActionResult GetUsers() {
            return Ok("Response works");
        }
    }
}