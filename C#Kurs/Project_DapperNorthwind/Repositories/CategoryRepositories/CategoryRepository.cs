using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_DapperNorthwind.Dtos.CategoryDtos;

namespace Project_DapperNorthwind.Repositories.CategoryRepositories
{
    public class CategoryRepository : ICategoryRepository
    {
        Task ICategoryRepository.CreateCategoryAsync(CreateCategoryDto createCategoryDto)
        {
            throw new NotImplementedException();
        }

        Task ICategoryRepository.DeleteCategoryAsync(int id)
        {
            throw new NotImplementedException();
        }

        Task<List<ResultCategoryDto>> ICategoryRepository.GetAllCategoriesAsync()
        {
            throw new NotImplementedException();
        }

        Task<GetByIdCategoryDto> ICategoryRepository.GetCategoryByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        Task ICategoryRepository.UpdateCategoryAsync(UpdateCategoryDto updateCategoryDto)
        {
            throw new NotImplementedException();
        }
    }
}
