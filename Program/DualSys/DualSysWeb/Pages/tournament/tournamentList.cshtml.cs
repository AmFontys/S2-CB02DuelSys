using DuelSysClassLibrary;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DuelSysWeb.Pages.tournament
{
    public class tournamentListModel : PageModel
    {
        public Tournament[] Tournaments { get; set; }

        private TournamentManager manager { get; set; }

        public void OnGet(string id)
        {
            manager = new(new TournamentDAL());
            Tournaments = manager.GetTournaments(id).ToArray();
        }

        
    }
}
