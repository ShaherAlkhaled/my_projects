using System.ComponentModel.DataAnnotations;

namespace Imi.Project.Blazor.Models
{
    public class BaseEntity
    {
        [Key]
        public long Id { get; set; }
        [Required (ErrorMessage ="Naam is verplicht")]
        public string Name { get; set; }
    }
}
