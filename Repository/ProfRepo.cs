using B_UniversityManagement.Data;
using B_UniversityManagement.IRepository;
using B_UniversityManagement.Models;

namespace B_UniversityManagement.Repository
{
    public class ProfRepo : IProfRepo
    {
        private readonly UniversityDbContext context;

        public ProfRepo(UniversityDbContext context)
        {
            this.context = context;
        }

        public void Create(Prof prof)
        {
            context.Add(prof);
            context.SaveChanges();
        }

        public void Update(Prof prof)
        {
            context.Update(prof);
            context.SaveChanges();
        }

        public void Delete(Prof prof)
        {
            context.Remove(prof);
            context.SaveChanges();
        }

        public List<Prof> GetAll() => context.Profs.ToList();

        public Prof GetById(int id)
        {
            return context.Profs.Find(id);
        }
    }
}
