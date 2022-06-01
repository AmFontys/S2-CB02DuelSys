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
    public class ScheduleManagerTests
    {
        private static ScheduleManager _schedulleManager = new(new ScheduleDALMock(),new MatchDALMock());

        
        [TestMethod()]
        public void StartTournamentFailByID()
        {
            Tournament tournament = new(0, "Badminton", "dexr", 8, 10, "A", DateTime.UtcNow, DateTime.UtcNow.AddDays(1), null, null, new RoundRobin());
            int[] players = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            bool actual = _schedulleManager.StartTournament(tournament, players);
            Assert.IsFalse(actual);
        }
        [TestMethod()]
        public void StartTournamentFailByTournament()
        {
            Tournament tournament = null;
            int[] players = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            bool actual = _schedulleManager.StartTournament(tournament, players);
            Assert.IsFalse(actual);
        }
        [TestMethod()]
        public void StartTournamentFailByNullPlayers()
        {
            Tournament tournament = new(2, "BasketBall", "dexr", 8, 10, "A", DateTime.UtcNow, DateTime.UtcNow.AddDays(1), null, null, new RoundRobin());
            int[] players = null;

            bool actual = _schedulleManager.StartTournament(tournament, players);
            Assert.IsFalse(actual);
        }
        [TestMethod()]
        public void StartTournamentFailByToLessPlayers()
        {
            Tournament tournament = new(2, "BasketBall", "dexr", 8, 10, "A", DateTime.UtcNow, DateTime.UtcNow.AddDays(1), null, null, new RoundRobin());
            int[] players = new int[] { 1, 2, 3  };

            bool actual = _schedulleManager.StartTournament(tournament, players);
            Assert.IsFalse(actual);
        }
        [TestMethod()]
        public void StartTournamentSucces()
        {
            Tournament tournament = new(2, "BasketBall", "dexr", 8, 10, "A", DateTime.UtcNow, DateTime.UtcNow.AddDays(1), null, null, new RoundRobin());
            int[] players = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            bool actual = _schedulleManager.StartTournament(tournament, players);
            Assert.IsTrue(actual);

        }
       
        
    }
}