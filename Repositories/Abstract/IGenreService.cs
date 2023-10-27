using BookStore.Models.Domain;

namespace BookStore.Repositories.Abstract
{
    public interface IGenreService
    {
        bool Add(Book model);
        bool Delete(Book model);
        bool Update(Book model);
        bool FindById(Book model);
        IEnumerable<Book> GetAll();
    }
}
