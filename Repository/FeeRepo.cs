using B_UniversityManagement.Data;
using B_UniversityManagement.IRepository;
using B_UniversityManagement.Models;

namespace B_UniversityManagement.Repository
{
    public class FeeRepo : IFeeRepo
    {
        private readonly UniversityDbContext context;

        public FeeRepo(UniversityDbContext context)
        {
            this.context = context;
        }

        public void Create(Fee fee)
        {
            context.Add(fee);
            context.SaveChanges();
        }

        public void Update(Fee fee)
        {
            context.Update(fee);
            context.SaveChanges();
        }

        public void Delete(Fee fee)
        {
            context.Remove(fee);
            context.SaveChanges();
        }

        public List<Fee> GetAll() => context.Fees.ToList();

        public Fee GetById(int id)
        {
            return context.Fees.Find(id);
        }
    }
}
