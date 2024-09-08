using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imi.Project.Api.Core.Entities
{
    public class FishProcessing:BaseEntity
    {

        [Required]
        [StringLength(150, ErrorMessage = "Name can not be too long")]

        public string Name { get; set; }
       public ICollection<Fish> Fishs { get; set; }
    }
}
