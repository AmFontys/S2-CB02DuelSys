using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DuelSysWeb.Pages.tournament
{
    public class TournamentMatchesModel : PageModel
    {
        public void OnGet(int? id,string? status)
        {
            if (id == null | id <= 0) RedirectToPage("./");
            else if (status == null || status == "") RedirectToPage("./");


        }
    }
}
