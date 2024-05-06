using B_UniversityManagement.Data;
using B_UniversityManagement.IRepository;
using B_UniversityManagement.Models;
using Microsoft.EntityFrameworkCore;

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
            context.Remove(faculty);
            context.SaveChanges();
        }
        public List<Faculty> GetAll() => context.Faculties.ToList();

        public Faculty GetById(int id)
        {
            return context.Faculties.Find(id);
        }

        public void Update(Faculty faculty)
        {
            context.Update(faculty);
            context.SaveChanges();
        }
    }
}
