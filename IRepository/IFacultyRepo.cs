using B_UniversityManagement.Models;

namespace B_UniversityManagement.IRepository
{
    public interface IFacultyRepo
    {
        void Create(Faculty college);
        void Update(Faculty college);
        void Delete(Faculty college);
        List<Faculty> GetAll();
        Faculty GetById(int id);
    }
}
