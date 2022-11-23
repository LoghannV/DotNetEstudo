using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIDOIS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpGet]
        public IActionResult login(string username, string password)
        {
            return Ok(new {response = "Esta logado"});
        }
    }
}
