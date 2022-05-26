using DuelSysClassLibrary;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DuelSysWeb.Pages.tournament
{
    public class tournamentInfo : PageModel
    {
        public Tournament Tournament { get; set; }
        private TournamentManager manager { get; set; }

        public int id { get; set; }
        public string message { get; set; }

        public void OnGet(int id,string? msg)
        {
            manager = new(new TournamentDAL());
            Tournament = manager.GetTournament(id);
            message = msg;
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid & User != null)
            {
                AccountManager accountManager = new AccountManager(new AccountDAL());
                string playerEmail =  User.FindFirst("email").Value;
                bool succesfull = accountManager.tournamentSignup(playerEmail, id);
                if (succesfull) return RedirectToPage($"tournamentInfo?id={id}&msg=succesfull");
                else return RedirectToPage($"tournamentInfo?id={id}&msg=unsuccesfull");
            }
            else if (User == null) return RedirectToPage("Login");
            else return Page();

        }
        
    }
}
