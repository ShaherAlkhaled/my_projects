using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Imi.Project.Mobile.Domain.Interfaces
{
    public interface ILoginsService
    {
        Task<User> GetLogin();
        Task SaveLogin(User login);
    }
}
