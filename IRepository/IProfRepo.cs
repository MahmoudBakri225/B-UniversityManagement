using B_UniversityManagement.Models;

namespace B_UniversityManagement.IRepository
{
    public interface IProfRepo
    {
        void Create(Prof prof);
        void Update(Prof prof);
        void Delete(Prof prof);
        List<Prof> GetAll();
        Prof GetById(int id);
    }
}
