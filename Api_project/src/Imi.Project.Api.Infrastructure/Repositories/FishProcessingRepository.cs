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
    public class FishProcessingRepository : BaseRepository<FishProcessing>, IFishProcessingRepository
    {
        public FishProcessingRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
        public async Task<IEnumerable<Fish>> GetByProcessingIdAsync(long id)
        {
            var fishs = await _dbContext.Fishs
                .Include(f => f.FishProssings)
                .Include(f => f.Category)
                .Include(f => f.OriginCountry)
                .Where(f => f.FishProssings.Any(pr => pr.Id.Equals(id)))
                .ToListAsync();
            return fishs;
        }

    }
}
