using System.Text;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace NinjaTools.Pages
{
    public class Base64Model : PageModel
    {
        public string Encoded { get; set; }
        private string input;

        public string Input
        {
            get => input;
            set
            {
                input = value;
                var plainTextBytes = Encoding.UTF8.GetBytes(input);
                Encoded = Convert.ToBase64String(plainTextBytes);
            }
        }
        
        public void OnGet()
        {
        }
    }
}
