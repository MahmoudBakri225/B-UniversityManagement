using B_UniversityManagement.Data;
using B_UniversityManagement.IRepository;
using B_UniversityManagement.Models;

namespace B_UniversityManagement.Repository
{
    public class FacultyRepo : IFacultyRepo
    {
        private readonly UniversityDbContext context;

        public FacultyRepo(UniversityDbContext context)
        {
            this.context = context;
        }
        public void Create(Faculty faculty)
        {
            context.Add(faculty);
            context.SaveChanges();
        }

        public void Delete(Faculty faculty)
        {
            throw new NotImplementedException();
        }

        public List<Faculty> GetAll() => context.Faculties.ToList();

        public Faculty GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Faculty college)
        {
            throw new NotImplementedException();
        }
    }
}
