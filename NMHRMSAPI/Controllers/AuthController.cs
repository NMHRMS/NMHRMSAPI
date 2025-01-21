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
        public IActionResult SignUp(SignUpDto signUpDto)
        {
            try
            {
                authService.SignUp(signUpDto);
                return Ok();
            }
            catch (Exception ex)
            {
                Trace.TraceError($"{ControllerContext.ActionDescriptor.ActionName} - {JsonConvert.SerializeObject(signUpDto)}, ---Error - {ex.Message} ---> Additional Info - {(ex.InnerException != null ? ex.InnerException.Message : null)}");
                throw;
            }
        }

        [AllowAnonymous]
        [HttpPost]
        [Route("Login")]
        public IActionResult Login(LoginDto loginDto)
        {
            try
            {
                var result = authService.Login(loginDto);
                return Ok(result);
            }
            catch (Exception ex)
            {
                Trace.TraceError($"{ControllerContext.ActionDescriptor.ActionName} - {JsonConvert.SerializeObject(loginDto)}, ---Error - {ex.Message} ---> Additional Info - {(ex.InnerException != null ? ex.InnerException.Message : null)}");
                throw;
            }
        }
        
        [AllowAnonymous]
        [HttpPost]
        [Route("GetLoginCompanies")]
        public IActionResult GetLoginCompanies(LoginDto loginDto)
        {
            try
            {
                var result = authService.GetLoginCompanies(loginDto);
                return Ok(result);
            }
            catch (Exception ex)
            {
                Trace.TraceError($"{ControllerContext.ActionDescriptor.ActionName} - {JsonConvert.SerializeObject(loginDto)}, ---Error - {ex.Message} ---> Additional Info - {(ex.InnerException != null ? ex.InnerException.Message : null)}");
                throw;
            }
        }
    }
}
