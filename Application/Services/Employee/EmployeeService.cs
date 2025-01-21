using Application.Dtos.Employee;
using Application.Interfaces.Employee;
using AutoMapper;
using Infrastructure.Data;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Employee
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IRepository repository;
        private readonly IMapper mapper;
        private readonly IConfiguration configuration;

        public EmployeeService(IRepository repository, IMapper mapper, IConfiguration configuration)
        {
            this.repository = repository;
            this.mapper = mapper;
            this.configuration = configuration;
        }

        #region Puublic Methods
        public object AddEmployee(AddEmployeeDto addEmployeeDto)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Private Methods
        #endregion
    }
}
