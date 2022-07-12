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

        [HttpPost]
        [Consumes("text/plain")]
        [Route("base64/decode")]
        public async Task<IActionResult> Base64Decode()
        {
            using var reader = new StreamReader(Request.Body, Encoding.UTF8);
            var input = await reader.ReadToEndAsync();

            if (IsBase64String(input))
            {
                return Ok(Encoding.UTF8.GetString(Convert.FromBase64String(input)));
            }
            return Ok();
        }

        public static bool IsBase64String(string base64)
        {
            var buffer = new Span<byte>(new byte[base64.Length]);
            return Convert.TryFromBase64String(base64, buffer, out _);
        }
    }
}
