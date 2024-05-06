using B_UniversityManagement.DTOs;
using B_UniversityManagement.IRepository;
using B_UniversityManagement.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace B_UniversityManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfController : ControllerBase
    {
        private readonly IProfRepo profRepo;

        public ProfController(IProfRepo profRepo)
        {
            this.profRepo = profRepo;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var profs = profRepo.GetAll();
            var profDTOs = TransferProf.TransferListToDto(profs);
            return Ok(profDTOs);
        }

        [HttpPost]
        public IActionResult Create(ProfDTO profDTO)
        {
            if (ModelState.IsValid)
            {
                var prof = TransferProf.TransferDtoToProf(profDTO);
                profRepo.Create(prof);
                return Ok(profDTO);
            }
            return BadRequest();
        }
    }
}
