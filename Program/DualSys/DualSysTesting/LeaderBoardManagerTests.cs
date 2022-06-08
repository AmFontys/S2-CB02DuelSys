using Microsoft.VisualStudio.TestTools.UnitTesting;
using DuelSysClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuelSysClassLibrary.Tests
{
    [TestClass()]
    public class LeaderBoardManagerTests
    {
        private static LeaderBoardManager _leaderBoardManager = new(new LeaderboardDALMock());

        
        [TestMethod()]
        public void GetLeaderBoardByInvalidID()
        {
            List<LeaderBoard> actual = _leaderBoardManager.getLeaderboard(-1);
            Assert.AreSame(null,actual);
        }

        [TestMethod()]
        public void GetLeaderBoardByvalidIDNoTournament()
        {

            List<LeaderBoard> actual = _leaderBoardManager.getLeaderboard(10);
            Assert.AreSame(null,actual);
        }
        [TestMethod()]
        public void GetLeaderBoardByvalidID()
        {
            Player player = new(4, "Lenny", "Fizzy", "lenny@gmail.com", "Fizzy colly");
            LeaderBoard leaderboard = new(player, 10);
            List<LeaderBoard> expected = new List<LeaderBoard>();
            expected.Add(leaderboard);

            List<LeaderBoard> actual = _leaderBoardManager.getLeaderboard(3);
            Assert.AreEqual(expected[0].ToString(),actual[0].ToString());
        }
        
       
        
    }
}