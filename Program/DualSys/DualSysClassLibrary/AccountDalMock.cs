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
            else if(email== "player@mail.com")
            {
                key = "SuoTJf39E0qXR4792GayJw==";
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
            //DataSet set = new DataSet();
            //DataTable table = set.Tables.Add("Table1");
            //DataColumn column =
            //     table.Columns.Add("CompanyID", typeof(Int32));
            //     table.Columns.Add("CompanyName", typeof(string));
            //table.Columns.Add("CompanyLocation", typeof(string));
            //DataRow row = table.NewRow();
            //row[0] = 1;
            //row[1] = "company";
            //row[2] = "loc";

            //table.Rows.Add(row);

            //set.Tables.Add(table);

            //return set;
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
