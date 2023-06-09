using DuelSysClassLibrary;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DuelSysWeb.Pages.tournament
{
    public class TournamentMatchesModel : PageModel
    {
        MatchManager matchManager = new MatchManager(new MatchDAL(),new TournamentManager(new TournamentDAL()));
        LeaderBoardManager LeaderBoardManager = new LeaderBoardManager(new LeaderboardDAL());

        public List<Match> Matches { get; set; }
        public List<LeaderBoard> leaderBoards { get; set; }
        public void OnGet(int? id,string? status)
        {
            if (id == null | id <= 0) RedirectToPage("./Index");
            else if (status == null || status == "") RedirectToPage("./Index");
            else
            Matches= matchManager.GetMatches((int)id);
            leaderBoards = LeaderBoardManager.getLeaderboard((int)id);
        }
    }
}
