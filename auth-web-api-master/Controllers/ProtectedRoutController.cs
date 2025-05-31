using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace auth_web_api_master.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class ProtectedRoutController : ControllerBase
    {
        // This endpoint is protected and requires authentication
        [HttpGet("secret")]
        [Authorize] // PROTECTINGT HE ROUTE
        public IActionResult GetSecret()
        {
            return Ok(new { message = "This is a protected route. You are authenticated!" });
        }

        // // This endpoint is protected and requires a specific role
        // [HttpGet("admin")]
        // [Authorize(Roles = "Admin")]
        // public IActionResult GetAdminSecret()
        // {
        //     return Ok(new { message = "This is an admin-only protected route." });
        // }
    }
}