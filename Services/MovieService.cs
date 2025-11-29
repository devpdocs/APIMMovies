using API.M.Movies.DAL.Models;
using API.M.Movies.Services.IServices;
using API.M.Movies.Repository.IRepository;
using API.M.Movies.DAL.Models.Dtos;
using AutoMapper;

namespace API.M.Movies.Services
{
    public class MovieService : IMovieService
    {
        private readonly IMovieRepository _movieRepository;
        private readonly IMapper _mapper;

        public MovieService(IMovieRepository categoryRepository, IMapper mapper)
        {
            _movieRepository = categoryRepository;
            _mapper = mapper;

        }

        public async Task<ICollection<MovieDtos>> GetMoviesAsync()
        {
            var categories = await _movieRepository.GetMoviesAsync();

            return _mapper.Map<ICollection<MovieDtos>>(categories);


        }

        public async Task<MovieDtos> GetMovieAsync(int id)
        {
            var category = await _movieRepository.GetMovieAsync(id);

            return _mapper.Map<MovieDtos>(category);

        }

        public Task<bool> MovieExistsByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> MovieExistsByNameAsync(string name)
        {
            throw new NotImplementedException();
        }

        public async Task<MovieDtos> CreateMovieAsync(MovieCreateDtos categoryCreateDtos)
        {
            var categoryExists = await _movieRepository.MovieExistsByNameAsync(categoryCreateDtos.Name);
            if (categoryExists)
            {
                throw new InvalidOperationException($"Ya existe una pelicula con el nombre de '{categoryCreateDtos.Name}'");
            }

            var category = _mapper.Map<Movie>(categoryCreateDtos);

            var categoryCreated = await _movieRepository.CreateMovieAsync(category);

            if (!categoryCreated)
            {
                throw new Exception("Ocurrió un error al crear la pelicula.");
            }

            return _mapper.Map<MovieDtos>(category);
        }

        public async Task<MovieDtos> UpdateMovieAsync(MovieCreateUpdateDtos dto, int id)
        {
            var categoryExists = await _movieRepository.GetMovieAsync(id);

            if (categoryExists == null)
            {
                throw new InvalidOperationException($"No se encontró la pelicula con ID: '{id}'");
            }

            var nameExists = await _movieRepository.MovieExistsByNameAsync(dto.Name);

            if (nameExists)
            {
                throw new InvalidOperationException($"Ya existe una pelicula con el nombre de '{dto.Name}'");
            }

            //Mapear el DTO a la entidad
            _mapper.Map(dto, categoryExists);

            //Actualizamos la categoria en el repositorio
            var categoryUpdated = await _movieRepository.UpdateMovieAsync(categoryExists);

            if (!categoryUpdated)
            {
                throw new Exception("Ocurrió un error al actualizar la pelicula.");
            }

            //Retornar el DTO actualizado
            return _mapper.Map<MovieDtos>(categoryExists);
        }

        public async Task<bool> DeleteMovieAsync(int id)
        {
            //Verificar si la pelicula existe
            var categoryExists = await _movieRepository.GetMovieAsync(id);

            if (categoryExists == null)
            {
                throw new InvalidOperationException($"No se encontró la pelicula con ID: '{id}'");
            }

            //Eliminar la pelicula del repositorio
            var categoryDeleted = await _movieRepository.DeleteMovieAsync(id);

            if (!categoryDeleted)
            {
                throw new Exception("Ocurrió un error al eliminar la pelicula.");
            }

            return categoryDeleted;
        }
    }
}
