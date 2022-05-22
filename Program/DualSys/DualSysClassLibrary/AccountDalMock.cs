using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuelSysClassLibrary
{
    public class AccountDalMock : IAccountDAL
    {
        public bool AddAccount(Player account)
        {
            return true;
        }

        public bool AddAccount(Staff staff)
        {
            return true;
        }

        public bool CheckEmployeeKey(string email, string password)
        {
            return true;
        }

        public bool CheckValidEmail(string email, out string key)
        {
            key = "";
            if (email == "test@mail.com")
            {
                key = "E0qXR479SuoTJf392GayJw==";
                return true;
            }
            else return false;
        }

        public bool CheckValidPassword(string email, string password)
        {
            return true;
        }

        public bool DeleteAccount(int id)
        {
            return true;
        }

        public DataSet GetAccount(string email)
        {
            return new DataSet();
        }

        public DataSet GetAccount(string email, company company)
        {
            return new DataSet();
        }

        public DataSet GetAccounts()
        {
            return new DataSet();
        }

        public DataSet GetPlayers()
        {
            return new DataSet();
        }

        public DataSet GetStaff()
        {
            return new DataSet();
        }

        public bool tournamentSignup(int playerId, int tournamentId)
        {
            return true;
        }

        public bool UpdateAccount(Player player)
        {
            return true;
        }

        public bool UpdateAccount(Staff staff)
        {
            return true;
        }
    }
}
