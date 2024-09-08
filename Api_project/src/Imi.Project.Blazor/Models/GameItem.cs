using System.Collections.Generic;

namespace Imi.Project.Blazor.Models
{
    public class GameItem
    {
        public long Id { get; set; }
      

        public List<string> Images { get; set; }
        public string CorrectlyImage { get; set; }
        public string FishName { get; set; }
    }
}
