using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NinjaTools.Pages.Shared;

namespace NinjaTools.Pages
{
    public class Base64Model : PageModel
    {
        public Base64TextAreaModel InputVm { get; set; }
        public Base64TextAreaModel EncodedVm { get; set; }

        public Base64Model()
        {
            InputVm = new Base64TextAreaModel
            {
                Name = "input"
            };
            EncodedVm = new Base64TextAreaModel
            {
                Name = "encoded"
            };
        }

        public void OnGet()
        {
            
        }
        public IActionResult OnGetPartial() =>
            Partial("_Base64TextArea");
       
    }
}
