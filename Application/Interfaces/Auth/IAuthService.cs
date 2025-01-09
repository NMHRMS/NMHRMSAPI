using Application.Dtos.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.Auth
{
    public interface IAuthService
    {
        void SignUp(SignUpDto signUpDto);
        object Login(LoginDto loginDto);
    }
}
