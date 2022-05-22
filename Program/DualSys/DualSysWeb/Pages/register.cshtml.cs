using DuelSysClassLibrary;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using System.Security.Claims;

namespace DuelSysWeb.Pages
{
    public class registerModel : PageModel
    {
        public string responseMessage { get; set; }
        [BindProperty]
        [Required]
        [DataType(DataType.EmailAddress)]
        [RegularExpression(@"^[^@\s]+@[^@\s]+\.[^@\s]+$", ErrorMessage = "The email is invalid")]

        public string Email { get; set; }
        [BindProperty][Required][DataType(DataType.Text)]
        public string Password { get; set; }
        [BindProperty]
        [Required]
        [DataType(DataType.Text)]
        [RegularExpression(@"^[a-zA-Z0-9_\-\s]*$", ErrorMessage = "There are invalid charters in the name")]

        public string Fname { get; set; }
        [BindProperty]
        [Required]
        [DataType(DataType.Text)]
        [RegularExpression(@"^[a-zA-Z0-9_\-\s]*$", ErrorMessage = "There are invalid charters in the name")]

        public string Lname { get; set; }
        [BindProperty]
        [Required]
        [DataType(DataType.DateTime)]
        
        public DateTime Birthdate { get; set; }
        [BindProperty]
        [Required]
        [DataType(DataType.Text)]
        [RegularExpression(@"^[a-zA-Z]*$", ErrorMessage = "There are invalid charters in the gender")]

        public char Gender { get; set; }
        [BindProperty]
        [Required]
        [DataType(DataType.Text)]
        [RegularExpression(@"^[a-zA-Z0-9_\-\s]*$", ErrorMessage = "There are invalid charters in the address")]

        public string Address { get; set; }
        [BindProperty]
        [Required]
        [DataType(DataType.Text)]
        [RegularExpression(@"^[a-zA-Z_\-\s]*$", ErrorMessage = "There are invalid charters in the town")]

        public string Town { get; set; }
        [BindProperty]
        [Required]
        [DataType(DataType.Text)]
        [RegularExpression(@"^[a-zA-Z0-9_\-\s]*$", ErrorMessage = "There are invalid charters in the team")]

        public string Team { get; set; }
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                AccountDAL dal = new();
                AccountManager manager = new(dal);
                if (manager.AddAccount(Fname, Lname, Email, Team, Birthdate, Gender, Address, Town, Password))
                {
                    List<Claim> claims = new List<Claim>();
                    claims.Add(new Claim(ClaimTypes.Email, Email));

                    var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                    HttpContext.SignInAsync(new ClaimsPrincipal(claimsIdentity));
                    return RedirectToPage("Index");
                }
                else return RedirectToPage("/register");
            }
            else
            {
                foreach (var item in ModelState.Values.SelectMany(v => v.Errors))
                    responseMessage += item.ErrorMessage + "<br>";
                return Page();
            }
        }
    }
}
