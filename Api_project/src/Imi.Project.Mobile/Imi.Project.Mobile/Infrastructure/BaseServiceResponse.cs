using System;
using System.Collections.Generic;
using System.Text;

namespace Imi.Project.Mobile.Infrastructure
{
    public  class BaseServiceResponse<T>
    {
        public bool IsSuccess { get; set; }
        public T Data { get; set; }
        public string ErrorMessage { get; set; }
    }
}
