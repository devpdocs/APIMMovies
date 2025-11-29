using API.M.Movies.DAL.Models;

namespace API.M.Movies.Repository.IRepository
{
    public interface IMovieRepository
    {
        Task<ICollection<Movie>> GetMoviesAsync();
        Task<Movie> GetMovieAsync(int id);
        Task<bool> MovieExistsByIdAsync (int id);
        Task<bool> MovieExistsByNameAsync (string name);
        Task<bool> CreateMovieAsync (Movie category);
        Task<bool> UpdateMovieAsync (Movie category);
        Task<bool> DeleteMovieAsync (int id);

    }
}

