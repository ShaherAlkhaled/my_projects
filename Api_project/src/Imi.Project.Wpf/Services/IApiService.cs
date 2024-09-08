using Imi.Project.Wpf.ApiResponseModels.Account;
using Imi.Project.Wpf.ApiResponseModels.Category;
using Imi.Project.Wpf.ApiResponseModels.Fish;
using Imi.Project.Wpf.ApiResponseModels.OriginCountry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imi.Project.Wpf.Services
{
    public interface IApiService
    {
        Task<BaseServiceResponse<List<FishApiResponse>>> GetFishes();
        Task<BaseServiceResponse<object>> Delete(long fishId);
        Task<BaseServiceResponse<List<CategroyApiResponse>>> GetCategories();
        Task<BaseServiceResponse<List<OriginCountryApiResponse>>> GetCountries();
        Task<BaseServiceResponse<object>> Create(FishApiRequest newFish);
        Task<BaseServiceResponse<object>> Update(FishApiRequest updatFish);
        Task<BaseServiceResponse<FishApiResponse>> GetById(long fishId);

        Task<BaseServiceResponse<object>> Register(RegisterUserApiRequest newUser);
        Task<BaseServiceResponse<LoginUserApiResponse>> Login(LoginUserApiRequest user);
        Task Logout();
    }
}
