using B_UniversityManagement.Models;

namespace B_UniversityManagement.IRepository
{
    public interface ILibraryRepo
    {
        void Create(Library library);
        void Update(Library library);
        void Delete(Library library);
        List<Library> GetAll();
        Library GetById(int id);
    }
}
