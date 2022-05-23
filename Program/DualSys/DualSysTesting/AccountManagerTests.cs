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
    public class AccountManagerTests
    {
        private static AccountManager _accountManager = new(new AccountDalMock());
        private static CompanyManager _companyManager = new(new CompanyDalMock());

        [TestMethod()]
        public void AddAccountTestPlayerFail()
        {
            bool succes = _accountManager.AddAccount("acc0unt", "Last", "ename@mail", "Stp-Team", DateTime.UtcNow, 'F', "NoStreet", "Tribe", "N2rt");
            Assert.IsFalse(succes);
        }
        [TestMethod()]
        public void AddAccountTestPlayerSucces()
        {
            bool succes = _accountManager.AddAccount("account", "Last", "ename@mail.com","Stp-Team", DateTime.UtcNow, 'F', "NoStreet", "Tribe", "N2rt");
            Assert.IsTrue(succes);
        }

        [TestMethod()]
        public void AddAccountTestEmpFail()
        {
            bool succes = _accountManager.AddAccount("Nam3", "Last", "ename@mail.com", DateTime.UtcNow, 'F', "NoStreet", "Tribe", "N2rt", new company("CompanyTeam", "NoWhere"));
            Assert.IsFalse(succes);
        }
        [TestMethod()]
        public void AddAccountTestEmpSucces()
        {
            bool succes = _accountManager.AddAccount("Name", "Last", "ename@mail.com", DateTime.UtcNow, 'F', "NoStreet", "Tribe","N2rt", new company("CompanyTeam", "NoWhere"));
            Assert.IsTrue(succes);
        }

        [TestMethod()]
        public void UpdateAccountPlayerFailTown()
        {
            bool succes = _accountManager.UpdateAccount(1, "Samanta", "Ring", "emp@mail.com", "Team", DateTime.UtcNow, 'M', "Bristol", "L#ndon", "SmthRng");
            Assert.IsFalse(succes);
        }
        [TestMethod()]
        public void UpdateAccountPlayerFailName()
        {
            bool succes = _accountManager.UpdateAccount(1, "Samanta", "R1ng", "emp@mail.com", "Team", DateTime.UtcNow, 'M', "Bristol", "London", "SmthRng");
            Assert.IsFalse(succes);
        }
        [TestMethod()]
        public void UpdateAccountPlayerSucces()
        {
            bool succes = _accountManager.UpdateAccount(1, "Samanta", "Ring", "emp@mail.com","Team", DateTime.UtcNow, 'M', "Bristol", "London", "SmthRng");
            Assert.IsTrue(succes);
        }

        [TestMethod()]
        public void UpdateAccountEmpFailName()
        {
            bool succes = _accountManager.UpdateAccount(1, "Fr3dy", "Curry", "emp@mail.com", DateTime.UtcNow, 'M', "Bristol", "London", "Fr33dy", new company("Name", "Location"));
            Assert.IsFalse(succes);
        }
        [TestMethod()]
        public void UpdateAccountEmpFailMail()
        {
            bool succes = _accountManager.UpdateAccount(1, "Fredy", "Curry", "emp@mail", DateTime.UtcNow, 'M', "Bristol", "London", "Fr33dy", new company("Name", "Location"));
            Assert.IsFalse(succes);
        }
        [TestMethod()]
        public void UpdateAccountEmpSucces()
        {
            bool succes = _accountManager.UpdateAccount(1,"Fredy","Curry","emp@mail.com",DateTime.UtcNow,'M',"Bristol","London","Fr33dy",new company("Name","Location"));
            Assert.IsTrue(succes);
        }

        [TestMethod()]
        public void GetPlayersSucces()
        {
            List<Player> staffs = _accountManager.GetPlayers();
            Assert.AreEqual(1, staffs.Count);
        }

        [TestMethod()]
        public void GetAccountsSucces()
        {
            List<Account> actual = _accountManager.GetAccounts();
            Assert.AreEqual(1, actual.Count);
        }

        [TestMethod()]
        public void GetStaffSucces()
        {
            List<Staff> staffs = _accountManager.GetStaff();
            Assert.AreEqual(1,staffs.Count);
        }

        [TestMethod()]
        public void DeleteAccountFail()
        {
            Assert.IsFalse(_accountManager.DeleteAccount(-1));
        }

        [TestMethod()]
        public void DeleteAccountSucces()
        {
            Assert.IsTrue(_accountManager.DeleteAccount(1));
        }

        [TestMethod()]
        public void tournamentSignupFail()
        {
            //needs to be implented
            Assert.Fail();
        }

        [TestMethod()]
        public void tournamentSignupSucces()
        {
            //needs to be implented
            Assert.Fail();
        }

        [TestMethod()]
        public void LoginTestPlayerFail()
        {
            bool succes = _accountManager.Login("player@mail", "123", "");
            Assert.IsFalse(succes);
        }

        [TestMethod()]
        public void LoginTestPlayerSucces()
        {
            bool succes = _accountManager.Login("player@mail.com", "123", "");
            Assert.IsTrue(succes);
        }

        [TestMethod()]
        public void LoginTestEmpFail()
        {
            bool succes = _accountManager.Login("test@mail", "123", "");
            Assert.IsFalse(succes);
        }

        [TestMethod()]
        public void LoginTestEmpSucces()
        {
            bool succes = _accountManager.Login("test@mail.com", "123", "");
            Assert.IsTrue(succes);
        }

        [TestMethod()]
        public void LoginTestWrongEmail()
        {
            bool succes = _accountManager.Login("testing@mail.com", "123", "");
            Assert.IsFalse(succes);
        }

        [TestMethod()]
        public void GetCompanysSucces()
        {
            List<company> actual = _companyManager.GetCompanys();
            Assert.AreEqual(1,actual.Count);
        }
        
    }
}