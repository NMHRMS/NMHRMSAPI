using Application.Dtos.Auth;
using Application.Interfaces.Auth;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace NMHRMSAPI.Controllers
{
    /// <summary>
    /// To manage all login and user endpoints
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        /// <summary>
        /// Events to inject
        /// </summary>
        public readonly IAuthService authService;

        /// <summary>
        /// Inject methods to Auth controller
        /// </summary>
        /// <param name="authService"></param>
        public AuthController(IAuthService authService)
        {
            this.authService = authService;
        }

        [HttpPost]
        [Route("Login")]
        public IActionResult Login(LoginDto loginDto)
        {
            try
            {
                var result = authService.GetUser(loginDto);
                return Ok(result);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
