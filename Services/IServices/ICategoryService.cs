using API.M.Movies.DAL.Models.Dtos;
using API.M.Movies.DAL.Models;

namespace API.M.Movies.Services.IServices
{
    public interface ICategoryService
    {
        Task<ICollection<CategoryDtos>> GetCategoriesAsync();
        Task<CategoryDtos> GetCategoryAsync(int id);
        Task<bool> CategoryExistsByIdAsync (int id);
        Task<bool> CategoryExistsByNameAsync (string name);
        Task<CategoryDtos> CreateCategoryAsync (CategoryCreateDtos category);
        Task<CategoryDtos> UpdateCategoryAsync (CategoryCreateUpdateDtos category, int id);
        Task<bool> DeleteCategoryAsync (int id);

    }
}

