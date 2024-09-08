using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Imi.Project.Mobile.Domain.Interfaces
{
    public interface IFishService
    {
        Task<List<Fish>> Get();
        Task<Fish> GetById(long id);
        Task<Fish> Add(Fish newFish);
        Task Delete(long fishId);
        Task<Fish> Update(Fish existingFish);
        Task<IQueryable<Fish>> SearchAsync(string search);
        Task UploadImage(long id, Stream fileStream, string fileName);
    }
}
