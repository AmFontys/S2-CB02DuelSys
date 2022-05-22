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

        [TestMethod()]
        public void AddAccountTestPlayerFail()
        {
            Assert.Fail();
        }
        [TestMethod()]
        public void AddAccountTestPlayerSucces()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void AddAccountTestEmpFail()
        {
            Assert.Fail();
        }
        [TestMethod()]
        public void AddAccountTestEmpSucces()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void UpdateAccountPlayerFail()
        {
            Assert.Fail();
        }
        [TestMethod()]
        public void UpdateAccountPlayerSucces()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void UpdateAccountEmpFail()
        {
            Assert.Fail();
        }
        [TestMethod()]
        public void UpdateAccountEmpSucces()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetPlayersSucces()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetAccountsSucces()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetStaffSucces()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void DeleteAccountFail()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void DeleteAccountSucces()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void tournamentSignupFail()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void tournamentSignupSucces()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void LoginTestPlayerFail()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void LoginTestPlayerSucces()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void LoginTestEmpFail()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void LoginTestEmpSucces()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetCompanysFail()
        {
            Assert.Fail();
        }
        [TestMethod()]
        public void GetCompanysSucces()
        {
            Assert.Fail();
        }
    }
}