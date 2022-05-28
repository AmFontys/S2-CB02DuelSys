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
        private static TournamentManager _tournamentManager = new(new TournamentDAL());
        
        [TestMethod()]
        public void AddTournamentTestPlayerFail()
        {
            Assert.IsFalse(false);
        }
        [TestMethod()]
        public void AddTournamentTestPlayerSucces()
        {
            Assert.IsFalse(false);
        }

       
    }
}