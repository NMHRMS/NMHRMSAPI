using Application.Dtos.Auth;
using Application.Interfaces.Auth;
using Domain.Models;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
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
        private readonly IRepository repository;

        public AuthService(IRepository repository)
        {
            this.repository = repository;
        }

        public object GetUser(LoginDto loginDto)
        {
            return repository.Get<Country>().AsQueryable().AsNoTracking().ToList();
        }
    }
}
