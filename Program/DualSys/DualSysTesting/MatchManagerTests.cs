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
    public class MatchManagerTests
    {
        private static MatchManager _matchManager = new(new MatchDALMock(),new TournamentManager(new TournamentDALMock()));

        
        [TestMethod()]
        public void GetMacthesValid()
        {
            List<Match> matches = new List<Match>();
            Player player1 = new Player(10,"Bern","Shovel","bern@gmail.com","BernTheBest");
            Player player2 = new Player(20,"Emily","Pirt","pirt@doc.gov","goverment");
            Match match = new Match(1,player1,player2,0,0);
            matches.Add(match);
            List<Match> actual = _matchManager.GetMatches(1);
            Assert.AreEqual(matches[0].GetScore1(), actual[0].GetScore1());
        }

        [TestMethod()]
        public void GetMacthesInValid()
        {
            List<Match> matches = new List<Match>();
            Player player1 = new Player(10, "Bern", "Shovel", "bern@gmail.com", "BernTheBest");
            Player player2 = new Player(20, "Emily", "Pirt", "pirt@doc.gov", "goverment");
            Match match = new Match(1, player1, player2, 0, 0);
            matches.Add(match);
            List<Match> actual = _matchManager.GetMatches(0);
            Assert.AreNotEqual(matches, actual);
        }

        [TestMethod()]
        public void UpdateMacthesResultInValidTournament()
        {
            bool expected = false;
            string expectedError = "";
            bool actual = _matchManager.UpdateMatch(0,10,20,21,18,out string actualError);
            Assert.AreEqual((expected,expectedError), (actual,actualError));
        }

        [TestMethod()]
        public void UpdateMacthesResultInValidPlayer()
        {
            bool expected = false;
            string expectedError = "";
            bool actual = _matchManager.UpdateMatch(1,-10,20,21,18,out string actualError);
            Assert.AreEqual((expected,expectedError), (actual,actualError));
        }
        
        [TestMethod()]
        public void UpdateMacthesResultInValidScore()
        {
            bool expected = false;
            string expectedError = "";
            bool actual = _matchManager.UpdateMatch(1,10,20,-21,18,out string actualError);
            Assert.AreEqual((expected,expectedError), (actual,actualError));
        }
        [TestMethod()]
        public void UpdateMacthesResultValidTournamentInvalidPerson()
        {
            bool expected = false;
            string expectedError = "";
            bool actual = _matchManager.UpdateMatch(1,1,20,2,1,out string actualError);
            Assert.AreEqual((expected,expectedError), (actual,actualError));
        }

        [TestMethod()]
        public void UpdateMacthesResultValidTournamentAndvalidPerson()
        {
            bool expected = true;
            string expectedError = "";
            bool actual = _matchManager.UpdateMatch(1,1,3,2,1,out string actualError);
            Assert.AreEqual((expected,expectedError), (actual,actualError));
        }
        
        
    }
}