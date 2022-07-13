using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace NinjaTools.Pages.Shared
{
    public class Base64TextAreaModel : PageModel
    {
        public string Name { get; set; }
        public string Title {get; set;}

        public void OnGet()
        {
            // Needed by Razor
        }
    }
}
