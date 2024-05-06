using B_UniversityManagement.DTOs;
using B_UniversityManagement.Models;

namespace B_UniversityManagement.Services
{
    public class TransferEmployee
    {
        public static EmployeeDTO TransferEmployeeToDto(Employee employee)
        {
            return new EmployeeDTO()
            {
                Id = employee.Id,
                Fname = employee.Fname,
                Lname = employee.Lname,
                Address = employee.Address,
                Phone = employee.Phone,
                Salary = employee.Salary,
                Email = employee.Email,
                DateOfBirth = employee.DateOfBirth,
                Password = employee.Password
            };
        }

        public static List<EmployeeDTO> TransferListToDto(List<Employee> employees)
        {
            List<EmployeeDTO> employeeDTOs = new List<EmployeeDTO>();
            foreach (var employee in employees)
            {
                var dto = TransferEmployeeToDto(employee);
                employeeDTOs.Add(dto);
            }
            return employeeDTOs;
        }

        public static Employee TransferDtoToEmployee(EmployeeDTO employeeDto)
        {
            return new Employee()
            {
                Id = employeeDto.Id,
                Fname = employeeDto.Fname,
                Lname = employeeDto.Lname,
                Address = employeeDto.Address,
                Phone = employeeDto.Phone,
                Salary = employeeDto.Salary,
                Email = employeeDto.Email,
                DateOfBirth = employeeDto.DateOfBirth,
                Password = employeeDto.Password
            };
        }
    }
}
