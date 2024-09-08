using Imi.Project.Api.Core.Entities;
using Imi.Project.Api.Core.Interfaces.Repositories;
using Imi.Project.Api.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imi.Project.Api.Infrastructure.Repositories
{
    public class CategoryRepository : BaseRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
        public async Task<IEnumerable<Fish>> GetByCategoryIdAsync(long id)
        {
            var fishs = await _dbContext.Fishs
                .Include(f => f.Category)
                .Include(f => f.OriginCountry)
                .Include(f => f.FishProssings)
                .Where(f => f.CategoryId.Equals(id)).ToListAsync();
            return fishs;
        }
    }
}
