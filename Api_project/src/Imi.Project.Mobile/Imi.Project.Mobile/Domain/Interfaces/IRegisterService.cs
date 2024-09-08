using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Imi.Project.Mobile.Domain.Interfaces
{
    public interface IRegisterService
    {
        Task<Register> GetRegister();
        Task SaveRegister(Register register);
    }
}
