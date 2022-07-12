using System.Text;
using Microsoft.AspNetCore.Mvc;

namespace NinjaTools.Controllers
{
    public class HomeController : Controller
    {
        [HttpPost]
        [Consumes("text/plain")]
        [Route("base64/encode")]
        public async Task<IActionResult> Base64Encode()
        {
            using var reader = new StreamReader(Request.Body, Encoding.UTF8);
            var plainText = await reader.ReadToEndAsync();
            var plainTextBytes = Encoding.UTF8.GetBytes(plainText);
            var encoded = Convert.ToBase64String(plainTextBytes);
            return Ok(encoded);
        }
    }
}
