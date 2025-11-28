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

            return _mapper.Map<ICollection<CategoryDtos>>(categories);


        }

        public async Task<CategoryDtos> GetCategoryAsync(int id)
        {
            var category = await _categoryRepository.GetCategoryAsync(id);

            return  _mapper.Map<CategoryDtos>(category);

        }

        public Task<bool> CategoryExistsByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> CategoryExistsByNameAsync(string name)
        {
            throw new NotImplementedException();
        }

        public async Task<CategoryDtos> CreateCategoryAsync(CategoryCreateDtos categoryCreateDtos)
        {
            var categoryExists = await _categoryRepository.CategoryExistsByNameAsync(categoryCreateDtos.Name);
            if (categoryExists)
            {
                throw new InvalidOperationException($"Ya existe una categoría con el nombre de '{categoryCreateDtos.Name}'");
            }

            var category = _mapper.Map<Category>(categoryCreateDtos);

            var categoryCreated = await _categoryRepository.CreateCategoryAsync(category);

            if (!categoryCreated) 
            {
                throw new Exception("Ocurrió un error al crear la categoría.");
            }

            return  _mapper.Map<CategoryDtos>(category);
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
