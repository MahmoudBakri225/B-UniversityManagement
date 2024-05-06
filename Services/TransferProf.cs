using B_UniversityManagement.DTOs;
using B_UniversityManagement.Models;

namespace B_UniversityManagement.Services
{
    public class TransferProf
    {
        public static ProfDTO TransferProfToDto(Prof prof)
        {
            return new ProfDTO()
            {
                Id = prof.Id,
                Fname = prof.Fname,
                Lname = prof.Lname,
                Gender = prof.Gender,
                Email = prof.Email,
                Phone = prof.Phone,
                Address = prof.Address,
                OfficeNumber = prof.OfficeNumber,
                Password = prof.Password,
                DateOfBirth = prof.DateOfBirth
            };
        }

        public static List<ProfDTO> TransferListToDto(List<Prof> profs)
        {
            List<ProfDTO> profDTOs = new List<ProfDTO>();
            foreach (var prof in profs)
            {
                var dto = TransferProfToDto(prof);
                profDTOs.Add(dto);
            }
            return profDTOs;
        }
        public static Prof TransferDtoToProf(ProfDTO profDto)
        {
            return new Prof()
            {
                Id = profDto.Id,
                Fname = profDto.Fname,
                Lname = profDto.Lname,
                Gender = profDto.Gender,
                Email = profDto.Email,
                Phone = profDto.Phone,
                Address = profDto.Address,
                OfficeNumber = profDto.OfficeNumber,
                Password = profDto.Password,
                DateOfBirth = profDto.DateOfBirth
            };
        }
    }
}
