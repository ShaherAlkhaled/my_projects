using System;
using System.Collections.Generic;
using System.Text;

namespace Imi.Project.Mobile.Domain
{
    public class FishProcessing
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public override string ToString()
        {
            return Name;
        }
    }
}
