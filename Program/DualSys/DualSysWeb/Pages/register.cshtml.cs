using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DuelSysWeb.Pages
{
    public class registerModel : PageModel
    {
        [BindProperty]
        public string Email { get; set; }
        [BindProperty]
        public string Password { get; set; }
        [BindProperty]
        public string Fname { get; set; }
        [BindProperty]
        public string Lname { get; set; }
        [BindProperty]
        public DateTime Birthdate { get; set; }
        [BindProperty]
        public string Gender { get; set; }
        [BindProperty]
        public string Address { get; set; }
        [BindProperty]
        public string Town { get; set; }
        [BindProperty]
        public string Team { get; set; }
        public void OnGet()
        {
        }
    }
}
