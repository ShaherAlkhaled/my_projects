using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Imi.Project.Mobile.Domain.Interfaces
{
    public interface IAccountService
    {
        Task<string> Login(User user);
        Task Register(Register newUser);
        Task Logout();

    }
}
