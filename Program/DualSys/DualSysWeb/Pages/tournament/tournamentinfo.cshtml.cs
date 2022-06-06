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

        [BindProperty]
        public string status { get; set; }

        public IActionResult OnGet(int id,string? msg)
        {

            if (id >= 1)
            {
                manager = new(new TournamentDAL());
            Tournament = manager.GetTournament(id);
                if (msg != null)
                    message = msg;

                if (Tournament.getStatus() == "Available")
                    status = "Sign Up";
                else if (Tournament.getStatus() == "On going")
                    status = "See ongoing tournament";
                else if (Tournament.getStatus() == "Finished")
                    status = "See finished tournament";
                return Page();
            }
            else
            {
                return RedirectToPage("./");
            }
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid & User.Claims.Count()>0 & status == "Available")
            {
                AccountManager accountManager = new AccountManager(new AccountDAL());
                string playerEmail = User.Claims.First().Value;
                bool succesfull = accountManager.tournamentSignup(playerEmail, tourId);
                if (succesfull) return this.OnGet(tourId, "succesfull");
                else return this.OnGet(tourId, "unsuccesfull");
            }
            else if (User.Claims.Count() == 0) return RedirectToPage("~/Login");
            else if (ModelState.IsValid & User.Claims.Count() > 0  & status == "On going") return RedirectToPage("./TournamentMatches", new { id = tourId, status = "OnGoing" });
            else if (ModelState.IsValid & User.Claims.Count() > 0 & status == "Finished") return RedirectToPage("./TournamentMatches",new {id=tourId,status= "Finished" });


            else return this.OnGet(tourId, "Something whent wrong please try again");

        }
        
    }
}
