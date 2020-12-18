using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ProvaOtes09.Pages
{
    public class ThankYouModel : PageModel
    {
        [FromQuery]
        public string FirstName { get; set; }

        [FromQuery]
        public string LastName { get; set; }

        [FromQuery]
        public string Email { get; set; }

        [FromQuery]
        public string PhoneNumber { get; set; }

        public void OnGet()
        {
        }
    }
}
