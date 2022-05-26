using DuelSysClassLibrary;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using System.Security.Claims;

namespace DuelSysWeb.Pages
{
    public class LoginModel : PageModel
    {
        [BindProperty]
        [Required]
        [DataType(DataType.EmailAddress)]
        [RegularExpression(@"^[^@\s]+@[^@\s]+\.[^@\s]+$", ErrorMessage = "The email is invalid")]
        public string email { get; set; }
        [BindProperty]
        [Required]
        [DataType(DataType.Text)]
        public string password { get; set; } 
        public void OnGet()
        {
            if (User != null) HttpContext.SignOutAsync() ; 
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                AccountManager manager = new AccountManager(new AccountDAL());
                if (manager.Login(email, password))
                {
                    List<Claim> claims = new List<Claim>();
                    claims.Add(new Claim(ClaimTypes.Email, email));

                    var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                    HttpContext.SignInAsync(new ClaimsPrincipal(claimsIdentity));
                    return RedirectToPage("Index");
                }
                else return Page();
            }
            else return Page();
        }
    }
}
