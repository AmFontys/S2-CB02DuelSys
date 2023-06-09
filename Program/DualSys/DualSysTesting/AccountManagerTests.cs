﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
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
            Player expectedAccount = new Player(2, "Jenny", "Lizard", "jenny@gmail.com", "helpfullteam", DateTime.UtcNow, 'F', "streetAdress 1", "London", "secretPassword", "SuoTJf39E0qXR4792GayJw==");
            List<Player> actual = _accountManager.GetPlayers();
            Assert.AreEqual(expectedAccount.getTeam(), actual[0].getTeam());
        }

        [TestMethod()]
        public void GetAccountsSucces()
        {
            Account expectedAccount = new Account(1, "Benny", "Bob", "benny@gmail.com", DateTime.UtcNow, 'O', "streetAdress 1", "London", "secretPassword", "SuoTJf39E0qXR4792GayJw==");
            List<Account> actual = _accountManager.GetAccounts();
            Assert.AreEqual(expectedAccount.getEmail(), actual[0].getEmail());
        }

        [TestMethod()]
        public void GetStaffSucces()
        {
            Staff expectedAccount = new Staff(1,"Benny","Bob","benny@gmail.com",DateTime.UtcNow,'O',"streetaddress 1","London","secretPassword", "SuoTJf39E0qXR4792GayJw==",new company(1,"c","l"));
            List<Staff> actual = _accountManager.GetStaff();
            Assert.AreEqual(expectedAccount.getEmail(), actual[0].getEmail());
        }

        [TestMethod()]
        public void DeleteAccountFailWithInvalidNumber()
        {
            Assert.IsFalse(_accountManager.DeleteAccount(-1));
        }

        [TestMethod()]
        public void DeleteAccountFailWithValidNumber()
        {
            Assert.IsFalse(_accountManager.DeleteAccount(1));
        }
        [TestMethod()]
        public void DeleteAccountSucces()
        {
            Assert.IsTrue(_accountManager.DeleteAccount(2));
        }

        [TestMethod()]
        public void tournamentSignupFailTournament()
        {
            Assert.IsFalse(_accountManager.tournamentSignup("Bella@gmail.com", 0));
        }

        [TestMethod()]
        public void tournamentSignupFailEmail()
        {
            Assert.IsFalse(_accountManager.tournamentSignup("John@gmail.com", 1));
        }
        [TestMethod()]
        public void tournamentSignupFailMaxReached()
        {
            Assert.IsFalse(_accountManager.tournamentSignup("elly@gmail.com", 2));
        }

        [TestMethod()]
        public void tournamentSignupSucces()
        {           
            Assert.IsTrue(_accountManager.tournamentSignup("Bella@gmail.com", 1));
        }

        [TestMethod()]
        public void LoginTestPlayerFail()
        {
            bool succes = _accountManager.Login("player@mail", "123");
            Assert.IsFalse(succes);
        }

        [TestMethod()]
        public void LoginTestPlayerSucces()
        {
            bool succes = _accountManager.Login("player@mail.com", "123");
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