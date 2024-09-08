﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imi.Project.Mobile.Domain.Interfaces
{
    public interface IFishProcessingService
    {
        Task<IQueryable<FishProcessing>> Get();
    }
}
