using CodeFlix.Models;

namespace CodeFlix.Interfaces;

public interface IMovieGenreRepository
{
    void Create(int MovieId, byte GenreId);

    void Delete(int MovieId, byte GenreId);

    void Delete(int MovieId);

    List<MovieGenre> ReadMovieGenre();

    List<Movie> ReadMoviesByGenre(byte GenreId);

    List<Genre> ReadGenresByMovie(int MovieId);
}
