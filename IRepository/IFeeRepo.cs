using B_UniversityManagement.Models;

namespace B_UniversityManagement.IRepository
{
    public interface IFeeRepo
    {
        void Create(Fee fee);
        void Update(Fee fee);
        void Delete(Fee fee);
        List<Fee> GetAll();
        Fee GetById(int id);
    }
}
