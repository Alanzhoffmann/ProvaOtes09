using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ProvaOtes09.Pages
{
    public class ThankYouModel : PageModel
    {
        [FromForm]
        public string FirstName { get; set; }

        [FromForm]
        public string LastName { get; set; }

        [FromForm]
        public string Email { get; set; }

        [FromForm]
        public string PhoneNumber { get; set; }

        public void OnGet()
        {
        }
    }
}
