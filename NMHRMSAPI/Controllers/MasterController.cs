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
    //[Authorize]
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
        [Route("GetCompanyGrades")]
        [AllowAnonymous]
        public IActionResult GetCompanyGrades()
        {
            try
            {
                var result = masterService.GetCompanyGrades();
                return Ok(result);
            }
            catch (Exception ex)
            {
                Trace.TraceError($"{ControllerContext.ActionDescriptor.ActionName}, ---Error - {ex.Message} ---> Additional Info - {(ex.InnerException != null ? ex.InnerException.Message : null)}");
                throw;
            }
        }

        [HttpDelete]
        [Route("DeleteGrade/{gradeId}")]
        public IActionResult DeleteGrade(int gradeId)
        {
            try
            {
                masterService.DeleteGrade(gradeId);
                return Ok(new { message = "Grade successfully deleted" });
            }
            catch (Exception ex)
            {
                Trace.TraceError($"{ControllerContext.ActionDescriptor.ActionName} - {JsonConvert.SerializeObject(gradeId)}, ---Error - {ex.Message} ---> Additional Info - {(ex.InnerException != null ? ex.InnerException.Message : null)}");
                return StatusCode(500, "Internal server error");
            }
        }

        [HttpGet]
        [Route("GetCountries")]
        [AllowAnonymous]
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

        [HttpGet]
        [Route("GetBranches")]
        public IActionResult GetBranches()
        {
            try
            {
                var result = masterService.GetBranches();
                return Ok(result);
            }
            catch (Exception ex)
            {
                Trace.TraceError($"{ControllerContext.ActionDescriptor.ActionName}, ---Error - {ex.Message} ---> Additional Info - {(ex.InnerException != null ? ex.InnerException.Message : null)}");
                throw;
            }
        }


        [HttpPost]
        [Route("AddUpdateBranch")]
        public IActionResult AddUpdateBranch(LocationDto locationDto)
        {
            try
            {
                masterService.AddUpdateBranch(locationDto);
                return Ok(locationDto);
            }
            catch (Exception ex)
            {
                Trace.TraceError($"{ControllerContext.ActionDescriptor.ActionName} - {JsonConvert.SerializeObject(locationDto)}, ---Error - {ex.Message} ---> Additional Info - {(ex.InnerException != null ? ex.InnerException.Message : null)}");
                throw;
            }
        }

        [HttpDelete]
        [Route("DeleteBranch/{locationId}")]
        public IActionResult DeleteBranch(int locationId)
        {
            try
            {
                masterService.DeleteBranch(locationId);
                return Ok(new { message = "Location successfully deleted" });
            }
            catch (Exception ex)
            {
                Trace.TraceError($"{ControllerContext.ActionDescriptor.ActionName} - {JsonConvert.SerializeObject(locationId)}, ---Error - {ex.Message} ---> Additional Info - {(ex.InnerException != null ? ex.InnerException.Message : null)}");
                return StatusCode(500, "Internal server error");
            }
        }

        [HttpGet]
        [Route("GetTitles")]
        public IActionResult GetTitles()
        {
            try
            {
                var result = masterService.GetTitles();
                return Ok(result);
            }
            catch (Exception ex)
            {
                Trace.TraceError($"{ControllerContext.ActionDescriptor.ActionName}, ---Error - {ex.Message} ---> Additional Info - {(ex.InnerException != null ? ex.InnerException.Message : null)}");
                throw;
            }
        }

        [HttpPost]
        [Route("AddUpdateTitle")]
        public IActionResult AddUpdateTitle(TitleDto titleDto)
        {
            try
            {
                masterService.AddUpdateTitle(titleDto);
                return Ok(titleDto);
            }
            catch (Exception ex)
            {
                Trace.TraceError($"{ControllerContext.ActionDescriptor.ActionName} - {JsonConvert.SerializeObject(titleDto)}, ---Error - {ex.Message} ---> Additional Info - {(ex.InnerException != null ? ex.InnerException.Message : null)}");
                throw;
            }
        }

        [HttpDelete]
        [Route("DeleteTitle/{titleId}")]
        public IActionResult DeleteTitle(int titleId)
        {
            try
            {
                masterService.DeleteTitle(titleId);
                return Ok(new { message = "Title successfully deleted" });
            }
            catch (Exception ex)
            {
                Trace.TraceError($"{ControllerContext.ActionDescriptor.ActionName} - {JsonConvert.SerializeObject(titleId)}, ---Error - {ex.Message} ---> Additional Info - {(ex.InnerException != null ? ex.InnerException.Message : null)}");
                return StatusCode(500, "Internal server error");
            }
        }

        [HttpGet]
        [Route("GetBloodGroups")]
        public IActionResult GetBloodGroups()
        {
            try
            {
                var result = masterService.GetBloodGroups();
                return Ok(result);
            }
            catch (Exception ex)
            {
                Trace.TraceError($"{ControllerContext.ActionDescriptor.ActionName}, ---Error - {ex.Message} ---> Additional Info - {(ex.InnerException != null ? ex.InnerException.Message : null)}");
                throw;
            }
        }

        [HttpPost]
        [Route("AddUpdateBloodGroup")]
        public IActionResult AddUpdateBloodGroup(BloodGroupDto bloodGroupDto)
        {
            try
            {
                masterService.AddUpdateBloodGroup(bloodGroupDto);
                return Ok(bloodGroupDto);
            }
            catch (Exception ex)
            {
                Trace.TraceError($"{ControllerContext.ActionDescriptor.ActionName} - {JsonConvert.SerializeObject(bloodGroupDto)}, ---Error - {ex.Message} ---> Additional Info - {(ex.InnerException != null ? ex.InnerException.Message : null)}");
                throw;
            }
        }

        [HttpDelete]
        [Route("DeleteBloodGroup/{bloodGroupId}")]
        public IActionResult DeleteBloodGroup(int bloodGroupId)
        {
            try
            {
                masterService.DeleteBloodGroup(bloodGroupId);
                return Ok(new { message = "Title successfully deleted" });
            }
            catch (Exception ex)
            {
                Trace.TraceError($"{ControllerContext.ActionDescriptor.ActionName} - {JsonConvert.SerializeObject(bloodGroupId)}, ---Error - {ex.Message} ---> Additional Info - {(ex.InnerException != null ? ex.InnerException.Message : null)}");
                return StatusCode(500, "Internal server error");
            }
        }

        [HttpGet]
        [Route("GetQualification")]
        public IActionResult GetQualification()
        {
            try
            {
                var result = masterService.GetQualification();
                return Ok(result);
            }
            catch (Exception ex)
            {
                Trace.TraceError($"{ControllerContext.ActionDescriptor.ActionName}, ---Error - {ex.Message} ---> Additional Info - {(ex.InnerException != null ? ex.InnerException.Message : null)}");
                throw;
            }
        }

        [HttpPost]
        [Route("AddUpdateQualification")]
        public IActionResult AddUpdateQualification(QualificationDto qualificationDto)
        {
            try
            {
                masterService.AddUpdateQualification(qualificationDto);
                return Ok(qualificationDto);
            }
            catch (Exception ex)
            {
                Trace.TraceError($"{ControllerContext.ActionDescriptor.ActionName} - {JsonConvert.SerializeObject(qualificationDto)}, ---Error - {ex.Message} ---> Additional Info - {(ex.InnerException != null ? ex.InnerException.Message : null)}");
                throw;
            }
        }

        [HttpDelete]
        [Route("DeleteQualification/{qualificationId}")]
        public IActionResult DeleteQualification(int qualificationId)
        {
            try
            {
                masterService.DeleteQualification(qualificationId);
                return Ok(new { message = "Qualification successfully deleted" });
            }
            catch (Exception ex)
            {
                Trace.TraceError($"{ControllerContext.ActionDescriptor.ActionName} - {JsonConvert.SerializeObject(qualificationId)}, ---Error - {ex.Message} ---> Additional Info - {(ex.InnerException != null ? ex.InnerException.Message : null)}");
                return StatusCode(500, "Internal server error");
            }
        }

        [HttpGet]
        [Route("GetContractTypes")]
        public IActionResult GetContractTypes()
        {
            try
            {
                var result = masterService.GetContractorTypes();
                return Ok(result);
            }
            catch (Exception ex)
            {
                Trace.TraceError($"{ControllerContext.ActionDescriptor.ActionName}, ---Error - {ex.Message} ---> Additional Info - {(ex.InnerException != null ? ex.InnerException.Message : null)}");
                throw;
            }
        }

        [HttpPost]
        [Route("AddUpdateContractorType")]
        public IActionResult AddUpdateContractorType(ContractTypeDto contractTypeDto)
        {
            try
            {
                masterService.AddUpdateContractorType(contractTypeDto);
                return Ok(contractTypeDto);
            }
            catch (Exception ex)
            {
                Trace.TraceError($"{ControllerContext.ActionDescriptor.ActionName} - {JsonConvert.SerializeObject(contractTypeDto)}, ---Error - {ex.Message} ---> Additional Info - {(ex.InnerException != null ? ex.InnerException.Message : null)}");
                throw;
            }
        }

        [HttpDelete]
        [Route("DeleteContract/{contractTypeId}")]
        public IActionResult DeleteContract(int contractTypeId)
        {
            try
            {
                masterService.DeleteContractorType(contractTypeId);
                return Ok(new { message = "Contract successfully deleted" });
            }
            catch (Exception ex)
            {
                Trace.TraceError($"{ControllerContext.ActionDescriptor.ActionName} - {JsonConvert.SerializeObject(contractTypeId)}, ---Error - {ex.Message} ---> Additional Info - {(ex.InnerException != null ? ex.InnerException.Message : null)}");
                return StatusCode(500, "Internal server error");
            }
        }

    }
}
