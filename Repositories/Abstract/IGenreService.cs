using BookStore.Models.Domain;

namespace BookStore.Repositories.Abstract
{
    public interface IGenreService
    {
        bool Add(Genre model);
        bool Delete(int id);
        bool Update(Genre model);
        Genre FindById(int id);
        IEnumerable<Genre> GetAll();
    }
}
