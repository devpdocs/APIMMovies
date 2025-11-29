using API.M.Movies.DAL.Models.Dtos;

namespace API.M.Movies.Services.IServices
{
    public interface IMovieService
    {
        Task<ICollection<MovieDtos>> GetMoviesAsync();
        Task<MovieDtos> GetMovieAsync(int id);
        Task<bool> MovieExistsByIdAsync (int id);
        Task<bool> MovieExistsByNameAsync (string name);
        Task<MovieDtos> CreateMovieAsync (MovieCreateDtos category);
        Task<MovieDtos> UpdateMovieAsync (MovieCreateUpdateDtos category, int id);
        Task<bool> DeleteMovieAsync (int id);

    }
}

