using B_UniversityManagement.Data;
using B_UniversityManagement.IRepository;
using B_UniversityManagement.Models;

namespace B_UniversityManagement.Repository
{
    public class EmployeeRepo : IEmployeeRepo
    {
        private readonly UniversityDbContext context;

        public EmployeeRepo(UniversityDbContext context)
        {
            this.context = context;
        }

        public void Create(Employee employee)
        {
            context.Add(employee);
            context.SaveChanges();
        }

        public void Update(Employee employee)
        {
            context.Update(employee);
            context.SaveChanges();
        }

        public void Delete(Employee employee)
        {
            context.Remove(employee);
            context.SaveChanges();
        }

        public List<Employee> GetAll() => context.Employees.ToList();

        public Employee GetById(int id)
        {
            return context.Employees.Find(id);
        }
    }
}
