using API.M.Movies.DAL.Models;
using API.M.Movies.Services.IServices;
using API.M.Movies.Repository.IRepository;
using API.M.Movies.DAL.Models.Dtos;
using AutoMapper;

namespace API.M.Movies.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;

        public CategoryService(ICategoryRepository categoryRepository, IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;

        }

        public async Task<ICollection<CategoryDtos>> GetCategoriesAsync()
        {
            var categories = await _categoryRepository.GetCategoriesAsync();

            var categoriesDtos = _mapper.Map<ICollection<CategoryDtos>>(categories);

            return categoriesDtos;

        }

        public Task<CategoryDtos> GetCategoryAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> CategoryExistsByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> CategoryExistsByNameAsync(string name)
        {
            throw new NotImplementedException();
        }

        public Task<bool> CreateCategoryAsync(Category category)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateCategoryAsync(Category category)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteCategoryAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
