using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_DapperNorthwind.Dtos.CategoryDtos;

namespace Project_DapperNorthwind.Repositories.CategoryRepositories
{
    public interface ICategoryRepository
    {
        Task<List<ResultCategoryDto>> GetAllCategoriesAsync();    

        Task CreateCategoryAsync(CreateCategoryDto createCategoryDto);  
        Task UpdateCategoryAsync(UpdateCategoryDto updateCategoryDto);
        Task DeleteCategoryAsync(int id); 
        Task<GetByIdCategoryDto> GetCategoryByIdAsync(int id);  

    }
}
