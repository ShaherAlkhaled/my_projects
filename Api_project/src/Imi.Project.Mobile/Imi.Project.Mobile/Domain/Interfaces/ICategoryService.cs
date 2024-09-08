using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imi.Project.Mobile.Domain.Interfaces
{
    public interface ICategoryService
    {
        Task<IQueryable<Category>> Get();
        Task<Category> GetById(long id);
        //Task<Category> Add(Category newCategory);
        //Task Delete(long categoryId);
        //Task<Category> Update(Category existingCategory);
        Task<IQueryable<Fish>> GetFishesByCategoryIdAsync(long id);
    }
}
