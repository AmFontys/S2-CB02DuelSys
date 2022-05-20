using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DuelSysWeb.Pages
{
    public class LoginModel : PageModel
    {
        [BindProperty]
        public string email { get; set; }
        [BindProperty]
        public string password { get; set; } 
        public void OnGet()
        {
        }

        public void OnPost()
        {

        }
    }
}
