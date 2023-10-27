using BookStore.Models.Domain;
using BookStore.Repositories.Abstract;

namespace BookStore.Repositories.Implementation
{
    public class GenreService : IGenreService
    {
        private readonly DatabaseContext _context;

        public GenreService(DatabaseContext context)
        {
            _context = context;
        }

        public bool Add(Book model)
        {
            try
            {
                _context.Add(model);
                _context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Delete(Book model)
        {
            throw new NotImplementedException();
        }

        public bool FindById(Book model)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Book> GetAll()
        {
            throw new NotImplementedException();
        }

        public bool Update(Book model)
        {
            throw new NotImplementedException();
        }
    }
}