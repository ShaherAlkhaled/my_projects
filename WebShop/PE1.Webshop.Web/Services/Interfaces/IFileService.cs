using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace PE1.Webshop.Web.Services.Interfaces
{
    public interface IFileService
    {
        Task<string> StoreFile(IFormFile file);

    }
}
