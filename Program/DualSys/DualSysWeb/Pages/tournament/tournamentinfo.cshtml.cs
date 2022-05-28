using DuelSysClassLibrary;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace DuelSysWeb.Pages.tournament
{
    public class tournamentInfo : PageModel
    {
        public Tournament Tournament { get; set; }
        private TournamentManager manager { get; set; }
        [BindProperty][Required]
        public int tourId { get; set; }
        public string message { get; set; }

        public IActionResult OnGet(int id,string? msg)
        {

            if (id >= 1)
            {
                manager = new(new TournamentDAL());
            Tournament = manager.GetTournament(id);
                if (msg != null)
                    message = msg;
                return Page();
            }
            else
            {
                return RedirectToPage("./");
            }
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid & User != null)
            {
                AccountManager accountManager = new AccountManager(new AccountDAL());
                string playerEmail = User.Claims.First().Value;
                bool succesfull = accountManager.tournamentSignup(playerEmail, tourId);
                if (succesfull) return this.OnGet(tourId,"succesfull");
                else return this.OnGet(tourId,"unsuccesfull");
            }
            else if (User == null) return RedirectToPage("./Login");
            else return this.OnGet(tourId,"Something whent wrong please try again");

        }
        
    }
}
