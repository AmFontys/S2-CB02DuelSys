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
    public class TournamentManagerTests
    {
        private static TournamentManager _tournamentManager = new(new TournamentDALMock());
        
        [TestMethod()]
        public void AddTournamentTestNameFail()
        {
			bool succes = _tournamentManager.CreateTournament("M0thy", "Simple description", 9, 10, DateTime.UtcNow.AddDays(9), DateTime.UtcNow.AddDays(12), new RoundRobin(), new Sport(2, "BasketBall", "0-1"));
            Assert.IsFalse(succes);
        }

        [TestMethod()]
        public void AddTournamentTestDateFail()
        {
			bool succes = _tournamentManager.CreateTournament("Mothy", "Simple description", 9, 10, DateTime.UtcNow.AddDays(9), DateTime.UtcNow.AddDays(2), new RoundRobin(), new Sport(2, "BasketBall", "0-1"));
            Assert.IsFalse(succes);
        }

        [TestMethod()]
        public void AddTournamentTestMinMaxFail()
        {
			bool succes = _tournamentManager.CreateTournament("Mothy", "Simple description", 19, 10, DateTime.UtcNow.AddDays(9), DateTime.UtcNow.AddDays(12), new RoundRobin(), new Sport(2, "BasketBall", "0-1"));
            Assert.IsFalse(succes);
        }

        [TestMethod()]
        public void AddTournamentTestSucces()
        {
			bool succes = _tournamentManager.CreateTournament("Mothy", "Simple description", 9, 10, DateTime.UtcNow.AddDays(9), DateTime.UtcNow.AddDays(12), new RoundRobin(), new Sport(2, "BasketBall", "0-1"));
			Assert.IsTrue(succes);
        }
		

        [TestMethod()]
        public void UpdateTournamentTestSucces()
        {
			bool succes = _tournamentManager.UpdateTournament(1,"Mothy", "Simple description", 9, 10,"On going", DateTime.UtcNow.AddDays(9), DateTime.UtcNow.AddDays(12));
			Assert.IsTrue(succes);
        }

        [TestMethod()]
        public void UpdateTournamentTestIDFail()
        {
			bool succes = _tournamentManager.UpdateTournament(30,"Mothy", "Simple description", 9, 10,"On going", DateTime.UtcNow.AddDays(9), DateTime.UtcNow.AddDays(12));
			Assert.IsFalse(succes);
        }

        [TestMethod()]
        public void UpdateTournamentTestStatusFail()
        {
			bool succes = _tournamentManager.UpdateTournament(1,"Mothy", "Simple description", 9, 10,"", DateTime.UtcNow.AddDays(9), DateTime.UtcNow.AddDays(12));
			Assert.IsFalse(succes);
        }

        [TestMethod()]
        public void DeleteTournamentTestInvalidIDFail()
        {
			bool succes = _tournamentManager.DeleteTournament(0);
			Assert.IsFalse(succes);
        }
		

        [TestMethod()]
        public void DeleteTournamentTestValidIDFail()
        {
			bool succes = _tournamentManager.DeleteTournament(1);
			Assert.IsFalse(succes);
        }

        [TestMethod()]
        public void DeleteTournamentTestValidIDSucces()
        {
			bool succes = _tournamentManager.DeleteTournament(5);
			Assert.IsTrue(succes);
        }

        [TestMethod()]
        public void GetTournamentsTestSucces()
        {
			List<Tournament> expected = new List<Tournament>();
			expected.Add(new Tournament(1, "tour", "description", 2, 8, "Avaible", DateTime.UtcNow.AddDays(10), DateTime.UtcNow.AddDays(12), null, new Sport(2, "Sport", "0-2"), new RoundRobin()));
			List<Tournament> succes = _tournamentManager.GetTournaments("Avaible");
			Assert.AreEqual(expected[0].getTournamentDescription(),succes[0].getTournamentDescription());
        }

        [TestMethod()]
        public void GetTournamentsTestFail()
        {
            List<Tournament> succes = _tournamentManager.GetTournaments("");
			Assert.AreEqual(null,succes);
        }

        [TestMethod()]
        public void GetTournamentByNameTestFail()
        {
            //Is still in consideration if the method is needed
            Assert.IsFalse(false);
        }

        [TestMethod()]
        public void GetTournamentByIDTestFail()
        {
            Tournament succes = _tournamentManager.GetTournament(0);
            Assert.AreEqual(null, succes);
        }

        [TestMethod()]
        public void GetTournamentByIDTestSucces()
        {
           Tournament expected = new Tournament(1, "tour", "description", 2, 8, "Avaible", DateTime.UtcNow.AddDays(10), DateTime.UtcNow.AddDays(12), null, new Sport(2, "Sport", "0-2"), new RoundRobin());
            Tournament succes = _tournamentManager.GetTournament(1);
            Assert.AreEqual(expected.getTournamentName(), succes.getTournamentName());
        }
        
	}
}