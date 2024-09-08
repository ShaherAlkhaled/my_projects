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
    public class OriginCountryRepository : BaseRepository<OriginCountry>, IOriginCountryRepository
    {
        public OriginCountryRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }

        public async Task<IEnumerable<Fish>> GetByOriginCountryIdAsync(long id)
        {
            var fishs = await _dbContext.Fishs
                 .Include(f => f.FishProssings)
                .Include(f => f.Category)
                .Include(f => f.OriginCountry).Where(f => f.OriginCountryId.Equals(id)).ToListAsync();
            return fishs;
        }

    }
}
