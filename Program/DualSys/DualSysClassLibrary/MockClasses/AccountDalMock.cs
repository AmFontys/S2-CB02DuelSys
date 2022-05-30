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
            DataSet set = new DataSet();
            DataTable table = new DataTable();
            DataColumn column =
                 table.Columns.Add("AccountID", typeof(Int32));
            table.Columns.Add("Fname", typeof(string));
            table.Columns.Add("Lname", typeof(string));
            table.Columns.Add("email", typeof(string));
            table.Columns.Add("BirthDate", typeof(DateTime));
            table.Columns.Add("gender", typeof(char));
            table.Columns.Add("address", typeof(string));
            table.Columns.Add("town", typeof(string));
            table.Columns.Add("password", typeof(string));
            table.Columns.Add("keyword", typeof(string));
           
            for (int i = 0; i < 5; i++)
            {
                DataRow row = table.NewRow();
                row[0] = 2+i;
                row[1] = "fakeName"+i;
                row[2] = "Bob";
                row[3] = "benny@gmail.com";
                row[4] = DateTime.UtcNow;
                row[5] = 'O';
                row[6] = $"streetAdress {i}";
                row[7] = "London";
                row[8] = "secretPassword";
                row[9] = "SuoTJf39E0qXR4792GayJw==";

                table.Rows.Add(row);
            }
            set.Tables.Add(table);

            bool deleted = false;
            if (id == Convert.ToInt32(set.Tables[0].Rows[0][0]))
                return true;

            return deleted;
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
            DataSet set = new DataSet();
            DataTable table = new DataTable();
            DataColumn column =
                 table.Columns.Add("AccountID", typeof(Int32));
            table.Columns.Add("Fname", typeof(string));
            table.Columns.Add("Lname", typeof(string));
            table.Columns.Add("email", typeof(string));
            table.Columns.Add("BirthDate", typeof(DateTime));
            table.Columns.Add("gender", typeof(char));
            table.Columns.Add("address", typeof(string));
            table.Columns.Add("town", typeof(string));
            table.Columns.Add("password", typeof(string));
            table.Columns.Add("keyword", typeof(string));
            DataRow row = table.NewRow();
            row[0] = 1;
            row[1] = "Benny";
            row[2] = "Bob";
            row[3] = "benny@gmail.com";
            row[4] = DateTime.UtcNow;
            row[5] = 'O';
            row[6] = "streetAdress 1";
            row[7] = "London";
            row[8] = "secretPassword";
            row[9] = "SuoTJf39E0qXR4792GayJw==";

            table.Rows.Add(row);

            set.Tables.Add(table);

            return set;
        }

        public DataSet GetPlayers()
        {
            DataSet set = new DataSet();
            DataTable table = new DataTable();
            DataColumn column =
                 table.Columns.Add("AccountID", typeof(Int32));
            table.Columns.Add("Fname", typeof(string));
            table.Columns.Add("Lname", typeof(string));
            table.Columns.Add("email", typeof(string));
            table.Columns.Add("BirthDate", typeof(DateTime));
            table.Columns.Add("gender", typeof(char));
            table.Columns.Add("address", typeof(string));
            table.Columns.Add("town", typeof(string));
            table.Columns.Add("password", typeof(string));
            table.Columns.Add("keyword", typeof(string));
            table.Columns.Add("teamName", typeof(string));
            DataRow row = table.NewRow();
            row[0] = 2;
            row[1] = "Jenny";
            row[2] = "Lizard";
            row[3] = "jenny@gmail.com";
            row[4] = DateTime.UtcNow;
            row[5] = 'F';
            row[6] = "streetAdress 1";
            row[7] = "London";
            row[8] = "secretPassword";
            row[9] = "SuoTJf39E0qXR4792GayJw==";
            row[10] = "helpfullteam";

            table.Rows.Add(row);

            set.Tables.Add(table);

            return set;
        }

        public DataSet GetStaff()
        {
            DataSet set = new DataSet();
            DataTable table = new DataTable();
            DataColumn column =
                 table.Columns.Add("AccountID", typeof(Int32));
                 table.Columns.Add("Fname", typeof(string));
                 table.Columns.Add("Lname", typeof(string));
                 table.Columns.Add("email", typeof(string));
                 table.Columns.Add("BirthDate", typeof(DateTime));
                 table.Columns.Add("gender", typeof(char));
                 table.Columns.Add("address", typeof(string));
                 table.Columns.Add("town", typeof(string));
                 table.Columns.Add("password", typeof(string));
                 table.Columns.Add("keyword", typeof(string));
            table.Columns.Add("CompanyID", typeof(Int32));
            table.Columns.Add("CompanyName", typeof(string));
            table.Columns.Add("CompanyLocation", typeof(string));
            DataRow row = table.NewRow();
            row[0] = 1;
            row[1] = "Benny";
            row[2] = "Bob";
            row[3] = "benny@gmail.com";
            row[4] = DateTime.UtcNow;
            row[5] = 'O';
            row[6] = "streetAdress 1";
            row[7] = "London";
            row[8] = "secretPassword";
            row[9] = "SuoTJf39E0qXR4792GayJw==";

            row[10] = 1;
            row[11] = "c";
            row[12] = "l";

            table.Rows.Add(row);

            set.Tables.Add(table);

            return set;
        }

        public bool tournamentSignup(string playerEmail, int tournamentId)
        {
            if (tournamentId == 2) return false;
            
            else if (tournamentId == 1 & playerEmail == "Bella@gmail.com") return true;
            else return false;
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
