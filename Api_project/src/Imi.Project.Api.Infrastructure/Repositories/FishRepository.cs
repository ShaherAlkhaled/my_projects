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
    public class FishRepository : BaseRepository<Fish>, IFishRepository
    {
        public FishRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
        public override IQueryable<Fish> GetAll()
        {
            var fishs = _dbContext.Fishs.Include(f => f.Category).Include(f => f.OriginCountry).Include(f => f.FishProssings);
            return fishs;
        }

        public async override Task<IEnumerable<Fish>> ListAllAsync()
        {
            var fishs = await GetAll().ToListAsync();
            return fishs;
        }

        public async override Task<Fish> GetByIdAsync(long id)
        {
            var fish = await _dbContext.Fishs
                .Include(f => f.Category)
                .Include(f => f.OriginCountry)
                .Include(f => f.FishProssings)
                .SingleOrDefaultAsync(f => f.Id.Equals(id));
            return fish;
        }



        public async Task<IEnumerable<Fish>> SearchAsync(string search)
        {
            var fishs = await GetAll()
                .Where(
                f => f.Name.Contains(search)
                || f.Category.Name.Contains(search)
                || f.OriginCountry.Name.Contains(search)
                || f.FishProssings.Any(fp => fp.Name.Contains(search)))
                .ToListAsync();

            return fishs;
        }


    }
}
