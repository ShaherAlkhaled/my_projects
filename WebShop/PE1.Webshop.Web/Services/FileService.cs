using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using PE1.Webshop.Web.Services.Interfaces;
using System;
using System.IO;
using System.Threading.Tasks;

namespace PE1.Webshop.Web.Services
{
    public class FileService:IFileService
    {

        private readonly IWebHostEnvironment _webHostEnvironment;
        public FileService(IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;
        }
        public async Task<string> StoreFile(IFormFile file)
        {
            //create image path
            string fileName = $"{Guid.NewGuid()}_{file.FileName}";
            string filePath = Path
                .Combine(_webHostEnvironment.WebRootPath, "images", fileName);

            //store image
            using (FileStream fileStream = new(filePath, FileMode.Create))
            {
                await file.CopyToAsync(fileStream);
            }
            return fileName;
        }

    }
}
