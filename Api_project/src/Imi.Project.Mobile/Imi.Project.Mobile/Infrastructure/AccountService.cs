using Imi.Project.Mobile.Constants;
using Imi.Project.Mobile.Domain;
using Imi.Project.Mobile.Domain.Interfaces;
using System.Net.Http;
using System.Threading.Tasks;
using Xamarin.Essentials;

namespace Imi.Project.Mobile.Infrastructure
{
    public class AccountService : IAccountService
    {
        private readonly string _baseUri;

        public AccountService()
        {
            _baseUri = Url.BaseUri;
        }
        public async Task<string> Login(User user)
        {
           
            var currentUser = await WebApiClient.PostCallApi<User,User>($"{_baseUri}Accounts/login",user);
            await SecureStorage.SetAsync("token", currentUser.Token);
            return currentUser.Token;
            

        }

        public async Task Logout()
        {
            var token = await SecureStorage.GetAsync("token");
            if(token != null)
            {

              SecureStorage.Remove(token);
            }

        }

        public async Task Register(Register newUser)
        {
            await WebApiClient
                          .PostCallApi<Register, Register>($"{_baseUri}Accounts/register",newUser);
           
        }
    }
}
