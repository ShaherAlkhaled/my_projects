

using BlazorInputFile;
using Imi.Project.Blazor.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Imi.Project.Blazor.Services.Interfaces
{
    public interface ICrudService<T, L>
    {
        Task<List<T>> GetList();
        Task<L> GetNew();
        Task<L> GetFishById(long id);
        Task Create(L item);
        Task Update(L item);
        Task Delete(long id);
        Task FileUpload(IFileListEntry file, long id);
    }
}
