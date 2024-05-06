using B_UniversityManagement.Data;
using B_UniversityManagement.IRepository;
using B_UniversityManagement.Models;

namespace B_UniversityManagement.Repository
{
    public class LibraryRepo : ILibraryRepo
    {
        private readonly UniversityDbContext context;

        public LibraryRepo(UniversityDbContext context)
        {
            this.context = context;
        }

        public void Create(Library library)
        {
            context.Add(library);
            context.SaveChanges();
        }

        public void Update(Library library)
        {
            context.Update(library);
            context.SaveChanges();
        }

        public void Delete(Library library)
        {
            context.Remove(library);
            context.SaveChanges();
        }

        public List<Library> GetAll() => context.Libraries.ToList();

        public Library GetById(int id)
        {
            return context.Libraries.Find(id);
        }
    }
}
