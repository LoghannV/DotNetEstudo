using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using APIDOIS.Controllers;
using System.Data.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace APIDOIS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        [HttpPost]
        public IActionResult login(UserModel user)
        {
            return Ok(new {response = "Esta logado"});
        }
    }
}
