using Application.Dtos.Auth;
using Application.Interfaces.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Auth
{
    /// <summary>
    /// Service to manage al operations related to auth.
    /// </summary>
    public class AuthService : IAuthService
    {
        /// <summary>
        /// Method to check valid user exist or not if yes, returns user detaails
        /// </summary>
        /// <param name="loginDto"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public object GetUser(LoginDto loginDto)
        {
            throw new NotImplementedException();
        }
    }
}
