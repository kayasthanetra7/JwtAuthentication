using JwtAuthentication.Helper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JwtAuthentication.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class JwtController : ControllerBase
    {
        [HttpGet]
       public IActionResult Jwt()
        {
            return new ObjectResult(JwtTokenHelper.GenerateToken());
        }
    }
}
