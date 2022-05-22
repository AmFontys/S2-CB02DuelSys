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
        public void GetCompanysFail()
        {
            List<company> expected = new List<company>();
            List<company> actual = _companyManager.GetCompanys();
            Assert.AreEqual(expected.Count,actual.Count);
        }
        
    }
}