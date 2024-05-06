using B_UniversityManagement.Models;

namespace B_UniversityManagement.IRepository
{
    public interface IFacultyRepo
    {
        void Create(Faculty faculty);
        void Update(Faculty faculty);
        void Delete(Faculty faculty);
        List<Faculty> GetAll();
        Faculty GetById(int id);
    }
}
