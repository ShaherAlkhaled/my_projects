using Imi.Project.Blazor.Models;
using System.Threading.Tasks;

namespace Imi.Project.Blazor.Services.Interfaces
{
    public interface IAccountService
    {

        Task<LoginUserApiResponse> Login(UserAppilcation user);
        Task Register(RegisterAppilcation register);
        Task Logout();
        bool CheckLogIn();

    }
}
