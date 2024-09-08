using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imi.Project.Api.Core.Dtos.FishProcessing
{
    public class FishProcessingRequestDto:BaseDto
    {

        [Required]
        public string Name { get; set; }
    }
}
