using System;
using System.Collections.Generic;
using System.Text;

namespace Imi.Project.Mobile.Domain
{
    public class GameItem
    {
        public long Id { get; set; }


        public List<string> Images { get; set; }
        public string CorrectlyImage { get; set; }
        public string FishName { get; set; }
    }
}
