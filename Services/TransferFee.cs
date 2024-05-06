using B_UniversityManagement.DTOs;
using B_UniversityManagement.Models;

namespace B_UniversityManagement.Services
{
    public class TransferFee
    {
        public static FeeDTO TransferFeeToDto(Fee fee)
        {
            return new FeeDTO()
            {
                FeeId = fee.FeeId,
                FeeType = fee.FeeType,
                Amount = fee.Amount,
                PaymentDate = fee.PaymentDate,
                Status = fee.Status
            };
        }

        public static List<FeeDTO> TransferListToDto(List<Fee> fees)
        {
            List<FeeDTO> feeDTOs = new List<FeeDTO>();
            foreach (var fee in fees)
            {
                var dto = TransferFeeToDto(fee);
                feeDTOs.Add(dto);
            }
            return feeDTOs;
        }

        public static Fee TransferDtoToFee(FeeDTO feeDto)
        {
            return new Fee()
            {
                FeeId = feeDto.FeeId,
                FeeType = feeDto.FeeType,
                Amount = feeDto.Amount,
                PaymentDate = feeDto.PaymentDate,
                Status = feeDto.Status
            };
        }
    }
}
