using B_UniversityManagement.Data;
using B_UniversityManagement.IRepository;
using B_UniversityManagement.Models;

namespace B_UniversityManagement.Repository
{
    public class BookRepo : IBookRepo
    {
        private readonly UniversityDbContext context;

        public BookRepo(UniversityDbContext context)
        {
            this.context = context;
        }

        public void Create(Book book)
        {
            _context.Add(book);
            _context.SaveChanges();
        }

        public void Update(Book book)
        {
            _context.Update(book);
            _context.SaveChanges();
        }

        public void Delete(Book book)
        {
            _context.Remove(book);
            _context.SaveChanges();
        }

        public List<Book> GetAll() => _context.Books.ToList();

        public Book GetById(int id)
        {
            return _context.Books.Find(id);
        }
    }
}
