using CodeFlix.Models;

namespace CodeFlix.Interfaces;

public interface IMovieRepository : IRepository<Movie>
{
    List<Movie> ReadAllDetailed();

    Movie ReadByIdDetailed(int id);
}