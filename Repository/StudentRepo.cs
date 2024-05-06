using B_UniversityManagement.Data;
using B_UniversityManagement.IRepository;
using B_UniversityManagement.Models;

namespace B_UniversityManagement.Repository
{
    public class StudentRepo : IStudentRepo
    {
        private readonly UniversityDbContext context;

        public StudentRepo(UniversityDbContext context)
        {
            this.context = context;
        }

        public void Create(Student student)
        {
            context.Add(student);
            context.SaveChanges();
        }

        public void Update(Student student)
        {
            context.Update(student);
            context.SaveChanges();
        }

        public void Delete(Student student)
        {
            context.Remove(student);
            context.SaveChanges();
        }

        public List<Student> GetAll() => context.Students.ToList();

        public Student GetById(int id)
        {
            return context.Students.Find(id);
        }
    }
}
