using Application.Dtos.Auth;
using Application.Interfaces.Auth;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Diagnostics;

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

        [AllowAnonymous]
        [HttpPost]
        [Route("SignUp")]
        public IActionResult SignUp(SignUpDto SignUpDto)
        {
            try
            {
                authService.SignUp(SignUpDto);
                return Ok();
            }
            catch (Exception ex)
            {
                Trace.TraceError($"{ControllerContext.ActionDescriptor.ActionName} - {JsonConvert.SerializeObject(SignUpDto)}, ---Error - {ex.Message} ---> Additional Info - {(ex.InnerException != null ? ex.InnerException.Message : null)}");
                throw;
            }
        }
    }
}
