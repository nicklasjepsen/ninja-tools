using Microsoft.AspNetCore.Mvc.RazorPages;
using NinjaTools.Pages.Shared;

namespace NinjaTools.Pages
{
    public class JsonModel : PageModel
    {
        public Base64TextAreaModel  JsonTextAreaVm { get; set; }

        public JsonModel()
        {
            JsonTextAreaVm = new Base64TextAreaModel
            {
                Name = "json",
                Title = "JSON"
            };
        }

        public void OnGet()
        {
            // Required by Razor
        }
    }
}
