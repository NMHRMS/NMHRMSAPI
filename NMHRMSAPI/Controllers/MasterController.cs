using Application.Dtos.Employee;
using Application.Dtos.Master;
using Application.Interfaces.Employee;
using Application.Interfaces.Master;
using Application.Services.Employee;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Diagnostics;

namespace NMHRMSAPI.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class MasterController : ControllerBase
    {
        public readonly IMasterService masterService;

        /// <summary>
        /// Inject methods to Master controller
        /// </summary>
        /// <param name="masterService"></param>
        public MasterController(IMasterService masterService)
        {
            this.masterService = masterService;
        }

        [HttpPost]
        [Route("AddUpdateGrades")]
        public IActionResult AddUpdateGrades(CompanyGradeDto companyGradeDto)
        {
            try
            {
                masterService.AddUpdateGrades(companyGradeDto);
                return Ok(companyGradeDto);
            }
            catch (Exception ex)
            {
                Trace.TraceError($"{ControllerContext.ActionDescriptor.ActionName} - {JsonConvert.SerializeObject(companyGradeDto)}, ---Error - {ex.Message} ---> Additional Info - {(ex.InnerException != null ? ex.InnerException.Message : null)}");
                throw;
            }
        }

        [HttpGet]
        [Route("GetCountries")]
        public IActionResult GetCountries()
        {
            try
            {
                var result = masterService.GetCountries();
                return Ok(result);
            }
            catch (Exception ex)
            {
                Trace.TraceError($"{ControllerContext.ActionDescriptor.ActionName}, ---Error - {ex.Message} ---> Additional Info - {(ex.InnerException != null ? ex.InnerException.Message : null)}");
                throw;
            }
        }
    }
}
