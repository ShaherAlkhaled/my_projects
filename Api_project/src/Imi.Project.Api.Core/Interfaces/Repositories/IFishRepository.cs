﻿using Imi.Project.Api.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imi.Project.Api.Core.Interfaces.Repositories
{
    public interface IFishRepository:IBaseRepository<Fish>
    {
        Task<IEnumerable<Fish>> SearchAsync(string search);
    }
}
