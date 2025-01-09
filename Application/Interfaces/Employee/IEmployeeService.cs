using Application.Dtos.Auth;
using Application.Dtos.Employee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.Employee
{
    public interface IEmployeeService
    {
        object AddEmployee(AddEmployeeDto addEmployeeDto);
    }
}
