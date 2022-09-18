using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace KeyholeSoftware.AAfDSignalR.Application.API.Controllers
{
    [Authorize]
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class TestController : ControllerBase
    {

        [HttpPost]
        public string? TestAuthorization()
        {
            var identity = (ClaimsIdentity?)HttpContext.User.Identity;
            return identity?.Claims.Where(c => c.Type == "name").FirstOrDefault()?.Value;
        }
    }
}
