using B_UniversityManagement.DTOs;
using B_UniversityManagement.IRepository;
using B_UniversityManagement.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace B_UniversityManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FeeController : ControllerBase
    {
        private readonly IFeeRepo feeRepo;

        public FeeController(IFeeRepo feeRepo)
        {
            this.feeRepo = feeRepo;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var fees = feeRepo.GetAll();
            var feeDTOs = TransferFee.TransferListToDto(fees);
            return Ok(feeDTOs);
        }

        [HttpPost]
        public IActionResult Create(FeeDTO feeDTO)
        {
            if (ModelState.IsValid)
            {
                var fee = TransferFee.TransferDtoToFee(feeDTO);
                feeRepo.Create(fee);
                return Ok(feeDTO);
            }
            return BadRequest();
        }
    }
}
