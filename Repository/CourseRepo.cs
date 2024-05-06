using B_UniversityManagement.Data;
using B_UniversityManagement.IRepository;
using B_UniversityManagement.Models;

namespace B_UniversityManagement.Repository
{
    public class CourseRepo : ICourseRepo
    {
        private readonly UniversityDbContext context;

        public CourseRepo(UniversityDbContext context)
        {
            this.context = context;
        }

        public void Create(Course course)
        {
            context.Add(course);
            context.SaveChanges();
        }

        public void Update(Course course)
        {
            context.Update(course);
            context.SaveChanges();
        }

        public void Delete(Course course)
        {
            context.Remove(course);
            context.SaveChanges();
        }

        public List<Course> GetAll() => context.Courses.ToList();

        public Course GetById(int id)
        {
            return context.Courses.Find(id);
        }
    }
}
