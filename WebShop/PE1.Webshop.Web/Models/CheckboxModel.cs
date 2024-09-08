using Microsoft.AspNetCore.Mvc;

namespace PE1.Webshop.Web.Models
{
    public class CheckboxModel
    {

        public bool IsSelected { get; set; }
        [HiddenInput]
        public string Name { get; set; }
        [HiddenInput]
        public long Id { get; set; }

    }
}
