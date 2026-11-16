using DB_Context_Employee.Interfaces;
using DB_Context_Employee.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EF_DataBase_Task.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        private readonly ICompanyRepositories _companyRepositories;

        public CompanyController(ICompanyRepositories companyRepositories)
        {
            _companyRepositories = companyRepositories;
        }

        [HttpPost("AddCompany")]
        public IActionResult AddCompany(Company company)
        {
            int result = _companyRepositories.AddCompany(company);
            if (result > 0)
            {
                return Ok("Company Added Successfully");
            }
            else
            {
                return BadRequest("Faild To Company");
            }
        }

    }
}
