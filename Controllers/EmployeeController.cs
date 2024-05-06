using B_UniversityManagement.DTOs;
using B_UniversityManagement.IRepository;
using B_UniversityManagement.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace B_UniversityManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeRepo employeeRepo;

        public EmployeeController(IEmployeeRepo employeeRepo)
        {
            this.employeeRepo = employeeRepo;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var employees = employeeRepo.GetAll();
            var employeeDTOs = TransferEmployee.TransferListToDto(employees);
            return Ok(employeeDTOs);
        }

        [HttpPost]
        public IActionResult Create(EmployeeDTO employeeDTO)
        {
            if (ModelState.IsValid)
            {
                var employee = TransferEmployee.TransferDtoToEmployee(employeeDTO);
                employeeRepo.Create(employee);
                return Ok(employeeDTO);
            }
            return BadRequest();
        }
    }
}
