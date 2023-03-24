using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Pets.Application.Output.Requests.VaccineRequest;
using Pets.Application.Output.Results.Interfaces;
using Pets.Domain.Entities.VaccineContext;

namespace Pets.Application.Repositories.VaccineContext
{
    public interface ICategoryRepository
    {
        void InsertCategory(Category category);
        IResultBase DeleteCategory(Guid categoryId);
        Task<CategoryRequest> GetAllCategoriesAsync();
    }
}